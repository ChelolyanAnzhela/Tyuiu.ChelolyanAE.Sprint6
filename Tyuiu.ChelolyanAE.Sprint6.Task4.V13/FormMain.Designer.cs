namespace Tyuiu.ChelolyanAE.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_CAE = new Panel();
            groupBoxResult_CAE = new GroupBox();
            buttonHelp_CAE = new Button();
            buttonSave_CAE = new Button();
            buttonDone_CAE = new Button();
            textBoxStop_CAE = new TextBox();
            textBoxStart_CAE = new TextBox();
            textBoxTwo_CAE = new TextBox();
            textBoxOne_CAE = new TextBox();
            groupBoxTask_CAE = new GroupBox();
            textBoxTask_CAE = new TextBox();
            panelLeft_CAE = new Panel();
            groupBoxResultTwo_CAE = new GroupBox();
            textBoxResult_CAE = new TextBox();
            splitterOne_CAE = new Splitter();
            panelFill_CAE = new Panel();
            chartFunction_CAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_CAE.SuspendLayout();
            groupBoxResult_CAE.SuspendLayout();
            groupBoxTask_CAE.SuspendLayout();
            panelLeft_CAE.SuspendLayout();
            groupBoxResultTwo_CAE.SuspendLayout();
            panelFill_CAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAE).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CAE
            // 
            panelTop_CAE.Controls.Add(groupBoxResult_CAE);
            panelTop_CAE.Controls.Add(groupBoxTask_CAE);
            panelTop_CAE.Dock = DockStyle.Top;
            panelTop_CAE.Location = new Point(0, 0);
            panelTop_CAE.Name = "panelTop_CAE";
            panelTop_CAE.Size = new Size(1252, 125);
            panelTop_CAE.TabIndex = 0;
            // 
            // groupBoxResult_CAE
            // 
            groupBoxResult_CAE.Controls.Add(buttonHelp_CAE);
            groupBoxResult_CAE.Controls.Add(buttonSave_CAE);
            groupBoxResult_CAE.Controls.Add(buttonDone_CAE);
            groupBoxResult_CAE.Controls.Add(textBoxStop_CAE);
            groupBoxResult_CAE.Controls.Add(textBoxStart_CAE);
            groupBoxResult_CAE.Controls.Add(textBoxTwo_CAE);
            groupBoxResult_CAE.Controls.Add(textBoxOne_CAE);
            groupBoxResult_CAE.Location = new Point(590, 3);
            groupBoxResult_CAE.Name = "groupBoxResult_CAE";
            groupBoxResult_CAE.Size = new Size(659, 122);
            groupBoxResult_CAE.TabIndex = 1;
            groupBoxResult_CAE.TabStop = false;
            groupBoxResult_CAE.Text = "Ввод данных";
            // 
            // buttonHelp_CAE
            // 
            buttonHelp_CAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_CAE.BackColor = Color.DodgerBlue;
            buttonHelp_CAE.Location = new Point(533, 26);
            buttonHelp_CAE.Name = "buttonHelp_CAE";
            buttonHelp_CAE.Size = new Size(106, 67);
            buttonHelp_CAE.TabIndex = 6;
            buttonHelp_CAE.Text = "Справка";
            buttonHelp_CAE.UseVisualStyleBackColor = false;
            buttonHelp_CAE.Click += buttonHelp_CAE_Click;
            // 
            // buttonSave_CAE
            // 
            buttonSave_CAE.Anchor = AnchorStyles.Top;
            buttonSave_CAE.BackColor = SystemColors.HotTrack;
            buttonSave_CAE.Location = new Point(411, 26);
            buttonSave_CAE.Name = "buttonSave_CAE";
            buttonSave_CAE.Size = new Size(116, 67);
            buttonSave_CAE.TabIndex = 5;
            buttonSave_CAE.Text = "Сохранить";
            buttonSave_CAE.UseVisualStyleBackColor = false;
            buttonSave_CAE.Click += buttonSave_CAE_Click;
            // 
            // buttonDone_CAE
            // 
            buttonDone_CAE.Anchor = AnchorStyles.Top;
            buttonDone_CAE.BackColor = Color.Green;
            buttonDone_CAE.Cursor = Cursors.AppStarting;
            buttonDone_CAE.Location = new Point(280, 26);
            buttonDone_CAE.Name = "buttonDone_CAE";
            buttonDone_CAE.Size = new Size(125, 67);
            buttonDone_CAE.TabIndex = 4;
            buttonDone_CAE.Text = "Выполнить";
            buttonDone_CAE.UseVisualStyleBackColor = false;
            buttonDone_CAE.Click += buttonDone_CAE_Click;
            // 
            // textBoxStop_CAE
            // 
            textBoxStop_CAE.Location = new Point(137, 66);
            textBoxStop_CAE.Name = "textBoxStop_CAE";
            textBoxStop_CAE.ScrollBars = ScrollBars.Vertical;
            textBoxStop_CAE.Size = new Size(125, 27);
            textBoxStop_CAE.TabIndex = 3;
            textBoxStop_CAE.TextChanged += textBoxStop_CAE_TextChanged;
            // 
            // textBoxStart_CAE
            // 
            textBoxStart_CAE.Location = new Point(0, 66);
            textBoxStart_CAE.Name = "textBoxStart_CAE";
            textBoxStart_CAE.ScrollBars = ScrollBars.Vertical;
            textBoxStart_CAE.Size = new Size(125, 27);
            textBoxStart_CAE.TabIndex = 2;
            textBoxStart_CAE.TextChanged += textBoxStart_CAE_TextChanged;
            // 
            // textBoxTwo_CAE
            // 
            textBoxTwo_CAE.BackColor = SystemColors.MenuBar;
            textBoxTwo_CAE.BorderStyle = BorderStyle.None;
            textBoxTwo_CAE.Location = new Point(137, 26);
            textBoxTwo_CAE.Name = "textBoxTwo_CAE";
            textBoxTwo_CAE.ReadOnly = true;
            textBoxTwo_CAE.Size = new Size(100, 20);
            textBoxTwo_CAE.TabIndex = 1;
            textBoxTwo_CAE.Text = "Конец шага:";
            textBoxTwo_CAE.TextChanged += textBoxTwo_CAE_TextChanged;
            // 
            // textBoxOne_CAE
            // 
            textBoxOne_CAE.BackColor = SystemColors.MenuBar;
            textBoxOne_CAE.BorderStyle = BorderStyle.None;
            textBoxOne_CAE.Location = new Point(6, 26);
            textBoxOne_CAE.Multiline = true;
            textBoxOne_CAE.Name = "textBoxOne_CAE";
            textBoxOne_CAE.ReadOnly = true;
            textBoxOne_CAE.Size = new Size(125, 34);
            textBoxOne_CAE.TabIndex = 0;
            textBoxOne_CAE.Text = "Старт шага:";
            // 
            // groupBoxTask_CAE
            // 
            groupBoxTask_CAE.Controls.Add(textBoxTask_CAE);
            groupBoxTask_CAE.Location = new Point(3, 3);
            groupBoxTask_CAE.Name = "groupBoxTask_CAE";
            groupBoxTask_CAE.Size = new Size(581, 122);
            groupBoxTask_CAE.TabIndex = 0;
            groupBoxTask_CAE.TabStop = false;
            groupBoxTask_CAE.Text = "Условие";
            // 
            // textBoxTask_CAE
            // 
            textBoxTask_CAE.BackColor = SystemColors.MenuBar;
            textBoxTask_CAE.BorderStyle = BorderStyle.None;
            textBoxTask_CAE.Location = new Point(15, 23);
            textBoxTask_CAE.Multiline = true;
            textBoxTask_CAE.Name = "textBoxTask_CAE";
            textBoxTask_CAE.ReadOnly = true;
            textBoxTask_CAE.Size = new Size(560, 70);
            textBoxTask_CAE.TabIndex = 1;
            textBoxTask_CAE.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V13.txt по нажатию кнопки\r\n";
            // 
            // panelLeft_CAE
            // 
            panelLeft_CAE.Controls.Add(groupBoxResultTwo_CAE);
            panelLeft_CAE.Controls.Add(splitterOne_CAE);
            panelLeft_CAE.Dock = DockStyle.Left;
            panelLeft_CAE.Location = new Point(0, 125);
            panelLeft_CAE.Name = "panelLeft_CAE";
            panelLeft_CAE.Size = new Size(250, 403);
            panelLeft_CAE.TabIndex = 1;
            // 
            // groupBoxResultTwo_CAE
            // 
            groupBoxResultTwo_CAE.Controls.Add(textBoxResult_CAE);
            groupBoxResultTwo_CAE.Location = new Point(12, 6);
            groupBoxResultTwo_CAE.Name = "groupBoxResultTwo_CAE";
            groupBoxResultTwo_CAE.Size = new Size(238, 397);
            groupBoxResultTwo_CAE.TabIndex = 0;
            groupBoxResultTwo_CAE.TabStop = false;
            groupBoxResultTwo_CAE.Text = "Вывод:";
            // 
            // textBoxResult_CAE
            // 
            textBoxResult_CAE.BackColor = SystemColors.ButtonHighlight;
            textBoxResult_CAE.Location = new Point(6, 26);
            textBoxResult_CAE.Multiline = true;
            textBoxResult_CAE.Name = "textBoxResult_CAE";
            textBoxResult_CAE.ReadOnly = true;
            textBoxResult_CAE.ScrollBars = ScrollBars.Horizontal;
            textBoxResult_CAE.Size = new Size(229, 371);
            textBoxResult_CAE.TabIndex = 0;
            textBoxResult_CAE.TextChanged += textBoxResult_CAE_TextChanged;
            // 
            // splitterOne_CAE
            // 
            splitterOne_CAE.Location = new Point(0, 0);
            splitterOne_CAE.Name = "splitterOne_CAE";
            splitterOne_CAE.Size = new Size(10, 403);
            splitterOne_CAE.TabIndex = 0;
            splitterOne_CAE.TabStop = false;
            splitterOne_CAE.SplitterMoved += splitterOne_CAE_SplitterMoved;
            // 
            // panelFill_CAE
            // 
            panelFill_CAE.Controls.Add(chartFunction_CAE);
            panelFill_CAE.Dock = DockStyle.Fill;
            panelFill_CAE.Location = new Point(250, 125);
            panelFill_CAE.Name = "panelFill_CAE";
            panelFill_CAE.Size = new Size(1002, 403);
            panelFill_CAE.TabIndex = 2;
            // 
            // chartFunction_CAE
            // 
            chartArea3.Name = "ChartArea1";
            chartFunction_CAE.ChartAreas.Add(chartArea3);
            chartFunction_CAE.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartFunction_CAE.Legends.Add(legend3);
            chartFunction_CAE.Location = new Point(0, 0);
            chartFunction_CAE.Name = "chartFunction_CAE";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunction_CAE.Series.Add(series3);
            chartFunction_CAE.Size = new Size(1002, 403);
            chartFunction_CAE.TabIndex = 0;
            chartFunction_CAE.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "График функции";
            chartFunction_CAE.Titles.Add(title3);
            chartFunction_CAE.Click += chartFunction_CAE_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 528);
            Controls.Add(panelFill_CAE);
            Controls.Add(panelLeft_CAE);
            Controls.Add(panelTop_CAE);
            MinimumSize = new Size(1270, 575);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6|Таск4|Вариант13|Челольян Анжела Евгеньевна";
            panelTop_CAE.ResumeLayout(false);
            groupBoxResult_CAE.ResumeLayout(false);
            groupBoxResult_CAE.PerformLayout();
            groupBoxTask_CAE.ResumeLayout(false);
            groupBoxTask_CAE.PerformLayout();
            panelLeft_CAE.ResumeLayout(false);
            groupBoxResultTwo_CAE.ResumeLayout(false);
            groupBoxResultTwo_CAE.PerformLayout();
            panelFill_CAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAE;
        private GroupBox groupBoxResult_CAE;
        private GroupBox groupBoxTask_CAE;
        private Panel panelLeft_CAE;
        private Splitter splitterOne_CAE;
        private Panel panelFill_CAE;
        private GroupBox groupBoxResultTwo_CAE;
        private TextBox textBoxStop_CAE;
        private TextBox textBoxStart_CAE;
        private TextBox textBoxTwo_CAE;
        private TextBox textBoxOne_CAE;
        private TextBox textBoxResult_CAE;
        private Button buttonHelp_CAE;
        private Button buttonSave_CAE;
        private Button buttonDone_CAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CAE;
        private TextBox textBoxTask_CAE;
    }
}
