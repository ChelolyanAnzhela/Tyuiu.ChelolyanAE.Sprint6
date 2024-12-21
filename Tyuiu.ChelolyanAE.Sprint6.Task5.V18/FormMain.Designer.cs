namespace Tyuiu.ChelolyanAE.Sprint6.Task5.V18
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_CAE = new Panel();
            groupBoxTask_CAE = new GroupBox();
            buttonHelp_CAE = new Button();
            buttonOpen_CAE = new Button();
            buttonDone_CAE = new Button();
            textBoxTask_CAE = new TextBox();
            panelLeft_CAE = new Panel();
            groupBoxResult_CAE = new GroupBox();
            dataGridViewResult_CAE = new DataGridView();
            panelFill_CAE = new Panel();
            chartFunction_CAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_CAE.SuspendLayout();
            groupBoxTask_CAE.SuspendLayout();
            panelLeft_CAE.SuspendLayout();
            groupBoxResult_CAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CAE).BeginInit();
            panelFill_CAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAE).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CAE
            // 
            panelTop_CAE.Controls.Add(groupBoxTask_CAE);
            panelTop_CAE.Dock = DockStyle.Top;
            panelTop_CAE.Location = new Point(0, 0);
            panelTop_CAE.Name = "panelTop_CAE";
            panelTop_CAE.Size = new Size(1268, 125);
            panelTop_CAE.TabIndex = 0;
            // 
            // groupBoxTask_CAE
            // 
            groupBoxTask_CAE.Controls.Add(buttonHelp_CAE);
            groupBoxTask_CAE.Controls.Add(buttonOpen_CAE);
            groupBoxTask_CAE.Controls.Add(buttonDone_CAE);
            groupBoxTask_CAE.Controls.Add(textBoxTask_CAE);
            groupBoxTask_CAE.Dock = DockStyle.Top;
            groupBoxTask_CAE.Location = new Point(0, 0);
            groupBoxTask_CAE.Name = "groupBoxTask_CAE";
            groupBoxTask_CAE.Size = new Size(1268, 119);
            groupBoxTask_CAE.TabIndex = 0;
            groupBoxTask_CAE.TabStop = false;
            groupBoxTask_CAE.Text = "Условие";
            // 
            // buttonHelp_CAE
            // 
            buttonHelp_CAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_CAE.BackColor = Color.DeepSkyBlue;
            buttonHelp_CAE.Location = new Point(1128, 26);
            buttonHelp_CAE.Name = "buttonHelp_CAE";
            buttonHelp_CAE.Size = new Size(104, 74);
            buttonHelp_CAE.TabIndex = 3;
            buttonHelp_CAE.Text = "Справка";
            buttonHelp_CAE.UseVisualStyleBackColor = false;
            buttonHelp_CAE.Click += buttonHelp_CAE_Click;
            // 
            // buttonOpen_CAE
            // 
            buttonOpen_CAE.Anchor = AnchorStyles.Top;
            buttonOpen_CAE.BackColor = SystemColors.HotTrack;
            buttonOpen_CAE.Location = new Point(989, 26);
            buttonOpen_CAE.Name = "buttonOpen_CAE";
            buttonOpen_CAE.Size = new Size(113, 74);
            buttonOpen_CAE.TabIndex = 2;
            buttonOpen_CAE.Text = "Открыть файл";
            buttonOpen_CAE.UseVisualStyleBackColor = false;
            buttonOpen_CAE.Click += buttonOpen_CAE_Click;
            // 
            // buttonDone_CAE
            // 
            buttonDone_CAE.Anchor = AnchorStyles.Top;
            buttonDone_CAE.BackColor = Color.Green;
            buttonDone_CAE.Location = new Point(849, 26);
            buttonDone_CAE.Name = "buttonDone_CAE";
            buttonDone_CAE.Size = new Size(116, 74);
            buttonDone_CAE.TabIndex = 1;
            buttonDone_CAE.Text = "Выполнить";
            buttonDone_CAE.UseVisualStyleBackColor = false;
            buttonDone_CAE.Click += buttonDone_CAE_Click;
            // 
            // textBoxTask_CAE
            // 
            textBoxTask_CAE.BackColor = SystemColors.MenuBar;
            textBoxTask_CAE.BorderStyle = BorderStyle.None;
            textBoxTask_CAE.Location = new Point(12, 26);
            textBoxTask_CAE.Multiline = true;
            textBoxTask_CAE.Name = "textBoxTask_CAE";
            textBoxTask_CAE.Size = new Size(675, 63);
            textBoxTask_CAE.TabIndex = 0;
            textBoxTask_CAE.Text = "Прочитать данные из файла InPutFileTask5V18.txt. Вывести в вещественные значения в \r\ndataGridView и построить диаграмму по этим значениям.";
            // 
            // panelLeft_CAE
            // 
            panelLeft_CAE.Controls.Add(groupBoxResult_CAE);
            panelLeft_CAE.Dock = DockStyle.Left;
            panelLeft_CAE.Location = new Point(0, 125);
            panelLeft_CAE.Name = "panelLeft_CAE";
            panelLeft_CAE.Size = new Size(250, 398);
            panelLeft_CAE.TabIndex = 1;
            // 
            // groupBoxResult_CAE
            // 
            groupBoxResult_CAE.Controls.Add(dataGridViewResult_CAE);
            groupBoxResult_CAE.Dock = DockStyle.Left;
            groupBoxResult_CAE.Location = new Point(0, 0);
            groupBoxResult_CAE.Name = "groupBoxResult_CAE";
            groupBoxResult_CAE.Size = new Size(250, 398);
            groupBoxResult_CAE.TabIndex = 0;
            groupBoxResult_CAE.TabStop = false;
            groupBoxResult_CAE.Text = "Вывод данных:";
            // 
            // dataGridViewResult_CAE
            // 
            dataGridViewResult_CAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CAE.Location = new Point(6, 26);
            dataGridViewResult_CAE.Name = "dataGridViewResult_CAE";
            dataGridViewResult_CAE.RowHeadersWidth = 51;
            dataGridViewResult_CAE.Size = new Size(238, 366);
            dataGridViewResult_CAE.TabIndex = 0;
            dataGridViewResult_CAE.CellContentClick += dataGridViewResult_CAE_CellContentClick;
            // 
            // panelFill_CAE
            // 
            panelFill_CAE.Controls.Add(chartFunction_CAE);
            panelFill_CAE.Dock = DockStyle.Fill;
            panelFill_CAE.Location = new Point(250, 125);
            panelFill_CAE.Name = "panelFill_CAE";
            panelFill_CAE.Size = new Size(1018, 398);
            panelFill_CAE.TabIndex = 2;
            // 
            // chartFunction_CAE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CAE.ChartAreas.Add(chartArea1);
            chartFunction_CAE.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_CAE.Legends.Add(legend1);
            chartFunction_CAE.Location = new Point(0, 0);
            chartFunction_CAE.Name = "chartFunction_CAE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CAE.Series.Add(series1);
            chartFunction_CAE.Size = new Size(1018, 398);
            chartFunction_CAE.TabIndex = 0;
            chartFunction_CAE.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Диаграмма";
            chartFunction_CAE.Titles.Add(title1);
            chartFunction_CAE.Click += chartFunction_CAE_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 523);
            Controls.Add(panelFill_CAE);
            Controls.Add(panelLeft_CAE);
            Controls.Add(panelTop_CAE);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6|Таск5|Вариант18|Челольян Анжела Евгеньевна";
            panelTop_CAE.ResumeLayout(false);
            groupBoxTask_CAE.ResumeLayout(false);
            groupBoxTask_CAE.PerformLayout();
            panelLeft_CAE.ResumeLayout(false);
            groupBoxResult_CAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CAE).EndInit();
            panelFill_CAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAE;
        private GroupBox groupBoxTask_CAE;
        private Panel panelLeft_CAE;
        private Panel panelFill_CAE;
        private Button buttonDone_CAE;
        private TextBox textBoxTask_CAE;
        private GroupBox groupBoxResult_CAE;
        private Button buttonHelp_CAE;
        private Button buttonOpen_CAE;
        private DataGridView dataGridViewResult_CAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CAE;
    }
}
