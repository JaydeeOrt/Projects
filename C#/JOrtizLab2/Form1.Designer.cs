namespace JOrtizLab2
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
            pBoxQueen = new PictureBox();
            pBoxKing = new PictureBox();
            pBoxJack = new PictureBox();
            pBoxAce = new PictureBox();
            pBoxClub = new PictureBox();
            tTipCards = new ToolTip(components);
            btnExit = new Button();
            lblUserQuestion = new Label();
            lblNameofCard = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxQueen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxKing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxJack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxAce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxClub).BeginInit();
            SuspendLayout();
            // 
            // pBoxQueen
            // 
            pBoxQueen.Image = (Image)resources.GetObject("pBoxQueen.Image");
            pBoxQueen.Location = new Point(330, 83);
            pBoxQueen.Name = "pBoxQueen";
            pBoxQueen.Size = new Size(135, 187);
            pBoxQueen.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxQueen.TabIndex = 0;
            pBoxQueen.TabStop = false;
            tTipCards.SetToolTip(pBoxQueen, "Tells you name of card");
            pBoxQueen.Click += pBoxQueen_Click;
            // 
            // pBoxKing
            // 
            pBoxKing.Image = (Image)resources.GetObject("pBoxKing.Image");
            pBoxKing.Location = new Point(189, 83);
            pBoxKing.Name = "pBoxKing";
            pBoxKing.Size = new Size(135, 187);
            pBoxKing.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxKing.TabIndex = 1;
            pBoxKing.TabStop = false;
            tTipCards.SetToolTip(pBoxKing, "Tells you name of card");
            pBoxKing.Click += pBoxKing_Click;
            // 
            // pBoxJack
            // 
            pBoxJack.Image = (Image)resources.GetObject("pBoxJack.Image");
            pBoxJack.Location = new Point(471, 83);
            pBoxJack.Name = "pBoxJack";
            pBoxJack.Size = new Size(135, 187);
            pBoxJack.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxJack.TabIndex = 2;
            pBoxJack.TabStop = false;
            tTipCards.SetToolTip(pBoxJack, "Tells you name of card");
            pBoxJack.Click += pBoxJack_Click;
            // 
            // pBoxAce
            // 
            pBoxAce.Image = (Image)resources.GetObject("pBoxAce.Image");
            pBoxAce.Location = new Point(48, 83);
            pBoxAce.Name = "pBoxAce";
            pBoxAce.Size = new Size(135, 187);
            pBoxAce.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxAce.TabIndex = 3;
            pBoxAce.TabStop = false;
            tTipCards.SetToolTip(pBoxAce, "Tells you name of card");
            pBoxAce.Click += pBoxAce_Click;
            // 
            // pBoxClub
            // 
            pBoxClub.Image = (Image)resources.GetObject("pBoxClub.Image");
            pBoxClub.Location = new Point(612, 83);
            pBoxClub.Name = "pBoxClub";
            pBoxClub.Size = new Size(135, 187);
            pBoxClub.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxClub.TabIndex = 4;
            pBoxClub.TabStop = false;
            tTipCards.SetToolTip(pBoxClub, "Tells you name of card");
            pBoxClub.Click += pBoxClub_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(344, 341);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "E&xit";
            tTipCards.SetToolTip(btnExit, "Exits Form");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblUserQuestion
            // 
            lblUserQuestion.AutoSize = true;
            lblUserQuestion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserQuestion.Location = new Point(258, 24);
            lblUserQuestion.Name = "lblUserQuestion";
            lblUserQuestion.Size = new Size(276, 30);
            lblUserQuestion.TabIndex = 5;
            lblUserQuestion.Text = "Click a Card to See Its Name";
            // 
            // lblNameofCard
            // 
            lblNameofCard.AutoSize = true;
            lblNameofCard.Location = new Point(344, 304);
            lblNameofCard.Name = "lblNameofCard";
            lblNameofCard.Size = new Size(0, 15);
            lblNameofCard.TabIndex = 6;
            lblNameofCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 393);
            Controls.Add(btnExit);
            Controls.Add(lblNameofCard);
            Controls.Add(lblUserQuestion);
            Controls.Add(pBoxClub);
            Controls.Add(pBoxAce);
            Controls.Add(pBoxJack);
            Controls.Add(pBoxKing);
            Controls.Add(pBoxQueen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jorge Ortiz Lab 2 Card Identifier";
            ((System.ComponentModel.ISupportInitialize)pBoxQueen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxKing).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxJack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxAce).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxClub).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxQueen;
        private PictureBox pBoxKing;
        private PictureBox pBoxJack;
        private PictureBox pBoxAce;
        private PictureBox pBoxClub;
        private ToolTip tTipCards;
        private Label lblUserQuestion;
        private Label lblNameofCard;
        private Button btnExit;
    }
}
