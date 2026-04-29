namespace JOrtizLab8
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
            btnTranslate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            rtxtBox = new RichTextBox();
            rtxtBoxTranslation = new RichTextBox();
            picBoxBook = new PictureBox();
            lblTitle = new Label();
            lblUserQuery = new Label();
            lblFinal = new Label();
            ttipMorse = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picBoxBook).BeginInit();
            SuspendLayout();
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(39, 389);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(75, 23);
            btnTranslate.TabIndex = 2;
            btnTranslate.Text = "&Translate";
            ttipMorse.SetToolTip(btnTranslate, "Translate your text to morse code");
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(151, 389);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "&Clear";
            ttipMorse.SetToolTip(btnClear, "Clears text in both boxes");
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(250, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            ttipMorse.SetToolTip(btnExit, "Exits app");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // rtxtBox
            // 
            rtxtBox.Location = new Point(12, 77);
            rtxtBox.Name = "rtxtBox";
            rtxtBox.Size = new Size(147, 286);
            rtxtBox.TabIndex = 0;
            rtxtBox.Text = "";
            // 
            // rtxtBoxTranslation
            // 
            rtxtBoxTranslation.Enabled = false;
            rtxtBoxTranslation.Location = new Point(214, 77);
            rtxtBoxTranslation.Name = "rtxtBoxTranslation";
            rtxtBoxTranslation.Size = new Size(147, 286);
            rtxtBoxTranslation.TabIndex = 1;
            rtxtBoxTranslation.Text = "";
            // 
            // picBoxBook
            // 
            picBoxBook.Image = (Image)resources.GetObject("picBoxBook.Image");
            picBoxBook.Location = new Point(367, 12);
            picBoxBook.Name = "picBoxBook";
            picBoxBook.Size = new Size(362, 415);
            picBoxBook.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBook.TabIndex = 6;
            picBoxBook.TabStop = false;
            ttipMorse.SetToolTip(picBoxBook, "M and O both have the same code. M=--");
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(100, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 15);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Morse Code Translator";
            // 
            // lblUserQuery
            // 
            lblUserQuery.AutoSize = true;
            lblUserQuery.Location = new Point(12, 44);
            lblUserQuery.Name = "lblUserQuery";
            lblUserQuery.Size = new Size(149, 30);
            lblUserQuery.TabIndex = 8;
            lblUserQuery.Text = "Please Enter your message \r\nyou want translated:";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(214, 59);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(138, 15);
            lblFinal.TabIndex = 9;
            lblFinal.Text = "Your translated message:";
            // 
            // Form1
            // 
            AcceptButton = btnTranslate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = btnExit;
            ClientSize = new Size(741, 439);
            Controls.Add(lblFinal);
            Controls.Add(lblUserQuery);
            Controls.Add(lblTitle);
            Controls.Add(picBoxBook);
            Controls.Add(rtxtBoxTranslation);
            Controls.Add(rtxtBox);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jorge Ortiz Lab 8 Morse Code Translator";
            ((System.ComponentModel.ISupportInitialize)picBoxBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTranslate;
        private Button btnClear;
        private Button btnExit;
        private RichTextBox rtxtBox;
        private RichTextBox rtxtBoxTranslation;
        private PictureBox picBoxBook;
        private Label lblTitle;
        private Label lblUserQuery;
        private Label lblFinal;
        private ToolTip ttipMorse;
    }
}
