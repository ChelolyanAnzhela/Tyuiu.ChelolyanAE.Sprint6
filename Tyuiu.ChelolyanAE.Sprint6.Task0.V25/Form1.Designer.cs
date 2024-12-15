namespace Tyuiu.ChelolyanAE.Sprint6.Task0.V25
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonNameOne_CAE = new Button();
            buttonNameTwo_CAE = new Button();
            groupBoxNameThree_CAE = new GroupBox();
            textBoxTask_CAE = new TextBox();
            pictureBoxFormule = new PictureBox();
            textBoxVarX_CAE = new TextBox();
            textBoxNameX_CAE = new TextBox();
            groupBoxInput = new GroupBox();
            groupBoxConclusion_CAE = new GroupBox();
            textBoxResultTwo_CAE = new TextBox();
            textBoxResult_CAE = new TextBox();
            groupBoxNameThree_CAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxConclusion_CAE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNameOne_CAE
            // 
            buttonNameOne_CAE.Location = new Point(671, 398);
            buttonNameOne_CAE.Name = "buttonNameOne_CAE";
            buttonNameOne_CAE.Size = new Size(117, 40);
            buttonNameOne_CAE.TabIndex = 0;
            buttonNameOne_CAE.Text = "Выполнить";
            buttonNameOne_CAE.UseVisualStyleBackColor = true;
            buttonNameOne_CAE.Click += buttonNameOne_CAE_Click;
            // 
            // buttonNameTwo_CAE
            // 
            buttonNameTwo_CAE.Location = new Point(583, 398);
            buttonNameTwo_CAE.Name = "buttonNameTwo_CAE";
            buttonNameTwo_CAE.Size = new Size(62, 40);
            buttonNameTwo_CAE.TabIndex = 1;
            buttonNameTwo_CAE.Text = "?";
            buttonNameTwo_CAE.UseVisualStyleBackColor = true;
            buttonNameTwo_CAE.Click += buttonNameTwo_CAE_Click;
            // 
            // groupBoxNameThree_CAE
            // 
            groupBoxNameThree_CAE.Controls.Add(textBoxTask_CAE);
            groupBoxNameThree_CAE.Location = new Point(29, 34);
            groupBoxNameThree_CAE.Name = "groupBoxNameThree_CAE";
            groupBoxNameThree_CAE.Size = new Size(548, 260);
            groupBoxNameThree_CAE.TabIndex = 2;
            groupBoxNameThree_CAE.TabStop = false;
            groupBoxNameThree_CAE.Text = "Условие";
            groupBoxNameThree_CAE.Enter += groupBoxNameThree_CAE_Enter;
            // 
            // textBoxTask_CAE
            // 
            textBoxTask_CAE.BackColor = SystemColors.Menu;
            textBoxTask_CAE.BorderStyle = BorderStyle.None;
            textBoxTask_CAE.Location = new Point(6, 27);
            textBoxTask_CAE.Multiline = true;
            textBoxTask_CAE.Name = "textBoxTask_CAE";
            textBoxTask_CAE.ReadOnly = true;
            textBoxTask_CAE.Size = new Size(519, 191);
            textBoxTask_CAE.TabIndex = 0;
            textBoxTask_CAE.Text = "Вычислить выражение по формуле\r\n";
            textBoxTask_CAE.TextChanged += textBoxTask_CAE_TextChanged;
            // 
            // pictureBoxFormule
            // 
            pictureBoxFormule.Image = (Image)resources.GetObject("pictureBoxFormule.Image");
            pictureBoxFormule.Location = new Point(583, 70);
            pictureBoxFormule.Name = "pictureBoxFormule";
            pictureBoxFormule.Size = new Size(173, 75);
            pictureBoxFormule.TabIndex = 0;
            pictureBoxFormule.TabStop = false;
            pictureBoxFormule.Click += pictureBoxFormule_Click;
            // 
            // textBoxVarX_CAE
            // 
            textBoxVarX_CAE.BorderStyle = BorderStyle.FixedSingle;
            textBoxVarX_CAE.Location = new Point(0, 66);
            textBoxVarX_CAE.Name = "textBoxVarX_CAE";
            textBoxVarX_CAE.Size = new Size(125, 27);
            textBoxVarX_CAE.TabIndex = 3;
            textBoxVarX_CAE.KeyPress += textBoxVarX_CAE_KeyPress;
            // 
            // textBoxNameX_CAE
            // 
            textBoxNameX_CAE.BackColor = SystemColors.Menu;
            textBoxNameX_CAE.BorderStyle = BorderStyle.None;
            textBoxNameX_CAE.Location = new Point(6, 40);
            textBoxNameX_CAE.Name = "textBoxNameX_CAE";
            textBoxNameX_CAE.Size = new Size(125, 20);
            textBoxNameX_CAE.TabIndex = 4;
            textBoxNameX_CAE.Text = "Переменная Х:";
            textBoxNameX_CAE.TextChanged += textBoxNameX_CAE_TextChanged;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxNameX_CAE);
            groupBoxInput.Controls.Add(textBoxVarX_CAE);
            groupBoxInput.Location = new Point(29, 313);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(250, 125);
            groupBoxInput.TabIndex = 5;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            groupBoxInput.Enter += groupBoxInput_Enter;
            // 
            // groupBoxConclusion_CAE
            // 
            groupBoxConclusion_CAE.Controls.Add(textBoxResultTwo_CAE);
            groupBoxConclusion_CAE.Controls.Add(textBoxResult_CAE);
            groupBoxConclusion_CAE.Location = new Point(538, 300);
            groupBoxConclusion_CAE.Name = "groupBoxConclusion_CAE";
            groupBoxConclusion_CAE.Size = new Size(250, 92);
            groupBoxConclusion_CAE.TabIndex = 5;
            groupBoxConclusion_CAE.TabStop = false;
            groupBoxConclusion_CAE.Text = "Вывод данных";
            groupBoxConclusion_CAE.Enter += groupBoxConclusion_CAE_Enter;
            // 
            // textBoxResultTwo_CAE
            // 
            textBoxResultTwo_CAE.Location = new Point(6, 53);
            textBoxResultTwo_CAE.Name = "textBoxResultTwo_CAE";
            textBoxResultTwo_CAE.ReadOnly = true;
            textBoxResultTwo_CAE.Size = new Size(125, 27);
            textBoxResultTwo_CAE.TabIndex = 7;
            textBoxResultTwo_CAE.TextChanged += textBoxResultTwo_CAE_TextChanged;
            // 
            // textBoxResult_CAE
            // 
            textBoxResult_CAE.BackColor = SystemColors.Menu;
            textBoxResult_CAE.BorderStyle = BorderStyle.None;
            textBoxResult_CAE.Location = new Point(6, 26);
            textBoxResult_CAE.Name = "textBoxResult_CAE";
            textBoxResult_CAE.Size = new Size(125, 20);
            textBoxResult_CAE.TabIndex = 6;
            textBoxResult_CAE.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxConclusion_CAE);
            Controls.Add(groupBoxInput);
            Controls.Add(pictureBoxFormule);
            Controls.Add(groupBoxNameThree_CAE);
            Controls.Add(buttonNameTwo_CAE);
            Controls.Add(buttonNameOne_CAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxNameThree_CAE.ResumeLayout(false);
            groupBoxNameThree_CAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxConclusion_CAE.ResumeLayout(false);
            groupBoxConclusion_CAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNameOne_CAE;
        private Button buttonNameTwo_CAE;
        private GroupBox groupBoxNameThree_CAE;
        private PictureBox pictureBoxFormule;
        private TextBox textBoxTask_CAE;
        private TextBox textBoxVarX_CAE;
        private TextBox textBoxNameX_CAE;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxConclusion_CAE;
        private TextBox textBoxResultTwo_CAE;
        private TextBox textBoxResult_CAE;
    }
}
