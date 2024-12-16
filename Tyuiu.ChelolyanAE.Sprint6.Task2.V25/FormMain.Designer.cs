namespace Tyuiu.ChelolyanAE.Sprint6.Task2.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone_CAE = new Button();
            buttonHelp_CAE = new Button();
            groupBoxTask_CAE = new GroupBox();
            textBoxTask_CAE = new TextBox();
            groupBoxOne_CAE = new GroupBox();
            textBoxStop_CAE = new TextBox();
            textBoxStart_CAE = new TextBox();
            textBoxEndOne_CAE = new TextBox();
            textBoxStartOne_CAE = new TextBox();
            groupBoxResult_CAE = new GroupBox();
            chartFunction_CAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_CAE = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxResultOne_CAE = new TextBox();
            groupBoxTask_CAE.SuspendLayout();
            groupBoxOne_CAE.SuspendLayout();
            groupBoxResult_CAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_CAE).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_CAE
            // 
            buttonDone_CAE.BackColor = Color.Green;
            buttonDone_CAE.Location = new Point(524, 371);
            buttonDone_CAE.Name = "buttonDone_CAE";
            buttonDone_CAE.Size = new Size(123, 67);
            buttonDone_CAE.TabIndex = 0;
            buttonDone_CAE.Text = "Выполнить";
            buttonDone_CAE.UseVisualStyleBackColor = false;
            buttonDone_CAE.Click += buttonDone_CAE_Click;
            buttonDone_CAE.MouseEnter += buttonDone_CAE_MouseEnter;
            // 
            // buttonHelp_CAE
            // 
            buttonHelp_CAE.BackColor = SystemColors.MenuHighlight;
            buttonHelp_CAE.Location = new Point(396, 371);
            buttonHelp_CAE.Name = "buttonHelp_CAE";
            buttonHelp_CAE.Size = new Size(122, 67);
            buttonHelp_CAE.TabIndex = 1;
            buttonHelp_CAE.Text = "Справка";
            buttonHelp_CAE.UseVisualStyleBackColor = false;
            buttonHelp_CAE.Click += buttonHelp_CAE_Click;
            // 
            // groupBoxTask_CAE
            // 
            groupBoxTask_CAE.Controls.Add(textBoxTask_CAE);
            groupBoxTask_CAE.Location = new Point(21, 12);
            groupBoxTask_CAE.Name = "groupBoxTask_CAE";
            groupBoxTask_CAE.Size = new Size(613, 327);
            groupBoxTask_CAE.TabIndex = 2;
            groupBoxTask_CAE.TabStop = false;
            groupBoxTask_CAE.Text = "Условие";
            // 
            // textBoxTask_CAE
            // 
            textBoxTask_CAE.BackColor = SystemColors.MenuBar;
            textBoxTask_CAE.BorderStyle = BorderStyle.None;
            textBoxTask_CAE.Location = new Point(6, 26);
            textBoxTask_CAE.Multiline = true;
            textBoxTask_CAE.Name = "textBoxTask_CAE";
            textBoxTask_CAE.Size = new Size(577, 58);
            textBoxTask_CAE.TabIndex = 0;
            textBoxTask_CAE.Text = "Протабулировать функцию(5х+2,5/sinx-2)+2 на заданном диапазоне. Результат вывести в DataGridView и постоить график функции.\r\n";
            // 
            // groupBoxOne_CAE
            // 
            groupBoxOne_CAE.Controls.Add(textBoxStop_CAE);
            groupBoxOne_CAE.Controls.Add(textBoxStart_CAE);
            groupBoxOne_CAE.Controls.Add(textBoxEndOne_CAE);
            groupBoxOne_CAE.Controls.Add(textBoxStartOne_CAE);
            groupBoxOne_CAE.Location = new Point(27, 345);
            groupBoxOne_CAE.Name = "groupBoxOne_CAE";
            groupBoxOne_CAE.Size = new Size(363, 103);
            groupBoxOne_CAE.TabIndex = 3;
            groupBoxOne_CAE.TabStop = false;
            groupBoxOne_CAE.Text = "Ввод данных";
            // 
            // textBoxStop_CAE
            // 
            textBoxStop_CAE.Location = new Point(192, 52);
            textBoxStop_CAE.Name = "textBoxStop_CAE";
            textBoxStop_CAE.Size = new Size(125, 27);
            textBoxStop_CAE.TabIndex = 3;
            textBoxStop_CAE.TextChanged += textBoxStop_CAE_TextChanged;
            // 
            // textBoxStart_CAE
            // 
            textBoxStart_CAE.BackColor = SystemColors.Window;
            textBoxStart_CAE.Location = new Point(6, 52);
            textBoxStart_CAE.Name = "textBoxStart_CAE";
            textBoxStart_CAE.Size = new Size(125, 27);
            textBoxStart_CAE.TabIndex = 2;
            textBoxStart_CAE.TextChanged += textBoxStart_CAE_TextChanged;
            // 
            // textBoxEndOne_CAE
            // 
            textBoxEndOne_CAE.BackColor = SystemColors.MenuBar;
            textBoxEndOne_CAE.BorderStyle = BorderStyle.None;
            textBoxEndOne_CAE.Location = new Point(192, 26);
            textBoxEndOne_CAE.Name = "textBoxEndOne_CAE";
            textBoxEndOne_CAE.ReadOnly = true;
            textBoxEndOne_CAE.Size = new Size(125, 20);
            textBoxEndOne_CAE.TabIndex = 1;
            textBoxEndOne_CAE.Text = "Конец шага:";
            // 
            // textBoxStartOne_CAE
            // 
            textBoxStartOne_CAE.BackColor = SystemColors.MenuBar;
            textBoxStartOne_CAE.BorderStyle = BorderStyle.None;
            textBoxStartOne_CAE.Location = new Point(6, 26);
            textBoxStartOne_CAE.Name = "textBoxStartOne_CAE";
            textBoxStartOne_CAE.ReadOnly = true;
            textBoxStartOne_CAE.Size = new Size(125, 20);
            textBoxStartOne_CAE.TabIndex = 0;
            textBoxStartOne_CAE.Text = "Старт шага:";
            // 
            // groupBoxResult_CAE
            // 
            groupBoxResult_CAE.Controls.Add(chartFunction_CAE);
            groupBoxResult_CAE.Controls.Add(dataGridViewFunction_CAE);
            groupBoxResult_CAE.Controls.Add(textBoxResultOne_CAE);
            groupBoxResult_CAE.Location = new Point(653, 12);
            groupBoxResult_CAE.Name = "groupBoxResult_CAE";
            groupBoxResult_CAE.Size = new Size(448, 426);
            groupBoxResult_CAE.TabIndex = 4;
            groupBoxResult_CAE.TabStop = false;
            groupBoxResult_CAE.Text = "Вывод данных";
            // 
            // chartFunction_CAE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CAE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_CAE.Legends.Add(legend1);
            chartFunction_CAE.Location = new Point(149, 37);
            chartFunction_CAE.Name = "chartFunction_CAE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CAE.Series.Add(series1);
            chartFunction_CAE.Size = new Size(375, 375);
            chartFunction_CAE.TabIndex = 2;
            chartFunction_CAE.Text = "chart1";
            chartFunction_CAE.Click += chartFunction_CAE_Click;
            // 
            // dataGridViewFunction_CAE
            // 
            dataGridViewFunction_CAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_CAE.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_CAE.Location = new Point(18, 49);
            dataGridViewFunction_CAE.Name = "dataGridViewFunction_CAE";
            dataGridViewFunction_CAE.RowHeadersVisible = false;
            dataGridViewFunction_CAE.RowHeadersWidth = 51;
            dataGridViewFunction_CAE.Size = new Size(125, 363);
            dataGridViewFunction_CAE.TabIndex = 1;
            dataGridViewFunction_CAE.CellContentClick += dataGridViewFunction_CAE_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // textBoxResultOne_CAE
            // 
            textBoxResultOne_CAE.BackColor = SystemColors.MenuBar;
            textBoxResultOne_CAE.BorderStyle = BorderStyle.None;
            textBoxResultOne_CAE.Location = new Point(18, 23);
            textBoxResultOne_CAE.Name = "textBoxResultOne_CAE";
            textBoxResultOne_CAE.ReadOnly = true;
            textBoxResultOne_CAE.Size = new Size(125, 20);
            textBoxResultOne_CAE.TabIndex = 0;
            textBoxResultOne_CAE.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 450);
            Controls.Add(groupBoxResult_CAE);
            Controls.Add(groupBoxOne_CAE);
            Controls.Add(groupBoxTask_CAE);
            Controls.Add(buttonHelp_CAE);
            Controls.Add(buttonDone_CAE);
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Спринт6|Таск2|Вариант25|Челольян Анжела Евгеньевна";
            MouseDown += FormMain_MouseDown;
            MouseEnter += buttonDone_CAE_MouseEnter;
            MouseLeave += FormMain_MouseLeave;
            groupBoxTask_CAE.ResumeLayout(false);
            groupBoxTask_CAE.PerformLayout();
            groupBoxOne_CAE.ResumeLayout(false);
            groupBoxOne_CAE.PerformLayout();
            groupBoxResult_CAE.ResumeLayout(false);
            groupBoxResult_CAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_CAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_CAE;
        private Button buttonHelp_CAE;
        private GroupBox groupBoxTask_CAE;
        private TextBox textBoxTask_CAE;
        private GroupBox groupBoxOne_CAE;
        private TextBox textBoxStop_CAE;
        private TextBox textBoxStart_CAE;
        private TextBox textBoxEndOne_CAE;
        private TextBox textBoxStartOne_CAE;
        private GroupBox groupBoxResult_CAE;
        private DataGridView dataGridViewFunction_CAE;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private TextBox textBoxResultOne_CAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CAE;
    }
}
