using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private string _dp;
        private string _connectionString;

        private DbProviderFactory _dbProviderFactory;
        private DbConnection _dbConn;
        private DataTable _dataTable;

        private DbDataAdapter _dataAdapter;
        private DataSet _dataSet;


        public Form1()
        {
            InitializeComponent();
            //toolStripStatusLabel_Info.ForeColor = Color.Red;
            textBox_Query.Text = "select * from users";
            _dp = ConfigurationManager.AppSettings["MSSQLProvider"];
            _connectionString = ConfigurationManager.ConnectionStrings["MSSQLProvider"].ConnectionString;
            _dbProviderFactory = DbProviderFactories.GetFactory(_dp);
            _dbConn = _dbProviderFactory.CreateConnection();
            _dbConn.ConnectionString = _connectionString;

            _dataAdapter = _dbProviderFactory.CreateDataAdapter();
            _dataSet = new DataSet();

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_dataTable = new DataTable(); //пустая таблица
            ///*Определяю столбцы*/
            //_dataTable.Columns.Add("Id");
            //_dataTable.Columns.Add("Login");
            //_dataTable.Columns.Add("Email");
            //_dataTable.Columns.Add("Password");

            ///*создаю строку данных*/
            //DataRow dataRow = _dataTable.NewRow();
            //dataRow[0] = 1;
            //dataRow[1] = "Test user";
            //dataRow[2] = "testemail.om";
            //dataRow[3] = "qwerty";

            //_dataTable.Rows.Add(dataRow);
            ///*привязываю DataTable к DataGridView*/
            //dataGridView_Results.DataSource = _dataTable;
        }


        private void Execute()
        {
            DbDataReader resultReader = null;
            try
            {
                if (textBox_Query.Text.Length >= 5)
                {
                    _dataTable = new DataTable();
                    DbCommand dbSelectAllUsersCommand = _dbProviderFactory.CreateCommand();
                    dbSelectAllUsersCommand.Connection = _dbConn;
                    dbSelectAllUsersCommand.CommandText = textBox_Query.Text;
                    _dbConn.Open();
                    resultReader = dbSelectAllUsersCommand.ExecuteReader();
                    // write column names  caps                   
                    for (int i = 0; i < resultReader.FieldCount; i++)
                    {
                        _dataTable.Columns.Add(resultReader.GetName(i));
                    }
                    #region resultReader
                    //resultReader.Read();
                    //resultReader.Read();
                    //MessageBox.Show(resultReader[0].ToString());
                    // MessageBox.Show(resultReader.GetName(0));
                    // MessageBox.Show(resultReader.FieldCount.ToString());
                    #endregion
                    // create _dataTable
                    while (resultReader.Read())
                    {
                        DataRow currentRow = _dataTable.NewRow();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            currentRow[i] = resultReader[i];
                        }
                        _dataTable.Rows.Add(currentRow);
                    }
                    dataGridView_Results.DataSource = _dataTable;
                }
                else
                {
                    toolStripStatusLabel_Info.Text = "Тело  запроса не может быть пустым или содержать меньше 5 - ти символов ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _dbConn.Close();
                if (resultReader != null) resultReader.Close();
            }
        }




        private void button_Execute_Click(object sender, EventArgs e)
        {
            Execute();
        }


       
        private void button_DeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridView_Results.SelectedRows)// dataGridView_Results.SelectedRows - выделенные строки
            {
                try
                {
                    DbCommand deleteDbCommand = _dbProviderFactory.CreateCommand();// deleteDbCommand - объект для хранения и выполнения SQL запроса
                    deleteDbCommand.Connection = _dbConn;// соединение
                                   
                    int id = Int32.Parse(selectedRow.Cells[0].Value.ToString());// получаем значение  первого столбца выделенной строки 
                    DbParameter idParam = deleteDbCommand.CreateParameter();
                    idParam.DbType = System.Data.DbType.Int32;
                    idParam.ParameterName = "@id";
                    idParam.Value = id;
                    deleteDbCommand.Parameters.Add(idParam);
                  
                    deleteDbCommand.CommandText = $"DELETE FROM Users WHERE id = @id";
                    _dbConn.Open();
                    deleteDbCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _dbConn.Close();
                }
               
                #region find id
                // 1 version
                //DataRowView selected = selectedRow.DataBoundItem as DataRowView;
                //int id = Int32.Parse(selected.Row[0].ToString());

                // 2 version
                //int columnIndex = 0;
                //int id = Int32.Parse(selectedRow.Cells[columnIndex].Value.ToString());
                //string columnName = dataGridView_Results.Columns[columnIndex].DataPropertyName;
                //MessageBox.Show($"DELETE FROM Users WHERE {columnName} = {id}");

                // 3 version
                //int columnIndex = 0;
                //string value = selectedRow.Cells[columnIndex].Value.ToString();
                //string columnName = dataGridView_Results.Columns[columnIndex].DataPropertyName;
                //MessageBox.Show($"DELETE FROM Users WHERE {columnName} = {value}");
                #endregion
            }
            Execute();
        }
         
        private void buttonExecuteSet_Click(object sender, EventArgs e)
        {   
            try
            {
                if (textBox_Query.Text.Length >= 5)
                {
                    //dataAdapter.Fill() => select
                    //dataAdapter.Update() =>update,delete,insert

                    _dataSet.Clear();
                    DbCommand command = _dbProviderFactory.CreateCommand();// создание запрос
                    command.Connection = _dbConn; // передаем в command соединение
                    command.CommandText = textBox_Query.Text; // предаем текст запроса в command, textBox_Query это поле для ввода запроса
                    _dataAdapter.SelectCommand = command; // предаем  _dataAdapter тело запроса, соединение и т.д.
                    _dataAdapter.Fill(_dataSet);  // _dataAdapter заполняет  _dataSet данными, полученными при выполнении _dataAdapter.SelectCommand.                  
                    //dataGridView_Results.DataSource = _dataSet.Tables[0].DefaultView;
                    dataGridView_Results.DataSource = _dataSet.Tables[0]; 
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _dbConn.Close();
            }
        }



        // backup
        private void buttonExecuteUpdate_Click(object sender, EventArgs e)
        {
            DbCommand dbSelectCommand = _dbProviderFactory.CreateCommand();
            dbSelectCommand.Connection = _dbConn;
            dbSelectCommand.CommandText = textBox_Query.Text;
            _dataAdapter.SelectCommand = dbSelectCommand;
            _dataAdapter.Fill(_dataSet);


            //dbCommandBuilder.GetInsertCommand();
            //dbCommandBuilder.GetUpdateCommand();
            //dbCommandBuilder.GetDeleteCommand();
            //DbCommandBuilder dbCommandBuilder = _dbProviderFactory.CreateCommandBuilder();
            //dbCommandBuilder.DataAdapter = _dataAdapter;
            //_dataAdapter.Update(_dataSet);

            //_dataSet.Clear();
            //_dataAdapter.Fill(_dataSet);
            //dataGridView_Results.DataSource = _dataSet.Tables[0];

            /*Пользовательская логика - UpdateCommand ----------start*/



            //DbCommand dbCommandUpdate = _dbProviderFactory.CreateCommand();
            //dbCommandUpdate.Connection = _dbConn;
            //dbCommandUpdate.CommandText = "UPDATE users SET password = @pPassword WHERE Id = @iId";



            //DbParameter dbPasswordParameter = dbCommandUpdate.CreateParameter();
            //dbPasswordParameter.DbType = DbType.String;
            //dbPasswordParameter.ParameterName = "@pPassword";
            //dbPasswordParameter.SourceVersion = DataRowVersion.Current;
            //dbPasswordParameter.SourceColumn = "password";
            //dbCommandUpdate.Parameters.Add(dbPasswordParameter);



            //DbParameter dbIdParameter = dbCommandUpdate.CreateParameter();
            //dbIdParameter.DbType = DbType.Int32;
            //dbIdParameter.ParameterName = "@iId";
            //dbIdParameter.SourceColumn = "Id";
            //dbIdParameter.SourceVersion = DataRowVersion.Original;
            //dbCommandUpdate.Parameters.Add(dbIdParameter);



            //_dataAdapter.UpdateCommand = dbCommandUpdate;
            /*Пользовательская логика - UpdateCommand ----------end*/


            //DbCommand dbCommandDeleteUser = _dbProviderFactory.CreateCommand();
            //dbCommandDeleteUser.Connection = _dbConn;
            //dbCommandDeleteUser.CommandText = "DELETE FROM Users WHERE id = @ID";



            //DbParameter iParam = dbCommandDeleteUser.CreateParameter();
            //iParam.DbType = DbType.Int32;
            //iParam.ParameterName = "@ID";
            //iParam.SourceVersion = DataRowVersion.Current;
            //iParam.SourceColumn = "id";
            //dbCommandDeleteUser.Parameters.Add(iParam);
            //_dataAdapter.DeleteCommand= dbCommandDeleteUser;
            /*Пользовательская логика - UpdateCommand ----------end*/


            DbCommand dbCommandInsertUser = _dbProviderFactory.CreateCommand();
            dbCommandInsertUser.Connection = _dbConn;
            dbCommandInsertUser.CommandText = "INSERT INTO users(login, password) VALUES (@Login, @Password)";

            // parameter login
                    DbParameter param1 = dbCommandInsertUser.CreateParameter();
                    param1.DbType = DbType.String;
                    param1.ParameterName = "@Login";
                    param1.SourceColumn = "login";
                    param1.SourceVersion = DataRowVersion.Current;
                    dbCommandInsertUser.Parameters.Add(param1);

            // parameter password
                    DbParameter param2 = dbCommandInsertUser.CreateParameter();
                    param2.DbType = DbType.String;
                    param2.ParameterName = "@Password";
                    param2.SourceColumn = "password";
                    param2.SourceVersion = DataRowVersion.Current;
                    dbCommandInsertUser.Parameters.Add(param2);
                   _dataAdapter.InsertCommand = dbCommandInsertUser;

        }
            
        // if(textBox_RowFilter.Text.Length >= 5)
        //    {
        //        DataViewManager dataViewManager = new DataViewManager(_dataSet);
        //dataViewManager.DataViewSettings[0].RowFilter = textBox_RowFilter.Text;

 

        //        DataView dataViewFiltered = dataViewManager.CreateDataView(_dataSet.Tables[0]);
        //dataGridView_Results.DataSource = dataViewFiltered;
        //    }





}







        //private void button_Execute_Click(object sender, EventArgs e)
        //{
        //    DbDataReader resultReader = null;
        //    try
        //    {
        //        if (textBox_Query.Text.Length >= 5)
        //        {
        //            _dataTable = new DataTable();

        //            DbCommand dbSelectAllUsersCommand = _dbProviderFactory.CreateCommand();
        //            dbSelectAllUsersCommand.Connection = _dbConn;
        //            dbSelectAllUsersCommand.CommandText = textBox_Query.Text;
        //            _dbConn.Open();
        //            resultReader = dbSelectAllUsersCommand.ExecuteReader();
        //            //toolStripStatusLabel_Info.Text = resultReader.
        //            int line = 0;
        //            do
        //            {
        //                while (resultReader.Read())
        //                {
        //                    if (line == 0)
        //                    {
        //                        for (int i = 0; i < resultReader.FieldCount; i++)
        //                        {
        //                            _dataTable.Columns.Add(resultReader.GetName(i));
        //                        }
        //                        line++;
        //                    }
        //                    DataRow currentRow = _dataTable.NewRow();
        //                    for (int i = 0; i < resultReader.FieldCount; i++)
        //                    {
        //                        currentRow[i] = resultReader[i];
        //                    }
        //                    _dataTable.Rows.Add(currentRow);
        //                }
        //            } while (resultReader.NextResult());
        //            dataGridView_Results.DataSource = _dataTable;
        //        }
        //        else
        //        {
        //            toolStripStatusLabel_Info.ForeColor = Color.Red;
        //            toolStripStatusLabel_Info.Text = "Тело  запроса не межет быть пустым";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        _dbConn.Close();
        //        if(resultReader != null) resultReader.Close();
        //    }
        //}






    }
}
