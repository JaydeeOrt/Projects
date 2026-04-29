namespace JOrtizLab1
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
            lblTitle = new Label();
            gradeCalcToolTip = new ToolTip(components);
            txtBoxExam1 = new TextBox();
            txtBoxExam2 = new TextBox();
            txtBoxExam3 = new TextBox();
            txtBoxExam4 = new TextBox();
            txtBoxLab1 = new TextBox();
            txtBoxLab2 = new TextBox();
            txtBoxLab3 = new TextBox();
            txtBoxLab4 = new TextBox();
            txtBoxQuiz4 = new TextBox();
            txtBoxQuiz3 = new TextBox();
            txtBoxQuiz2 = new TextBox();
            txtBoxQuiz1 = new TextBox();
            txtBoxQuiz5 = new TextBox();
            txtBoxLab5 = new TextBox();
            btnCalcGrade = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblExams = new Label();
            lblLabs = new Label();
            lblQuizzes = new Label();
            lblFinal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(29, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(382, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Average Final Grade Calculator";
            // 
            // txtBoxExam1
            // 
            txtBoxExam1.Location = new Point(139, 93);
            txtBoxExam1.Name = "txtBoxExam1";
            txtBoxExam1.Size = new Size(30, 23);
            txtBoxExam1.TabIndex = 0;
            gradeCalcToolTip.SetToolTip(txtBoxExam1, "Please enter exam grades 0-100");
            // 
            // txtBoxExam2
            // 
            txtBoxExam2.Location = new Point(175, 93);
            txtBoxExam2.Name = "txtBoxExam2";
            txtBoxExam2.Size = new Size(30, 23);
            txtBoxExam2.TabIndex = 1;
            gradeCalcToolTip.SetToolTip(txtBoxExam2, "Please enter exam grades 0-100");
            // 
            // txtBoxExam3
            // 
            txtBoxExam3.Location = new Point(211, 93);
            txtBoxExam3.Name = "txtBoxExam3";
            txtBoxExam3.Size = new Size(30, 23);
            txtBoxExam3.TabIndex = 2;
            gradeCalcToolTip.SetToolTip(txtBoxExam3, "Please enter exam grades 0-100");
            // 
            // txtBoxExam4
            // 
            txtBoxExam4.Location = new Point(247, 93);
            txtBoxExam4.Name = "txtBoxExam4";
            txtBoxExam4.Size = new Size(30, 23);
            txtBoxExam4.TabIndex = 3;
            gradeCalcToolTip.SetToolTip(txtBoxExam4, "Please enter exam grades 0-100");
            // 
            // txtBoxLab1
            // 
            txtBoxLab1.Location = new Point(139, 122);
            txtBoxLab1.Name = "txtBoxLab1";
            txtBoxLab1.Size = new Size(30, 23);
            txtBoxLab1.TabIndex = 4;
            gradeCalcToolTip.SetToolTip(txtBoxLab1, "Please enter Lab grades 0-100");
            // 
            // txtBoxLab2
            // 
            txtBoxLab2.Location = new Point(175, 122);
            txtBoxLab2.Name = "txtBoxLab2";
            txtBoxLab2.Size = new Size(30, 23);
            txtBoxLab2.TabIndex = 5;
            gradeCalcToolTip.SetToolTip(txtBoxLab2, "Please enter Lab grades 0-100");
            // 
            // txtBoxLab3
            // 
            txtBoxLab3.Location = new Point(211, 122);
            txtBoxLab3.Name = "txtBoxLab3";
            txtBoxLab3.Size = new Size(30, 23);
            txtBoxLab3.TabIndex = 6;
            gradeCalcToolTip.SetToolTip(txtBoxLab3, "Please enter Lab grades 0-100");
            // 
            // txtBoxLab4
            // 
            txtBoxLab4.Location = new Point(247, 122);
            txtBoxLab4.Name = "txtBoxLab4";
            txtBoxLab4.Size = new Size(30, 23);
            txtBoxLab4.TabIndex = 7;
            gradeCalcToolTip.SetToolTip(txtBoxLab4, "Please enter Lab grades 0-100");
            // 
            // txtBoxQuiz4
            // 
            txtBoxQuiz4.Location = new Point(247, 152);
            txtBoxQuiz4.Name = "txtBoxQuiz4";
            txtBoxQuiz4.Size = new Size(30, 23);
            txtBoxQuiz4.TabIndex = 12;
            gradeCalcToolTip.SetToolTip(txtBoxQuiz4, "Please enter quizz grades 0-100");
            // 
            // txtBoxQuiz3
            // 
            txtBoxQuiz3.Location = new Point(211, 152);
            txtBoxQuiz3.Name = "txtBoxQuiz3";
            txtBoxQuiz3.Size = new Size(30, 23);
            txtBoxQuiz3.TabIndex = 11;
            gradeCalcToolTip.SetToolTip(txtBoxQuiz3, "Please enter quizz grades 0-100");
            // 
            // txtBoxQuiz2
            // 
            txtBoxQuiz2.Location = new Point(175, 152);
            txtBoxQuiz2.Name = "txtBoxQuiz2";
            txtBoxQuiz2.Size = new Size(30, 23);
            txtBoxQuiz2.TabIndex = 10;
            gradeCalcToolTip.SetToolTip(txtBoxQuiz2, "Please enter quizz grades 0-100");
            // 
            // txtBoxQuiz1
            // 
            txtBoxQuiz1.Location = new Point(139, 152);
            txtBoxQuiz1.Name = "txtBoxQuiz1";
            txtBoxQuiz1.Size = new Size(30, 23);
            txtBoxQuiz1.TabIndex = 9;
            gradeCalcToolTip.SetToolTip(txtBoxQuiz1, "Please enter quizz grades 0-100");
            // 
            // txtBoxQuiz5
            // 
            txtBoxQuiz5.Location = new Point(283, 152);
            txtBoxQuiz5.Name = "txtBoxQuiz5";
            txtBoxQuiz5.Size = new Size(30, 23);
            txtBoxQuiz5.TabIndex = 13;
            gradeCalcToolTip.SetToolTip(txtBoxQuiz5, "Please enter quizz grades 0-100");
            // 
            // txtBoxLab5
            // 
            txtBoxLab5.Location = new Point(283, 122);
            txtBoxLab5.Name = "txtBoxLab5";
            txtBoxLab5.Size = new Size(30, 23);
            txtBoxLab5.TabIndex = 8;
            gradeCalcToolTip.SetToolTip(txtBoxLab5, "Please enter Lab grades 0-100");
            // 
            // btnCalcGrade
            // 
            btnCalcGrade.Location = new Point(82, 210);
            btnCalcGrade.Name = "btnCalcGrade";
            btnCalcGrade.Size = new Size(103, 23);
            btnCalcGrade.TabIndex = 14;
            btnCalcGrade.Text = "Calculate &Grade";
            gradeCalcToolTip.SetToolTip(btnCalcGrade, "Calculates grade average");
            btnCalcGrade.UseVisualStyleBackColor = true;
            btnCalcGrade.Click += btnCalcGrade_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(191, 210);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "&Clear";
            gradeCalcToolTip.SetToolTip(btnClear, "Clears text boxes");
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(272, 210);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 16;
            btnExit.Text = "E&xit";
            gradeCalcToolTip.SetToolTip(btnExit, "Exits form");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblExams
            // 
            lblExams.AutoSize = true;
            lblExams.Location = new Point(73, 93);
            lblExams.Name = "lblExams";
            lblExams.Size = new Size(43, 15);
            lblExams.TabIndex = 1;
            lblExams.Text = "Exams:";
            // 
            // lblLabs
            // 
            lblLabs.AutoSize = true;
            lblLabs.Location = new Point(82, 122);
            lblLabs.Name = "lblLabs";
            lblLabs.Size = new Size(34, 15);
            lblLabs.TabIndex = 2;
            lblLabs.Text = "Labs:";
            // 
            // lblQuizzes
            // 
            lblQuizzes.AutoSize = true;
            lblQuizzes.Location = new Point(66, 155);
            lblQuizzes.Name = "lblQuizzes";
            lblQuizzes.Size = new Size(50, 15);
            lblQuizzes.TabIndex = 3;
            lblQuizzes.Text = "Quizzes:";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(74, 181);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(0, 15);
            lblFinal.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 122);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btnCalcGrade;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = btnExit;
            ClientSize = new Size(420, 373);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcGrade);
            Controls.Add(txtBoxQuiz5);
            Controls.Add(txtBoxLab5);
            Controls.Add(txtBoxQuiz4);
            Controls.Add(txtBoxQuiz3);
            Controls.Add(txtBoxQuiz2);
            Controls.Add(txtBoxQuiz1);
            Controls.Add(txtBoxLab4);
            Controls.Add(txtBoxLab3);
            Controls.Add(txtBoxLab2);
            Controls.Add(txtBoxLab1);
            Controls.Add(txtBoxExam4);
            Controls.Add(txtBoxExam3);
            Controls.Add(txtBoxExam2);
            Controls.Add(txtBoxExam1);
            Controls.Add(lblFinal);
            Controls.Add(lblQuizzes);
            Controls.Add(lblLabs);
            Controls.Add(lblExams);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ToolTip gradeCalcToolTip;
        private Label lblExams;
        private Label lblLabs;
        private Label lblQuizzes;
        private Label lblFinal;
        private TextBox txtBoxExam1;
        private TextBox txtBoxExam2;
        private TextBox txtBoxExam3;
        private TextBox txtBoxExam4;
        private TextBox txtBoxLab1;
        private TextBox txtBoxLab2;
        private TextBox txtBoxLab3;
        private TextBox txtBoxLab4;
        private TextBox txtBoxQuiz4;
        private TextBox txtBoxQuiz3;
        private TextBox txtBoxQuiz2;
        private TextBox txtBoxQuiz1;
        private TextBox txtBoxQuiz5;
        private TextBox txtBoxLab5;
        private Button btnCalcGrade;
        private Button btnClear;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}
