namespace Tyuiu.ChelolyanAE.Sprint6.Task3.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDone_CAE = new Button();
            buttonHelp_CAE = new Button();
            groupBoxTask_CAE = new GroupBox();
            textBox1 = new TextBox();
            groupBoxResult_CAE = new GroupBox();
            dataGridViewResult_CAE = new DataGridView();
            dataGridViewMatrix_CAE = new DataGridView();
            groupBoxTask_CAE.SuspendLayout();
            groupBoxResult_CAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CAE).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_CAE
            // 
            buttonDone_CAE.Location = new Point(921, 397);
            buttonDone_CAE.Name = "buttonDone_CAE";
            buttonDone_CAE.Size = new Size(127, 29);
            buttonDone_CAE.TabIndex = 0;
            buttonDone_CAE.Text = "Выполнить";
            buttonDone_CAE.UseVisualStyleBackColor = true;
            buttonDone_CAE.Click += buttonDone_CAE_Click;
            // 
            // buttonHelp_CAE
            // 
            buttonHelp_CAE.Location = new Point(862, 397);
            buttonHelp_CAE.Name = "buttonHelp_CAE";
            buttonHelp_CAE.Size = new Size(46, 29);
            buttonHelp_CAE.TabIndex = 1;
            buttonHelp_CAE.Text = "?";
            buttonHelp_CAE.UseVisualStyleBackColor = true;
            buttonHelp_CAE.Click += buttonHelp_CAE_Click;
            // 
            // groupBoxTask_CAE
            // 
            groupBoxTask_CAE.Controls.Add(textBox1);
            groupBoxTask_CAE.Location = new Point(28, 22);
            groupBoxTask_CAE.Name = "groupBoxTask_CAE";
            groupBoxTask_CAE.Size = new Size(442, 254);
            groupBoxTask_CAE.TabIndex = 2;
            groupBoxTask_CAE.TabStop = false;
            groupBoxTask_CAE.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(26, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 275);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в первом столбце.\r\n27 -15 14 2 27\r\n-8 14 -10 33 0\r\n1 7 -11 -11 23\r\n-13 -20 15 -16 34\r\n-3 1 -1 5 1";
            // 
            // groupBoxResult_CAE
            // 
            groupBoxResult_CAE.Controls.Add(dataGridViewResult_CAE);
            groupBoxResult_CAE.Location = new Point(767, 22);
            groupBoxResult_CAE.Name = "groupBoxResult_CAE";
            groupBoxResult_CAE.Size = new Size(309, 351);
            groupBoxResult_CAE.TabIndex = 3;
            groupBoxResult_CAE.TabStop = false;
            groupBoxResult_CAE.Text = "Вывод данных";
            // 
            // dataGridViewResult_CAE
            // 
            dataGridViewResult_CAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CAE.Location = new Point(22, 26);
            dataGridViewResult_CAE.Name = "dataGridViewResult_CAE";
            dataGridViewResult_CAE.RowHeadersWidth = 51;
            dataGridViewResult_CAE.Size = new Size(281, 288);
            dataGridViewResult_CAE.TabIndex = 1;
            // 
            // dataGridViewMatrix_CAE
            // 
            dataGridViewMatrix_CAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_CAE.Location = new Point(476, 34);
            dataGridViewMatrix_CAE.Name = "dataGridViewMatrix_CAE";
            dataGridViewMatrix_CAE.RowHeadersWidth = 51;
            dataGridViewMatrix_CAE.Size = new Size(285, 289);
            dataGridViewMatrix_CAE.TabIndex = 4;
            dataGridViewMatrix_CAE.CellContentClick += dataGridViewMatrix_CAE_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 450);
            Controls.Add(dataGridViewMatrix_CAE);
            Controls.Add(groupBoxResult_CAE);
            Controls.Add(groupBoxTask_CAE);
            Controls.Add(buttonHelp_CAE);
            Controls.Add(buttonDone_CAE);
            Name = "FormMain";
            Text = "Спринт6|Таск3|Вариант11|Челольян Анжела Евгеньевна";
            Load += FormMain_Load;
            groupBoxTask_CAE.ResumeLayout(false);
            groupBoxTask_CAE.PerformLayout();
            groupBoxResult_CAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_CAE;
        private Button buttonHelp_CAE;
        private GroupBox groupBoxTask_CAE;
        private TextBox textBox1;
        private GroupBox groupBoxResult_CAE;
        private DataGridView dataGridViewMatrix_CAE;
        private DataGridView dataGridViewResult_CAE;
    }
}
