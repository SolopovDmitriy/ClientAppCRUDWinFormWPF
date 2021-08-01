using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO_Disconnected_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _dp;
        private string _connectionString;

        private DbProviderFactory _dbProviderFactory;
        private DbConnection _dbConn;
        private DataTable _dataTable;
        private DbDataAdapter _dataAdapter;
        private DataSet _dataSet;

        public MainWindow()
        {
            InitializeComponent();
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance); //ручная регистрация фабрики
            _dp = ConfigurationManager.AppSettings["provider"];
            _connectionString = ConfigurationManager.ConnectionStrings["SqlProvider"].ConnectionString;
            _dbProviderFactory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            _dbConn = _dbProviderFactory.CreateConnection();
            _dbConn.ConnectionString = _connectionString;
            _dataAdapter = _dbProviderFactory.CreateDataAdapter();
            _dataSet = new DataSet();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*_dataTable = new DataTable();
            _dataTable.Columns.Add("ID");
            _dataTable.Columns.Add("Login");
            _dataTable.Columns.Add("Password");
            DataRow dataRow = _dataTable.NewRow();
            dataRow[0] = 1;
            dataRow[1] = "Tester";
            dataRow[2] = "ln1";
            
            _dataTable.Rows.Add(dataRow);
            _dataTable.AcceptChanges();
            dbDataView.ItemsSource = _dataTable.DefaultView;*/
        }

        private void ExecuteTrigger_Click(object sender, RoutedEventArgs e)
        {
            DbDataReader resultReader = null;
            LogBox.Text = "";
            LogBox.Foreground = Brushes.Black;
            try
            {
                if (QueryBox.Text.Length >= 5)
                {
                    _dataTable = new DataTable();

                    DbCommand dbSelectAllUsers = _dbProviderFactory.CreateCommand();
                    dbSelectAllUsers.Connection = _dbConn;
                    dbSelectAllUsers.CommandText = QueryBox.Text;
                    _dbConn.Open();
                    resultReader = dbSelectAllUsers.ExecuteReader();

                    int line = 0;
                    do
                    {
                        while (resultReader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i < resultReader.FieldCount; i++)
                                {
                                    _dataTable.Columns.Add(resultReader.GetName(i));
                                }
                                line++;
                            }
                            DataRow currentRow = _dataTable.NewRow();
                            for (int i = 0; i < resultReader.FieldCount; i++)
                            {
                                currentRow[i] = resultReader[i];
                            }
                            _dataTable.Rows.Add(currentRow);
                        }
                    } while (resultReader.NextResult());
                    DataGridView.ItemsSource = _dataTable.DefaultView;
                }
                else
                {
                    LogBox.Foreground = Brushes.Red;
                    LogBox.Text = "Query mustn't be empty";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _dbConn.Close();
                if (resultReader != null) resultReader.Close();
            }
        }

        private void QueryBox_MouseEnter(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "Enter your query here. Watch your syntax while typing query.";
        }

        private void QueryBox_MouseLeave(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "";
        }

        private void ExecuteTrigger_MouseEnter(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "This button executes query you typed";
        }

        private void ExecuteTrigger_MouseLeave(object sender, MouseEventArgs e)
        {
            if (LogBox.Text == "Query mustn't be empty") Thread.Sleep(2000);
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "";
        }

        private void dbDataView_MouseEnter(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "Query result will show right here";
        }

        private void dbDataView_MouseLeave(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "";
        }

        private void LogBox_MouseEnter(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "This box gives you all possible info about the program and your actions";
        }

        private void LogBox_MouseLeave(object sender, MouseEventArgs e)
        {
            LogBox.Foreground = Brushes.Black;
            LogBox.Text = "";
        }

        private void execDataSet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clicked");
            try
            {
                if (QueryBox.Text.Length >= 5)
                {
                    //dataAdapter.Fill() => select
                    //dataAdapter.Update() =>update,delete,insert

                    _dataSet.Clear();
                    DbCommand command = _dbProviderFactory.CreateCommand();
                    command.Connection = _dbConn;
                    command.CommandText = QueryBox.Text;
                    _dataAdapter.SelectCommand = command;
                    _dataAdapter.Fill(_dataSet);
                    DataGridView.ItemsSource = _dataSet.Tables[0].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void customUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbCommand dbSelectCommand = _dbProviderFactory.CreateCommand();
            dbSelectCommand.Connection = _dbConn;
            dbSelectCommand.CommandText = "SELECT * FROM users";
            _dataAdapter.SelectCommand = dbSelectCommand;

            _dataAdapter.Fill(_dataSet);
            //DataGridView.ItemsSource = _dataSet.Tables[0].DefaultView;

            DbCommandBuilder dbCommandBuilder = _dbProviderFactory.CreateCommandBuilder();
            dbCommandBuilder.DataAdapter = _dataAdapter;
            _dataAdapter.Update(_dataSet);

            //dbCommandBuilder.GetInsertCommand();
            //dbCommandBuilder.GetUpdateCommand();
            //dbCommandBuilder.GetDeleteCommand();

            _dataSet.Clear();
            _dataAdapter.Fill(_dataSet);
            DataGridView.ItemsSource = _dataSet.Tables[0].DefaultView;

        }
    }
}
