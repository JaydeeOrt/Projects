namespace JortizLab6
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
            grpBoxOilLube = new GroupBox();
            chkBoxLube = new CheckBox();
            chkBoxOil = new CheckBox();
            grpBoxFlush = new GroupBox();
            chkBoxTransmission = new CheckBox();
            chkBoxRadiator = new CheckBox();
            grpBoxMisc = new GroupBox();
            chkBoxTire = new CheckBox();
            chkBoxMuffler = new CheckBox();
            chkBoxInspec = new CheckBox();
            grpBoxPartsLabor = new GroupBox();
            txtBoxLabor = new TextBox();
            txtBoxParts = new TextBox();
            lblLabor = new Label();
            lblParts = new Label();
            grpBoxSummary = new GroupBox();
            txtBoxTotal = new TextBox();
            lblTotal = new Label();
            txtBoxSumParts = new TextBox();
            txtBoxService = new TextBox();
            lblTax = new Label();
            lblSumParts = new Label();
            lblService = new Label();
            txtBoxTax = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            tTipAutomotive = new ToolTip(components);
            grpBoxOilLube.SuspendLayout();
            grpBoxFlush.SuspendLayout();
            grpBoxMisc.SuspendLayout();
            grpBoxPartsLabor.SuspendLayout();
            grpBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxOilLube
            // 
            grpBoxOilLube.Controls.Add(chkBoxLube);
            grpBoxOilLube.Controls.Add(chkBoxOil);
            grpBoxOilLube.Location = new Point(12, 11);
            grpBoxOilLube.Margin = new Padding(3, 2, 3, 2);
            grpBoxOilLube.Name = "grpBoxOilLube";
            grpBoxOilLube.Padding = new Padding(3, 2, 3, 2);
            grpBoxOilLube.Size = new Size(219, 82);
            grpBoxOilLube.TabIndex = 0;
            grpBoxOilLube.TabStop = false;
            grpBoxOilLube.Text = "Oil and Lube";
            // 
            // chkBoxLube
            // 
            chkBoxLube.AutoSize = true;
            chkBoxLube.Location = new Point(22, 57);
            chkBoxLube.Margin = new Padding(3, 2, 3, 2);
            chkBoxLube.Name = "chkBoxLube";
            chkBoxLube.Size = new Size(116, 19);
            chkBoxLube.TabIndex = 1;
            chkBoxLube.Text = "Lube job ($18.00)";
            chkBoxLube.UseVisualStyleBackColor = true;
            // 
            // chkBoxOil
            // 
            chkBoxOil.AutoSize = true;
            chkBoxOil.Location = new Point(24, 26);
            chkBoxOil.Margin = new Padding(3, 2, 3, 2);
            chkBoxOil.Name = "chkBoxOil";
            chkBoxOil.Size = new Size(129, 19);
            chkBoxOil.TabIndex = 0;
            chkBoxOil.Text = "Oil Change ($26.00)";
            chkBoxOil.UseVisualStyleBackColor = true;
            // 
            // grpBoxFlush
            // 
            grpBoxFlush.Controls.Add(chkBoxTransmission);
            grpBoxFlush.Controls.Add(chkBoxRadiator);
            grpBoxFlush.Location = new Point(265, 11);
            grpBoxFlush.Margin = new Padding(3, 2, 3, 2);
            grpBoxFlush.Name = "grpBoxFlush";
            grpBoxFlush.Padding = new Padding(3, 2, 3, 2);
            grpBoxFlush.Size = new Size(219, 82);
            grpBoxFlush.TabIndex = 1;
            grpBoxFlush.TabStop = false;
            grpBoxFlush.Text = "Flushes";
            // 
            // chkBoxTransmission
            // 
            chkBoxTransmission.AutoSize = true;
            chkBoxTransmission.Location = new Point(16, 57);
            chkBoxTransmission.Margin = new Padding(3, 2, 3, 2);
            chkBoxTransmission.Name = "chkBoxTransmission";
            chkBoxTransmission.Size = new Size(170, 19);
            chkBoxTransmission.TabIndex = 1;
            chkBoxTransmission.Text = "Transmission Flush ($80.00)";
            chkBoxTransmission.UseVisualStyleBackColor = true;
            // 
            // chkBoxRadiator
            // 
            chkBoxRadiator.AutoSize = true;
            chkBoxRadiator.Location = new Point(15, 26);
            chkBoxRadiator.Margin = new Padding(3, 2, 3, 2);
            chkBoxRadiator.Name = "chkBoxRadiator";
            chkBoxRadiator.Size = new Size(145, 19);
            chkBoxRadiator.TabIndex = 0;
            chkBoxRadiator.Text = "Radiator Flush ($30.00)";
            chkBoxRadiator.UseVisualStyleBackColor = true;
            // 
            // grpBoxMisc
            // 
            grpBoxMisc.Controls.Add(chkBoxTire);
            grpBoxMisc.Controls.Add(chkBoxMuffler);
            grpBoxMisc.Controls.Add(chkBoxInspec);
            grpBoxMisc.Location = new Point(12, 99);
            grpBoxMisc.Margin = new Padding(3, 2, 3, 2);
            grpBoxMisc.Name = "grpBoxMisc";
            grpBoxMisc.Padding = new Padding(3, 2, 3, 2);
            grpBoxMisc.Size = new Size(219, 94);
            grpBoxMisc.TabIndex = 2;
            grpBoxMisc.TabStop = false;
            grpBoxMisc.Text = "Misc";
            // 
            // chkBoxTire
            // 
            chkBoxTire.AutoSize = true;
            chkBoxTire.Location = new Point(14, 63);
            chkBoxTire.Margin = new Padding(3, 2, 3, 2);
            chkBoxTire.Name = "chkBoxTire";
            chkBoxTire.Size = new Size(138, 19);
            chkBoxTire.TabIndex = 2;
            chkBoxTire.Text = "Tire Rotation ($20.00)";
            chkBoxTire.UseVisualStyleBackColor = true;
            // 
            // chkBoxMuffler
            // 
            chkBoxMuffler.AutoSize = true;
            chkBoxMuffler.Location = new Point(14, 38);
            chkBoxMuffler.Margin = new Padding(3, 2, 3, 2);
            chkBoxMuffler.Name = "chkBoxMuffler";
            chkBoxMuffler.Size = new Size(159, 19);
            chkBoxMuffler.TabIndex = 1;
            chkBoxMuffler.Text = "Replace Muffler ($100.00)";
            chkBoxMuffler.UseVisualStyleBackColor = true;
            // 
            // chkBoxInspec
            // 
            chkBoxInspec.AutoSize = true;
            chkBoxInspec.Location = new Point(13, 17);
            chkBoxInspec.Margin = new Padding(3, 2, 3, 2);
            chkBoxInspec.Name = "chkBoxInspec";
            chkBoxInspec.Size = new Size(125, 19);
            chkBoxInspec.TabIndex = 0;
            chkBoxInspec.Text = "Inspection ($15.00)";
            chkBoxInspec.UseVisualStyleBackColor = true;
            // 
            // grpBoxPartsLabor
            // 
            grpBoxPartsLabor.Controls.Add(txtBoxLabor);
            grpBoxPartsLabor.Controls.Add(txtBoxParts);
            grpBoxPartsLabor.Controls.Add(lblLabor);
            grpBoxPartsLabor.Controls.Add(lblParts);
            grpBoxPartsLabor.Location = new Point(265, 99);
            grpBoxPartsLabor.Margin = new Padding(3, 2, 3, 2);
            grpBoxPartsLabor.Name = "grpBoxPartsLabor";
            grpBoxPartsLabor.Padding = new Padding(3, 2, 3, 2);
            grpBoxPartsLabor.Size = new Size(219, 94);
            grpBoxPartsLabor.TabIndex = 3;
            grpBoxPartsLabor.TabStop = false;
            grpBoxPartsLabor.Text = "Parts and Labor";
            // 
            // txtBoxLabor
            // 
            txtBoxLabor.Location = new Point(87, 60);
            txtBoxLabor.Margin = new Padding(3, 2, 3, 2);
            txtBoxLabor.Name = "txtBoxLabor";
            txtBoxLabor.Size = new Size(110, 23);
            txtBoxLabor.TabIndex = 1;
            // 
            // txtBoxParts
            // 
            txtBoxParts.Location = new Point(87, 25);
            txtBoxParts.Margin = new Padding(3, 2, 3, 2);
            txtBoxParts.Name = "txtBoxParts";
            txtBoxParts.Size = new Size(110, 23);
            txtBoxParts.TabIndex = 0;
            // 
            // lblLabor
            // 
            lblLabor.AutoSize = true;
            lblLabor.Location = new Point(15, 65);
            lblLabor.Name = "lblLabor";
            lblLabor.Size = new Size(54, 15);
            lblLabor.TabIndex = 1;
            lblLabor.Text = "Labor ($)";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(27, 27);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(33, 15);
            lblParts.TabIndex = 0;
            lblParts.Text = "Parts";
            // 
            // grpBoxSummary
            // 
            grpBoxSummary.Controls.Add(txtBoxTotal);
            grpBoxSummary.Controls.Add(lblTotal);
            grpBoxSummary.Controls.Add(txtBoxSumParts);
            grpBoxSummary.Controls.Add(txtBoxService);
            grpBoxSummary.Controls.Add(lblTax);
            grpBoxSummary.Controls.Add(lblSumParts);
            grpBoxSummary.Controls.Add(lblService);
            grpBoxSummary.Controls.Add(txtBoxTax);
            grpBoxSummary.Location = new Point(54, 197);
            grpBoxSummary.Margin = new Padding(3, 2, 3, 2);
            grpBoxSummary.Name = "grpBoxSummary";
            grpBoxSummary.Padding = new Padding(3, 2, 3, 2);
            grpBoxSummary.Size = new Size(258, 138);
            grpBoxSummary.TabIndex = 4;
            grpBoxSummary.TabStop = false;
            grpBoxSummary.Text = "Summary";
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Enabled = false;
            txtBoxTotal.Location = new Point(128, 110);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(110, 23);
            txtBoxTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(22, 113);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total Fees";
            // 
            // txtBoxSumParts
            // 
            txtBoxSumParts.Enabled = false;
            txtBoxSumParts.Location = new Point(128, 44);
            txtBoxSumParts.Margin = new Padding(3, 2, 3, 2);
            txtBoxSumParts.Name = "txtBoxSumParts";
            txtBoxSumParts.Size = new Size(110, 23);
            txtBoxSumParts.TabIndex = 4;
            // 
            // txtBoxService
            // 
            txtBoxService.Enabled = false;
            txtBoxService.Location = new Point(128, 14);
            txtBoxService.Margin = new Padding(3, 2, 3, 2);
            txtBoxService.Name = "txtBoxService";
            txtBoxService.Size = new Size(110, 23);
            txtBoxService.TabIndex = 3;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(22, 79);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(78, 15);
            lblTax.TabIndex = 2;
            lblTax.Text = "Tax (on Parts)";
            // 
            // lblSumParts
            // 
            lblSumParts.AutoSize = true;
            lblSumParts.Location = new Point(22, 47);
            lblSumParts.Name = "lblSumParts";
            lblSumParts.Size = new Size(33, 15);
            lblSumParts.TabIndex = 1;
            lblSumParts.Text = "Parts";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(22, 17);
            lblService.Name = "lblService";
            lblService.Size = new Size(100, 15);
            lblService.TabIndex = 0;
            lblService.Text = "Service and Labor";
            // 
            // txtBoxTax
            // 
            txtBoxTax.Enabled = false;
            txtBoxTax.Location = new Point(128, 76);
            txtBoxTax.Margin = new Padding(3, 2, 3, 2);
            txtBoxTax.Name = "txtBoxTax";
            txtBoxTax.Size = new Size(110, 23);
            txtBoxTax.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(369, 214);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(82, 22);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "C&alculate";
            tTipAutomotive.SetToolTip(btnCalculate, "Gives you Summary");
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(369, 253);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            tTipAutomotive.SetToolTip(btnClear, "Clears the form");
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(369, 289);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            tTipAutomotive.SetToolTip(btnExit, "Exits the program");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btnExit;
            ClientSize = new Size(536, 338);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(grpBoxSummary);
            Controls.Add(grpBoxPartsLabor);
            Controls.Add(grpBoxMisc);
            Controls.Add(grpBoxFlush);
            Controls.Add(grpBoxOilLube);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jorge Ortiz Lab 6 Automotive";
            grpBoxOilLube.ResumeLayout(false);
            grpBoxOilLube.PerformLayout();
            grpBoxFlush.ResumeLayout(false);
            grpBoxFlush.PerformLayout();
            grpBoxMisc.ResumeLayout(false);
            grpBoxMisc.PerformLayout();
            grpBoxPartsLabor.ResumeLayout(false);
            grpBoxPartsLabor.PerformLayout();
            grpBoxSummary.ResumeLayout(false);
            grpBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxOilLube;
        private GroupBox grpBoxFlush;
        private GroupBox grpBoxMisc;
        private GroupBox grpBoxPartsLabor;
        private GroupBox grpBoxSummary;
        private CheckBox chkBoxLube;
        private CheckBox chkBoxOil;
        private CheckBox chkBoxTransmission;
        private CheckBox chkBoxRadiator;
        private CheckBox chkBoxTire;
        private CheckBox chkBoxMuffler;
        private CheckBox chkBoxInspec;
        private TextBox txtBoxLabor;
        private TextBox txtBoxParts;
        private Label lblLabor;
        private Label lblParts;
        private TextBox txtBoxTax;
        private TextBox txtBoxSumParts;
        private TextBox txtBoxService;
        private Label lblTax;
        private Label lblSumParts;
        private Label lblService;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblTotal;
        private TextBox txtBoxTotal;
        private ToolTip tTipAutomotive;
    }
}
