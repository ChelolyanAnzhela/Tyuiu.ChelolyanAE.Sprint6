namespace Tyuiu.ChelolyanAE.Sprint6.Task1.V20
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
            textBoxTask_CAE = new TextBox();
            groupBoxOne_CAE = new GroupBox();
            textBoxStopOne_CAE = new TextBox();
            textBoxStartOne_CAE = new TextBox();
            textBoxStop_CAE = new TextBox();
            textBoxStart_CAE = new TextBox();
            groupBoxResult_CAE = new GroupBox();
            textBoxResult_CAE = new TextBox();
            textBoxText_CAE = new TextBox();
            groupBoxTask_CAE.SuspendLayout();
            groupBoxOne_CAE.SuspendLayout();
            groupBoxResult_CAE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_CAE
            // 
            buttonDone_CAE.BackColor = Color.Green;
            buttonDone_CAE.Location = new Point(507, 369);
            buttonDone_CAE.Name = "buttonDone_CAE";
            buttonDone_CAE.Size = new Size(138, 60);
            buttonDone_CAE.TabIndex = 0;
            buttonDone_CAE.Text = "Выполнить";
            buttonDone_CAE.UseVisualStyleBackColor = false;
            buttonDone_CAE.Click += buttonDone_CAE_Click;
            // 
            // buttonHelp_CAE
            // 
            buttonHelp_CAE.BackColor = SystemColors.MenuHighlight;
            buttonHelp_CAE.Location = new Point(411, 369);
            buttonHelp_CAE.Name = "buttonHelp_CAE";
            buttonHelp_CAE.Size = new Size(90, 60);
            buttonHelp_CAE.TabIndex = 1;
            buttonHelp_CAE.Text = "Справка";
            buttonHelp_CAE.UseVisualStyleBackColor = false;
            buttonHelp_CAE.Click += buttonHelp_CAE_Click;
            // 
            // groupBoxTask_CAE
            // 
            groupBoxTask_CAE.Controls.Add(textBoxTask_CAE);
            groupBoxTask_CAE.Location = new Point(23, 28);
            groupBoxTask_CAE.Name = "groupBoxTask_CAE";
            groupBoxTask_CAE.Size = new Size(602, 291);
            groupBoxTask_CAE.TabIndex = 2;
            groupBoxTask_CAE.TabStop = false;
            groupBoxTask_CAE.Text = "Условие";
            // 
            // textBoxTask_CAE
            // 
            textBoxTask_CAE.BackColor = SystemColors.MenuBar;
            textBoxTask_CAE.BorderStyle = BorderStyle.None;
            textBoxTask_CAE.Location = new Point(18, 26);
            textBoxTask_CAE.Multiline = true;
            textBoxTask_CAE.Name = "textBoxTask_CAE";
            textBoxTask_CAE.ReadOnly = true;
            textBoxTask_CAE.Size = new Size(432, 65);
            textBoxTask_CAE.TabIndex = 0;
            textBoxTask_CAE.Text = "Протабулировать функию (2х-3/cosx-2x)+5x-sinx на задданом диапазоне. Результат вывести в виде таблицы\r\n";
            // 
            // groupBoxOne_CAE
            // 
            groupBoxOne_CAE.Controls.Add(textBoxStopOne_CAE);
            groupBoxOne_CAE.Controls.Add(textBoxStartOne_CAE);
            groupBoxOne_CAE.Controls.Add(textBoxStop_CAE);
            groupBoxOne_CAE.Controls.Add(textBoxStart_CAE);
            groupBoxOne_CAE.Location = new Point(23, 338);
            groupBoxOne_CAE.Name = "groupBoxOne_CAE";
            groupBoxOne_CAE.Size = new Size(382, 109);
            groupBoxOne_CAE.TabIndex = 3;
            groupBoxOne_CAE.TabStop = false;
            groupBoxOne_CAE.Text = "Ввод данных";
            // 
            // textBoxStopOne_CAE
            // 
            textBoxStopOne_CAE.BackColor = SystemColors.MenuBar;
            textBoxStopOne_CAE.BorderStyle = BorderStyle.None;
            textBoxStopOne_CAE.Location = new Point(176, 31);
            textBoxStopOne_CAE.Name = "textBoxStopOne_CAE";
            textBoxStopOne_CAE.ReadOnly = true;
            textBoxStopOne_CAE.Size = new Size(125, 20);
            textBoxStopOne_CAE.TabIndex = 3;
            textBoxStopOne_CAE.Text = "Конец шага:";
            // 
            // textBoxStartOne_CAE
            // 
            textBoxStartOne_CAE.BackColor = SystemColors.MenuBar;
            textBoxStartOne_CAE.BorderStyle = BorderStyle.None;
            textBoxStartOne_CAE.Location = new Point(20, 31);
            textBoxStartOne_CAE.Name = "textBoxStartOne_CAE";
            textBoxStartOne_CAE.ReadOnly = true;
            textBoxStartOne_CAE.Size = new Size(125, 20);
            textBoxStartOne_CAE.TabIndex = 2;
            textBoxStartOne_CAE.Text = "Старт шага:";
            // 
            // textBoxStop_CAE
            // 
            textBoxStop_CAE.Location = new Point(176, 64);
            textBoxStop_CAE.Name = "textBoxStop_CAE";
            textBoxStop_CAE.Size = new Size(125, 27);
            textBoxStop_CAE.TabIndex = 1;
            textBoxStop_CAE.TextChanged += textBoxStop_CAE_TextChanged;
            // 
            // textBoxStart_CAE
            // 
            textBoxStart_CAE.Location = new Point(18, 64);
            textBoxStart_CAE.Name = "textBoxStart_CAE";
            textBoxStart_CAE.Size = new Size(127, 27);
            textBoxStart_CAE.TabIndex = 0;
            textBoxStart_CAE.TextChanged += textBoxStart_CAE_TextChanged;
            // 
            // groupBoxResult_CAE
            // 
            groupBoxResult_CAE.Controls.Add(textBoxResult_CAE);
            groupBoxResult_CAE.Controls.Add(textBoxText_CAE);
            groupBoxResult_CAE.Location = new Point(671, 28);
            groupBoxResult_CAE.Name = "groupBoxResult_CAE";
            groupBoxResult_CAE.Size = new Size(284, 392);
            groupBoxResult_CAE.TabIndex = 4;
            groupBoxResult_CAE.TabStop = false;
            groupBoxResult_CAE.Text = "Вывод данных";
            // 
            // textBoxResult_CAE
            // 
            textBoxResult_CAE.BackColor = SystemColors.MenuBar;
            textBoxResult_CAE.BorderStyle = BorderStyle.None;
            textBoxResult_CAE.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_CAE.Location = new Point(22, 49);
            textBoxResult_CAE.Multiline = true;
            textBoxResult_CAE.Name = "textBoxResult_CAE";
            textBoxResult_CAE.ReadOnly = true;
            textBoxResult_CAE.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CAE.Size = new Size(244, 337);
            textBoxResult_CAE.TabIndex = 1;
            textBoxResult_CAE.TextChanged += textBoxResult_CAE_TextChanged;
            // 
            // textBoxText_CAE
            // 
            textBoxText_CAE.BackColor = SystemColors.MenuBar;
            textBoxText_CAE.BorderStyle = BorderStyle.None;
            textBoxText_CAE.Location = new Point(6, 23);
            textBoxText_CAE.Name = "textBoxText_CAE";
            textBoxText_CAE.ReadOnly = true;
            textBoxText_CAE.Size = new Size(125, 20);
            textBoxText_CAE.TabIndex = 0;
            textBoxText_CAE.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 450);
            Controls.Add(groupBoxResult_CAE);
            Controls.Add(groupBoxOne_CAE);
            Controls.Add(groupBoxTask_CAE);
            Controls.Add(buttonHelp_CAE);
            Controls.Add(buttonDone_CAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Спринт6|Таск1|Вариант20|Челольян А.Е.";
            groupBoxTask_CAE.ResumeLayout(false);
            groupBoxTask_CAE.PerformLayout();
            groupBoxOne_CAE.ResumeLayout(false);
            groupBoxOne_CAE.PerformLayout();
            groupBoxResult_CAE.ResumeLayout(false);
            groupBoxResult_CAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_CAE;
        private Button buttonHelp_CAE;
        private GroupBox groupBoxTask_CAE;
        private TextBox textBoxTask_CAE;
        private GroupBox groupBoxOne_CAE;
        private TextBox textBoxStart_CAE;
        private TextBox textBoxStopOne_CAE;
        private TextBox textBoxStartOne_CAE;
        private TextBox textBoxStop_CAE;
        private GroupBox groupBoxResult_CAE;
        private TextBox textBoxText_CAE;
        private TextBox textBoxResult_CAE;
    }
}
