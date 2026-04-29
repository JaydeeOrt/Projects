namespace JOrtizLab4
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
            lblUserInput = new Label();
            txtBoxDist = new TextBox();
            grpBoxFrom = new GroupBox();
            lstBoxFrom = new ListBox();
            grpBoxTo = new GroupBox();
            lstBoxTo = new ListBox();
            lblConverted = new Label();
            txtBoxFinalDist = new TextBox();
            btnConvert = new Button();
            btnExit = new Button();
            tTipDistConvert = new ToolTip(components);
            pictureBox1 = new PictureBox();
            grpBoxFrom.SuspendLayout();
            grpBoxTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserInput
            // 
            lblUserInput.AutoSize = true;
            lblUserInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserInput.Location = new Point(53, 44);
            lblUserInput.Name = "lblUserInput";
            lblUserInput.Size = new Size(177, 17);
            lblUserInput.TabIndex = 0;
            lblUserInput.Text = "Enter a distance to convert:";
            // 
            // txtBoxDist
            // 
            txtBoxDist.Location = new Point(241, 44);
            txtBoxDist.Name = "txtBoxDist";
            txtBoxDist.Size = new Size(100, 23);
            txtBoxDist.TabIndex = 0;
            tTipDistConvert.SetToolTip(txtBoxDist, "Enter Positive number to Convert");
            // 
            // grpBoxFrom
            // 
            grpBoxFrom.Controls.Add(lstBoxFrom);
            grpBoxFrom.Location = new Point(12, 112);
            grpBoxFrom.Name = "grpBoxFrom";
            grpBoxFrom.Size = new Size(145, 150);
            grpBoxFrom.TabIndex = 1;
            grpBoxFrom.TabStop = false;
            grpBoxFrom.Text = "From";
            // 
            // lstBoxFrom
            // 
            lstBoxFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxFrom.FormattingEnabled = true;
            lstBoxFrom.ItemHeight = 21;
            lstBoxFrom.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            lstBoxFrom.Location = new Point(6, 23);
            lstBoxFrom.Name = "lstBoxFrom";
            lstBoxFrom.Size = new Size(133, 109);
            lstBoxFrom.TabIndex = 0;
            tTipDistConvert.SetToolTip(lstBoxFrom, "Select what you are converting from");
            // 
            // grpBoxTo
            // 
            grpBoxTo.Controls.Add(lstBoxTo);
            grpBoxTo.Location = new Point(289, 112);
            grpBoxTo.Name = "grpBoxTo";
            grpBoxTo.Size = new Size(145, 150);
            grpBoxTo.TabIndex = 2;
            grpBoxTo.TabStop = false;
            grpBoxTo.Text = "To";
            // 
            // lstBoxTo
            // 
            lstBoxTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxTo.FormattingEnabled = true;
            lstBoxTo.ItemHeight = 21;
            lstBoxTo.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            lstBoxTo.Location = new Point(6, 23);
            lstBoxTo.Name = "lstBoxTo";
            lstBoxTo.Size = new Size(133, 109);
            lstBoxTo.TabIndex = 0;
            tTipDistConvert.SetToolTip(lstBoxTo, "Select what you are converting to");
            // 
            // lblConverted
            // 
            lblConverted.AutoSize = true;
            lblConverted.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConverted.Location = new Point(117, 297);
            lblConverted.Name = "lblConverted";
            lblConverted.Size = new Size(96, 17);
            lblConverted.TabIndex = 4;
            lblConverted.Text = "New Distance:";
            // 
            // txtBoxFinalDist
            // 
            txtBoxFinalDist.Enabled = false;
            txtBoxFinalDist.Location = new Point(219, 296);
            txtBoxFinalDist.Name = "txtBoxFinalDist";
            txtBoxFinalDist.Size = new Size(100, 23);
            txtBoxFinalDist.TabIndex = 5;
            tTipDistConvert.SetToolTip(txtBoxFinalDist, "Displays conversion");
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(95, 337);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "&Convert";
            tTipDistConvert.SetToolTip(btnConvert, "Converts Distance");
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(266, 337);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            tTipDistConvert.SetToolTip(btnExit, "Exits Form");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = btnExit;
            ClientSize = new Size(446, 397);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnConvert);
            Controls.Add(txtBoxFinalDist);
            Controls.Add(lblConverted);
            Controls.Add(grpBoxTo);
            Controls.Add(grpBoxFrom);
            Controls.Add(txtBoxDist);
            Controls.Add(lblUserInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jorge Ortiz Lab 4 Distance Convert";
            grpBoxFrom.ResumeLayout(false);
            grpBoxTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserInput;
        private TextBox txtBoxDist;
        private GroupBox grpBoxFrom;
        private ListBox lstBoxFrom;
        private GroupBox grpBoxTo;
        private ListBox lstBoxTo;
        private Label lblConverted;
        private TextBox txtBoxFinalDist;
        private Button btnConvert;
        private Button btnExit;
        private ToolTip tTipDistConvert;
        private PictureBox pictureBox1;
    }
}
