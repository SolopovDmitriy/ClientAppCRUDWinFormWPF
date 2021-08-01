
namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.button_Execute = new System.Windows.Forms.Button();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_DeleteRow = new System.Windows.Forms.Button();
            this.buttonExecuteSet = new System.Windows.Forms.Button();
            this.buttonExecuteUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Query
            // 
            this.textBox_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Query.Location = new System.Drawing.Point(16, 16);
            this.textBox_Query.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.Size = new System.Drawing.Size(816, 36);
            this.textBox_Query.TabIndex = 0;
            // 
            // button_Execute
            // 
            this.button_Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Execute.Location = new System.Drawing.Point(843, 10);
            this.button_Execute.Margin = new System.Windows.Forms.Padding(4);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(217, 50);
            this.button_Execute.TabIndex = 1;
            this.button_Execute.Text = "Execute";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.Location = new System.Drawing.Point(17, 62);
            this.dataGridView_Results.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.RowHeadersWidth = 51;
            this.dataGridView_Results.Size = new System.Drawing.Size(816, 463);
            this.dataGridView_Results.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(0, 16);
            // 
            // button_DeleteRow
            // 
            this.button_DeleteRow.Location = new System.Drawing.Point(843, 110);
            this.button_DeleteRow.Name = "button_DeleteRow";
            this.button_DeleteRow.Size = new System.Drawing.Size(217, 62);
            this.button_DeleteRow.TabIndex = 4;
            this.button_DeleteRow.Text = "Delete Row";
            this.button_DeleteRow.UseVisualStyleBackColor = true;
            this.button_DeleteRow.Click += new System.EventHandler(this.button_DeleteRow_Click);
            // 
            // buttonExecuteSet
            // 
            this.buttonExecuteSet.Location = new System.Drawing.Point(843, 189);
            this.buttonExecuteSet.Name = "buttonExecuteSet";
            this.buttonExecuteSet.Size = new System.Drawing.Size(217, 57);
            this.buttonExecuteSet.TabIndex = 5;
            this.buttonExecuteSet.Text = "Execute Set";
            this.buttonExecuteSet.UseVisualStyleBackColor = true;
            this.buttonExecuteSet.Click += new System.EventHandler(this.buttonExecuteSet_Click);
            // 
            // buttonExecuteUpdate
            // 
            this.buttonExecuteUpdate.Location = new System.Drawing.Point(843, 279);
            this.buttonExecuteUpdate.Name = "buttonExecuteUpdate";
            this.buttonExecuteUpdate.Size = new System.Drawing.Size(217, 58);
            this.buttonExecuteUpdate.TabIndex = 6;
            this.buttonExecuteUpdate.Text = "Execute Update";
            this.buttonExecuteUpdate.UseVisualStyleBackColor = true;
            this.buttonExecuteUpdate.Click += new System.EventHandler(this.buttonExecuteUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonExecuteUpdate);
            this.Controls.Add(this.buttonExecuteSet);
            this.Controls.Add(this.button_DeleteRow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_Results);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.textBox_Query);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Query;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;
        private System.Windows.Forms.Button button_DeleteRow;
        private System.Windows.Forms.Button buttonExecuteSet;
        private System.Windows.Forms.Button buttonExecuteUpdate;
    }
}

