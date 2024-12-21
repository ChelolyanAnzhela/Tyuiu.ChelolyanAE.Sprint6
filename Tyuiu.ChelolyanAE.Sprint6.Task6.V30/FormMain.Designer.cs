namespace Tyuiu.ChelolyanAE.Sprint6.Task6.V30
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_CAE = new Panel();
            buttonHelp_CAE = new Button();
            buttonOpen_CAE = new Button();
            buttonDone_CAE = new Button();
            groupBoxTask_CAE = new GroupBox();
            textBoxTask_CAE = new TextBox();
            panelLeft_CAE = new Panel();
            groupBoxOne_CAE = new GroupBox();
            textBoxStart_CAE = new TextBox();
            panelRight_CAE = new Panel();
            groupBoxTwo_CAE = new GroupBox();
            textBoxResult_CAE = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask_CAE = new OpenFileDialog();
            toolTipTask_CAE = new ToolTip(components);
            panelTop_CAE.SuspendLayout();
            groupBoxTask_CAE.SuspendLayout();
            panelLeft_CAE.SuspendLayout();
            groupBoxOne_CAE.SuspendLayout();
            panelRight_CAE.SuspendLayout();
            groupBoxTwo_CAE.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_CAE
            // 
            panelTop_CAE.Controls.Add(buttonHelp_CAE);
            panelTop_CAE.Controls.Add(buttonOpen_CAE);
            panelTop_CAE.Controls.Add(buttonDone_CAE);
            panelTop_CAE.Controls.Add(groupBoxTask_CAE);
            panelTop_CAE.Dock = DockStyle.Top;
            panelTop_CAE.Location = new Point(0, 0);
            panelTop_CAE.Name = "panelTop_CAE";
            panelTop_CAE.Size = new Size(1227, 144);
            panelTop_CAE.TabIndex = 0;
            // 
            // buttonHelp_CAE
            // 
            buttonHelp_CAE.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_CAE.Location = new Point(1117, 12);
            buttonHelp_CAE.Name = "buttonHelp_CAE";
            buttonHelp_CAE.Size = new Size(89, 48);
            buttonHelp_CAE.TabIndex = 3;
            buttonHelp_CAE.Text = "?";
            buttonHelp_CAE.UseVisualStyleBackColor = false;
            buttonHelp_CAE.Click += buttonHelp_CAE_Click;
            // 
            // buttonOpen_CAE
            // 
            buttonOpen_CAE.BackColor = SystemColors.ActiveCaption;
            buttonOpen_CAE.Location = new Point(168, 12);
            buttonOpen_CAE.Name = "buttonOpen_CAE";
            buttonOpen_CAE.Size = new Size(98, 48);
            buttonOpen_CAE.TabIndex = 2;
            buttonOpen_CAE.Text = "Открыть файл";
            toolTipTask_CAE.SetToolTip(buttonOpen_CAE, "Открыть файл");
            buttonOpen_CAE.UseVisualStyleBackColor = false;
            buttonOpen_CAE.Click += buttonOpen_CAE_Click;
            // 
            // buttonDone_CAE
            // 
            buttonDone_CAE.Image = (Image)resources.GetObject("buttonDone_CAE.Image");
            buttonDone_CAE.Location = new Point(37, 12);
            buttonDone_CAE.Name = "buttonDone_CAE";
            buttonDone_CAE.Size = new Size(105, 48);
            buttonDone_CAE.TabIndex = 1;
            buttonDone_CAE.Text = "Выполнить";
            toolTipTask_CAE.SetToolTip(buttonDone_CAE, "Производит поиск четвертого слова в каждой строке\r\n");
            buttonDone_CAE.UseVisualStyleBackColor = true;
            buttonDone_CAE.Click += buttonDone_CAE_Click;
            // 
            // groupBoxTask_CAE
            // 
            groupBoxTask_CAE.Controls.Add(textBoxTask_CAE);
            groupBoxTask_CAE.Location = new Point(6, 55);
            groupBoxTask_CAE.Name = "groupBoxTask_CAE";
            groupBoxTask_CAE.Size = new Size(1221, 83);
            groupBoxTask_CAE.TabIndex = 0;
            groupBoxTask_CAE.TabStop = false;
            groupBoxTask_CAE.Text = "Условие";
            // 
            // textBoxTask_CAE
            // 
            textBoxTask_CAE.BackColor = SystemColors.MenuBar;
            textBoxTask_CAE.BorderStyle = BorderStyle.None;
            textBoxTask_CAE.Location = new Point(17, 26);
            textBoxTask_CAE.Multiline = true;
            textBoxTask_CAE.Name = "textBoxTask_CAE";
            textBoxTask_CAE.Size = new Size(1183, 51);
            textBoxTask_CAE.TabIndex = 0;
            textBoxTask_CAE.Text = resources.GetString("textBoxTask_CAE.Text");
            // 
            // panelLeft_CAE
            // 
            panelLeft_CAE.Controls.Add(groupBoxOne_CAE);
            panelLeft_CAE.Dock = DockStyle.Left;
            panelLeft_CAE.Location = new Point(0, 144);
            panelLeft_CAE.Name = "panelLeft_CAE";
            panelLeft_CAE.Size = new Size(638, 382);
            panelLeft_CAE.TabIndex = 1;
            // 
            // groupBoxOne_CAE
            // 
            groupBoxOne_CAE.Controls.Add(textBoxStart_CAE);
            groupBoxOne_CAE.Dock = DockStyle.Left;
            groupBoxOne_CAE.Location = new Point(0, 0);
            groupBoxOne_CAE.Name = "groupBoxOne_CAE";
            groupBoxOne_CAE.Size = new Size(638, 382);
            groupBoxOne_CAE.TabIndex = 0;
            groupBoxOne_CAE.TabStop = false;
            groupBoxOne_CAE.Text = "Ввод";
            // 
            // textBoxStart_CAE
            // 
            textBoxStart_CAE.Dock = DockStyle.Left;
            textBoxStart_CAE.Location = new Point(3, 23);
            textBoxStart_CAE.Multiline = true;
            textBoxStart_CAE.Name = "textBoxStart_CAE";
            textBoxStart_CAE.Size = new Size(630, 356);
            textBoxStart_CAE.TabIndex = 0;
            // 
            // panelRight_CAE
            // 
            panelRight_CAE.Controls.Add(groupBoxTwo_CAE);
            panelRight_CAE.Controls.Add(splitter1);
            panelRight_CAE.Dock = DockStyle.Right;
            panelRight_CAE.Location = new Point(636, 144);
            panelRight_CAE.Name = "panelRight_CAE";
            panelRight_CAE.Size = new Size(591, 382);
            panelRight_CAE.TabIndex = 2;
            // 
            // groupBoxTwo_CAE
            // 
            groupBoxTwo_CAE.Controls.Add(textBoxResult_CAE);
            groupBoxTwo_CAE.Dock = DockStyle.Right;
            groupBoxTwo_CAE.Location = new Point(3, 0);
            groupBoxTwo_CAE.Name = "groupBoxTwo_CAE";
            groupBoxTwo_CAE.Size = new Size(588, 382);
            groupBoxTwo_CAE.TabIndex = 1;
            groupBoxTwo_CAE.TabStop = false;
            groupBoxTwo_CAE.Text = "Вывод";
            // 
            // textBoxResult_CAE
            // 
            textBoxResult_CAE.Dock = DockStyle.Right;
            textBoxResult_CAE.Location = new Point(-3, 23);
            textBoxResult_CAE.Multiline = true;
            textBoxResult_CAE.Name = "textBoxResult_CAE";
            textBoxResult_CAE.Size = new Size(588, 356);
            textBoxResult_CAE.TabIndex = 0;
            textBoxResult_CAE.TextChanged += textBoxResult_CAE_TextChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 382);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_CAE
            // 
            openFileDialogTask_CAE.FileName = "openFileDialog1";
            // 
            // toolTipTask_CAE
            // 
            toolTipTask_CAE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 526);
            Controls.Add(panelRight_CAE);
            Controls.Add(panelLeft_CAE);
            Controls.Add(panelTop_CAE);
            Name = "FormMain";
            Text = "Спринт6|Таск5|Вариант18|Челольян Анжела Евгеньевна";
            panelTop_CAE.ResumeLayout(false);
            groupBoxTask_CAE.ResumeLayout(false);
            groupBoxTask_CAE.PerformLayout();
            panelLeft_CAE.ResumeLayout(false);
            groupBoxOne_CAE.ResumeLayout(false);
            groupBoxOne_CAE.PerformLayout();
            panelRight_CAE.ResumeLayout(false);
            groupBoxTwo_CAE.ResumeLayout(false);
            groupBoxTwo_CAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAE;
        private GroupBox groupBoxTask_CAE;
        private Panel panelLeft_CAE;
        private GroupBox groupBoxOne_CAE;
        private Panel panelRight_CAE;
        private GroupBox groupBoxTwo_CAE;
        private Splitter splitter1;
        private Button buttonDone_CAE;
        private TextBox textBoxTask_CAE;
        private Button buttonOpen_CAE;
        private ToolTip toolTipTask_CAE;
        private OpenFileDialog openFileDialogTask_CAE;
        private Button buttonHelp_CAE;
        private TextBox textBoxStart_CAE;
        private TextBox textBoxResult_CAE;
    }
}
