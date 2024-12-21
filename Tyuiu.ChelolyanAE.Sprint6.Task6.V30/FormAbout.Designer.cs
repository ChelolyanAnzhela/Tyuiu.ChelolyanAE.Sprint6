namespace Tyuiu.ChelolyanAE.Sprint6.Task6.V30
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxTask_CAE = new PictureBox();
            textBoxAbout_CAE = new TextBox();
            buttonOk_CAE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_CAE).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTask_CAE
            // 
            pictureBoxTask_CAE.Image = (Image)resources.GetObject("pictureBoxTask_CAE.Image");
            pictureBoxTask_CAE.Location = new Point(12, 12);
            pictureBoxTask_CAE.Name = "pictureBoxTask_CAE";
            pictureBoxTask_CAE.Size = new Size(188, 280);
            pictureBoxTask_CAE.TabIndex = 0;
            pictureBoxTask_CAE.TabStop = false;
            // 
            // textBoxAbout_CAE
            // 
            textBoxAbout_CAE.BackColor = SystemColors.MenuBar;
            textBoxAbout_CAE.BorderStyle = BorderStyle.None;
            textBoxAbout_CAE.Location = new Point(206, 12);
            textBoxAbout_CAE.Multiline = true;
            textBoxAbout_CAE.Name = "textBoxAbout_CAE";
            textBoxAbout_CAE.ReadOnly = true;
            textBoxAbout_CAE.Size = new Size(377, 248);
            textBoxAbout_CAE.TabIndex = 1;
            textBoxAbout_CAE.Text = resources.GetString("textBoxAbout_CAE.Text");
            // 
            // buttonOk_CAE
            // 
            buttonOk_CAE.BackColor = SystemColors.ButtonHighlight;
            buttonOk_CAE.Location = new Point(489, 266);
            buttonOk_CAE.Name = "buttonOk_CAE";
            buttonOk_CAE.Size = new Size(94, 29);
            buttonOk_CAE.TabIndex = 2;
            buttonOk_CAE.Text = "Ok";
            buttonOk_CAE.UseVisualStyleBackColor = false;
            buttonOk_CAE.Click += buttonOk_CAE_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 304);
            Controls.Add(buttonOk_CAE);
            Controls.Add(textBoxAbout_CAE);
            Controls.Add(pictureBoxTask_CAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_CAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTask_CAE;
        private TextBox textBoxAbout_CAE;
        private Button buttonOk_CAE;
    }
}