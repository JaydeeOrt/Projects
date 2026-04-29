namespace JOrtizLab3
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
            grpBoxTickets = new GroupBox();
            txtBoxClassC = new TextBox();
            lblClassC = new Label();
            txtBoxClassB = new TextBox();
            lblClassB = new Label();
            lblClassA = new Label();
            txtBoxClassA = new TextBox();
            lblQuestion = new Label();
            grpBoxRevenue = new GroupBox();
            txtBoxTotal = new TextBox();
            txtBoxClassCRev = new TextBox();
            txtBoxClassBRev = new TextBox();
            txtBoxClassARev = new TextBox();
            lblTotal = new Label();
            lblClassCRev = new Label();
            lblClassBRev = new Label();
            lblClassARev = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            tTipStadiumTickets = new ToolTip(components);
            grpBoxTickets.SuspendLayout();
            grpBoxRevenue.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxTickets
            // 
            grpBoxTickets.Controls.Add(txtBoxClassC);
            grpBoxTickets.Controls.Add(lblClassC);
            grpBoxTickets.Controls.Add(txtBoxClassB);
            grpBoxTickets.Controls.Add(lblClassB);
            grpBoxTickets.Controls.Add(lblClassA);
            grpBoxTickets.Controls.Add(txtBoxClassA);
            grpBoxTickets.Controls.Add(lblQuestion);
            grpBoxTickets.Location = new Point(23, 21);
            grpBoxTickets.Name = "grpBoxTickets";
            grpBoxTickets.Size = new Size(212, 190);
            grpBoxTickets.TabIndex = 0;
            grpBoxTickets.TabStop = false;
            grpBoxTickets.Text = "Tickets Sold";
            // 
            // txtBoxClassC
            // 
            txtBoxClassC.Location = new Point(94, 144);
            txtBoxClassC.Name = "txtBoxClassC";
            txtBoxClassC.Size = new Size(100, 23);
            txtBoxClassC.TabIndex = 2;
            tTipStadiumTickets.SetToolTip(txtBoxClassC, "Please Enter Whole number 0 or greater");
            // 
            // lblClassC
            // 
            lblClassC.AutoSize = true;
            lblClassC.Location = new Point(16, 147);
            lblClassC.Name = "lblClassC";
            lblClassC.Size = new Size(48, 15);
            lblClassC.TabIndex = 5;
            lblClassC.Text = "Class C:";
            // 
            // txtBoxClassB
            // 
            txtBoxClassB.Location = new Point(94, 102);
            txtBoxClassB.Name = "txtBoxClassB";
            txtBoxClassB.Size = new Size(100, 23);
            txtBoxClassB.TabIndex = 1;
            tTipStadiumTickets.SetToolTip(txtBoxClassB, "Please Enter Whole number 0 or greater");
            // 
            // lblClassB
            // 
            lblClassB.AutoSize = true;
            lblClassB.Location = new Point(17, 105);
            lblClassB.Name = "lblClassB";
            lblClassB.Size = new Size(47, 15);
            lblClassB.TabIndex = 3;
            lblClassB.Text = "Class B:";
            // 
            // lblClassA
            // 
            lblClassA.AutoSize = true;
            lblClassA.Location = new Point(16, 60);
            lblClassA.Name = "lblClassA";
            lblClassA.Size = new Size(48, 15);
            lblClassA.TabIndex = 2;
            lblClassA.Text = "Class A:";
            // 
            // txtBoxClassA
            // 
            txtBoxClassA.Location = new Point(94, 60);
            txtBoxClassA.Name = "txtBoxClassA";
            txtBoxClassA.Size = new Size(100, 23);
            txtBoxClassA.TabIndex = 0;
            tTipStadiumTickets.SetToolTip(txtBoxClassA, "Please Enter Whole number 0 or greater");
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(16, 19);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(184, 30);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Enter the number of tickets sold \r\nfor each class of seats";
            // 
            // grpBoxRevenue
            // 
            grpBoxRevenue.Controls.Add(txtBoxTotal);
            grpBoxRevenue.Controls.Add(txtBoxClassCRev);
            grpBoxRevenue.Controls.Add(txtBoxClassBRev);
            grpBoxRevenue.Controls.Add(txtBoxClassARev);
            grpBoxRevenue.Controls.Add(lblTotal);
            grpBoxRevenue.Controls.Add(lblClassCRev);
            grpBoxRevenue.Controls.Add(lblClassBRev);
            grpBoxRevenue.Controls.Add(lblClassARev);
            grpBoxRevenue.Location = new Point(241, 21);
            grpBoxRevenue.Name = "grpBoxRevenue";
            grpBoxRevenue.Size = new Size(215, 190);
            grpBoxRevenue.TabIndex = 1;
            grpBoxRevenue.TabStop = false;
            grpBoxRevenue.Text = "Revenue Generated";
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Enabled = false;
            txtBoxTotal.Location = new Point(107, 155);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.ReadOnly = true;
            txtBoxTotal.ShortcutsEnabled = false;
            txtBoxTotal.Size = new Size(100, 23);
            txtBoxTotal.TabIndex = 7;
            tTipStadiumTickets.SetToolTip(txtBoxTotal, "Total Money Generated");
            // 
            // txtBoxClassCRev
            // 
            txtBoxClassCRev.Enabled = false;
            txtBoxClassCRev.Location = new Point(107, 119);
            txtBoxClassCRev.Name = "txtBoxClassCRev";
            txtBoxClassCRev.ReadOnly = true;
            txtBoxClassCRev.ShortcutsEnabled = false;
            txtBoxClassCRev.Size = new Size(100, 23);
            txtBoxClassCRev.TabIndex = 6;
            tTipStadiumTickets.SetToolTip(txtBoxClassCRev, "Revenue Generated by Class C");
            // 
            // txtBoxClassBRev
            // 
            txtBoxClassBRev.Enabled = false;
            txtBoxClassBRev.Location = new Point(107, 81);
            txtBoxClassBRev.Name = "txtBoxClassBRev";
            txtBoxClassBRev.ReadOnly = true;
            txtBoxClassBRev.ShortcutsEnabled = false;
            txtBoxClassBRev.Size = new Size(100, 23);
            txtBoxClassBRev.TabIndex = 5;
            tTipStadiumTickets.SetToolTip(txtBoxClassBRev, "Revenue Generated by Class B");
            // 
            // txtBoxClassARev
            // 
            txtBoxClassARev.Enabled = false;
            txtBoxClassARev.Location = new Point(107, 44);
            txtBoxClassARev.Name = "txtBoxClassARev";
            txtBoxClassARev.ShortcutsEnabled = false;
            txtBoxClassARev.Size = new Size(100, 23);
            txtBoxClassARev.TabIndex = 4;
            tTipStadiumTickets.SetToolTip(txtBoxClassARev, "Revenue Generated by Class A");
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(30, 155);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // lblClassCRev
            // 
            lblClassCRev.AutoSize = true;
            lblClassCRev.Location = new Point(19, 119);
            lblClassCRev.Name = "lblClassCRev";
            lblClassCRev.Size = new Size(48, 15);
            lblClassCRev.TabIndex = 2;
            lblClassCRev.Text = "Class C:";
            // 
            // lblClassBRev
            // 
            lblClassBRev.AutoSize = true;
            lblClassBRev.Location = new Point(19, 81);
            lblClassBRev.Name = "lblClassBRev";
            lblClassBRev.Size = new Size(47, 15);
            lblClassBRev.TabIndex = 1;
            lblClassBRev.Text = "Class B:";
            // 
            // lblClassARev
            // 
            lblClassARev.AutoSize = true;
            lblClassARev.Location = new Point(18, 44);
            lblClassARev.Name = "lblClassARev";
            lblClassARev.Size = new Size(48, 15);
            lblClassARev.TabIndex = 0;
            lblClassARev.Text = "Class A:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(115, 234);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 40);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate &Revenue";
            tTipStadiumTickets.SetToolTip(btnCalculate, "Calculates Class Revenues");
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(196, 234);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            tTipStadiumTickets.SetToolTip(btnClear, "Clears the form");
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(277, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            tTipStadiumTickets.SetToolTip(btnExit, "Exits the program");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = btnClear;
            ClientSize = new Size(476, 309);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(grpBoxRevenue);
            Controls.Add(grpBoxTickets);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jorge Ortiz Lab 3 Stadium Seating";
            grpBoxTickets.ResumeLayout(false);
            grpBoxTickets.PerformLayout();
            grpBoxRevenue.ResumeLayout(false);
            grpBoxRevenue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxTickets;
        private GroupBox grpBoxRevenue;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblQuestion;
        private ToolTip tTipStadiumTickets;
        private TextBox txtBoxClassA;
        private TextBox txtBoxClassB;
        private Label lblClassB;
        private Label lblClassA;
        private TextBox txtBoxClassC;
        private Label lblClassC;
        private TextBox txtBoxTotal;
        private TextBox txtBoxClassCRev;
        private TextBox txtBoxClassBRev;
        private TextBox txtBoxClassARev;
        private Label lblTotal;
        private Label lblClassCRev;
        private Label lblClassBRev;
        private Label lblClassARev;
    }
}
