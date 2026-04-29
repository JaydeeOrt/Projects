namespace JOrtizLab7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnExit = new Button();
            btnOpenFile = new Button();
            lstBoxUserAnswers = new ListBox();
            btnClear = new Button();
            lblCorrectCount = new Label();
            lblPassFail = new Label();
            picBoxHappy = new PictureBox();
            picBoxSad = new PictureBox();
            toolTipExam = new ToolTip(components);
            lblWrong = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxHappy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSad).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(156, 170);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            toolTipExam.SetToolTip(btnExit, "Exits program");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(156, 112);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(75, 23);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "&Open File";
            toolTipExam.SetToolTip(btnOpenFile, "Opens file; Tells you which answers you got incorrect");
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lstBoxUserAnswers
            // 
            lstBoxUserAnswers.FormattingEnabled = true;
            lstBoxUserAnswers.ItemHeight = 15;
            lstBoxUserAnswers.Location = new Point(12, 12);
            lstBoxUserAnswers.Name = "lstBoxUserAnswers";
            lstBoxUserAnswers.Size = new Size(120, 214);
            lstBoxUserAnswers.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(156, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            toolTipExam.SetToolTip(btnClear, "Clears Form");
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblCorrectCount
            // 
            lblCorrectCount.AutoSize = true;
            lblCorrectCount.Location = new Point(138, 12);
            lblCorrectCount.Name = "lblCorrectCount";
            lblCorrectCount.Size = new Size(113, 15);
            lblCorrectCount.TabIndex = 4;
            lblCorrectCount.Text = "You got ?/20 correct";
            lblCorrectCount.Visible = false;
            // 
            // lblPassFail
            // 
            lblPassFail.AutoSize = true;
            lblPassFail.Location = new Point(138, 42);
            lblPassFail.Name = "lblPassFail";
            lblPassFail.Size = new Size(83, 15);
            lblPassFail.TabIndex = 5;
            lblPassFail.Text = "You Pass! Expl.";
            lblPassFail.Visible = false;
            // 
            // picBoxHappy
            // 
            picBoxHappy.Image = (Image)resources.GetObject("picBoxHappy.Image");
            picBoxHappy.Location = new Point(264, 12);
            picBoxHappy.Name = "picBoxHappy";
            picBoxHappy.Size = new Size(157, 218);
            picBoxHappy.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHappy.TabIndex = 6;
            picBoxHappy.TabStop = false;
            toolTipExam.SetToolTip(picBoxHappy, "Good luck");
            picBoxHappy.Visible = false;
            // 
            // picBoxSad
            // 
            picBoxSad.Image = (Image)resources.GetObject("picBoxSad.Image");
            picBoxSad.Location = new Point(264, 12);
            picBoxSad.Name = "picBoxSad";
            picBoxSad.Size = new Size(157, 218);
            picBoxSad.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxSad.TabIndex = 7;
            picBoxSad.TabStop = false;
            toolTipExam.SetToolTip(picBoxSad, "Better luck next time");
            picBoxSad.Visible = false;
            // 
            // lblWrong
            // 
            lblWrong.AutoSize = true;
            lblWrong.Location = new Point(138, 27);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new Size(93, 15);
            lblWrong.TabIndex = 8;
            lblWrong.Text = "You got ? wrong";
            lblWrong.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOpenFile;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(433, 242);
            Controls.Add(lblWrong);
            Controls.Add(picBoxSad);
            Controls.Add(picBoxHappy);
            Controls.Add(lblPassFail);
            Controls.Add(lblCorrectCount);
            Controls.Add(btnClear);
            Controls.Add(lstBoxUserAnswers);
            Controls.Add(btnOpenFile);
            Controls.Add(btnExit);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jorge Ortiz Lab 7 Drivers License Exam";
            ((System.ComponentModel.ISupportInitialize)picBoxHappy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnOpenFile;
        private ListBox lstBoxUserAnswers;
        private Button btnClear;
        private Label lblCorrectCount;
        private Label lblPassFail;
        private PictureBox picBoxHappy;
        private PictureBox picBoxSad;
        private ToolTip toolTipExam;
        private Label lblWrong;
    }
}
