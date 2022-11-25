namespace ApiCalc
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
            this.fetchApiButton = new System.Windows.Forms.Button();
            this.rateUSDTextBox = new System.Windows.Forms.TextBox();
            this.rateUSDLabel = new System.Windows.Forms.Label();
            this.rateEURTextBox = new System.Windows.Forms.TextBox();
            this.rateCHFTextBox = new System.Windows.Forms.TextBox();
            this.rateEURLabel = new System.Windows.Forms.Label();
            this.rateCHFLabel = new System.Windows.Forms.Label();
            this.exchangeLabel = new System.Windows.Forms.Label();
            this.ammountPLNTextBox = new System.Windows.Forms.TextBox();
            this.ammountPLNLabel = new System.Windows.Forms.Label();
            this.USDRadioButton = new System.Windows.Forms.RadioButton();
            this.EURRadioButton = new System.Windows.Forms.RadioButton();
            this.CHFRadioButton = new System.Windows.Forms.RadioButton();
            this.calculatedAmmountTextBox = new System.Windows.Forms.TextBox();
            this.calculatedAmmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fetchApiButton
            // 
            this.fetchApiButton.Location = new System.Drawing.Point(210, 12);
            this.fetchApiButton.Name = "fetchApiButton";
            this.fetchApiButton.Size = new System.Drawing.Size(113, 81);
            this.fetchApiButton.TabIndex = 1;
            this.fetchApiButton.Text = "Pobierz";
            this.fetchApiButton.UseVisualStyleBackColor = true;
            this.fetchApiButton.Click += new System.EventHandler(this.fetchApiButton_Click);
            // 
            // rateUSDTextBox
            // 
            this.rateUSDTextBox.Location = new System.Drawing.Point(104, 12);
            this.rateUSDTextBox.Name = "rateUSDTextBox";
            this.rateUSDTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateUSDTextBox.TabIndex = 2;
            // 
            // rateUSDLabel
            // 
            this.rateUSDLabel.AutoSize = true;
            this.rateUSDLabel.Location = new System.Drawing.Point(43, 15);
            this.rateUSDLabel.Name = "rateUSDLabel";
            this.rateUSDLabel.Size = new System.Drawing.Size(55, 15);
            this.rateUSDLabel.TabIndex = 3;
            this.rateUSDLabel.Text = "Kurs USD";
            // 
            // rateEURTextBox
            // 
            this.rateEURTextBox.Location = new System.Drawing.Point(104, 41);
            this.rateEURTextBox.Name = "rateEURTextBox";
            this.rateEURTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateEURTextBox.TabIndex = 4;
            // 
            // rateCHFTextBox
            // 
            this.rateCHFTextBox.Location = new System.Drawing.Point(104, 70);
            this.rateCHFTextBox.Name = "rateCHFTextBox";
            this.rateCHFTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateCHFTextBox.TabIndex = 5;
            // 
            // rateEURLabel
            // 
            this.rateEURLabel.AutoSize = true;
            this.rateEURLabel.Location = new System.Drawing.Point(44, 44);
            this.rateEURLabel.Name = "rateEURLabel";
            this.rateEURLabel.Size = new System.Drawing.Size(54, 15);
            this.rateEURLabel.TabIndex = 6;
            this.rateEURLabel.Text = "Kurs EUR";
            // 
            // rateCHFLabel
            // 
            this.rateCHFLabel.AutoSize = true;
            this.rateCHFLabel.Location = new System.Drawing.Point(42, 73);
            this.rateCHFLabel.Name = "rateCHFLabel";
            this.rateCHFLabel.Size = new System.Drawing.Size(56, 15);
            this.rateCHFLabel.TabIndex = 7;
            this.rateCHFLabel.Text = "Kurs CHF";
            // 
            // exchangeLabel
            // 
            this.exchangeLabel.AutoSize = true;
            this.exchangeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exchangeLabel.Location = new System.Drawing.Point(12, 118);
            this.exchangeLabel.Name = "exchangeLabel";
            this.exchangeLabel.Size = new System.Drawing.Size(182, 25);
            this.exchangeLabel.TabIndex = 8;
            this.exchangeLabel.Text = "Kalkulator walutowy";
            // 
            // ammountPLNTextBox
            // 
            this.ammountPLNTextBox.Location = new System.Drawing.Point(12, 182);
            this.ammountPLNTextBox.Name = "ammountPLNTextBox";
            this.ammountPLNTextBox.Size = new System.Drawing.Size(100, 23);
            this.ammountPLNTextBox.TabIndex = 9;
            // 
            // ammountPLNLabel
            // 
            this.ammountPLNLabel.AutoSize = true;
            this.ammountPLNLabel.Location = new System.Drawing.Point(12, 164);
            this.ammountPLNLabel.Name = "ammountPLNLabel";
            this.ammountPLNLabel.Size = new System.Drawing.Size(59, 15);
            this.ammountPLNLabel.TabIndex = 10;
            this.ammountPLNLabel.Text = "Kwota (zł)";
            // 
            // USDRadioButton
            // 
            this.USDRadioButton.AutoSize = true;
            this.USDRadioButton.Location = new System.Drawing.Point(147, 182);
            this.USDRadioButton.Name = "USDRadioButton";
            this.USDRadioButton.Size = new System.Drawing.Size(47, 19);
            this.USDRadioButton.TabIndex = 11;
            this.USDRadioButton.TabStop = true;
            this.USDRadioButton.Text = "USD";
            this.USDRadioButton.UseVisualStyleBackColor = true;
            this.USDRadioButton.Click += new System.EventHandler(this.Exchange);
            // 
            // EURRadioButton
            // 
            this.EURRadioButton.AutoSize = true;
            this.EURRadioButton.Location = new System.Drawing.Point(147, 207);
            this.EURRadioButton.Name = "EURRadioButton";
            this.EURRadioButton.Size = new System.Drawing.Size(46, 19);
            this.EURRadioButton.TabIndex = 12;
            this.EURRadioButton.TabStop = true;
            this.EURRadioButton.Text = "EUR";
            this.EURRadioButton.UseVisualStyleBackColor = true;
            this.EURRadioButton.Click += new System.EventHandler(this.Exchange);
            // 
            // CHFRadioButton
            // 
            this.CHFRadioButton.AutoSize = true;
            this.CHFRadioButton.Location = new System.Drawing.Point(147, 232);
            this.CHFRadioButton.Name = "CHFRadioButton";
            this.CHFRadioButton.Size = new System.Drawing.Size(48, 19);
            this.CHFRadioButton.TabIndex = 13;
            this.CHFRadioButton.TabStop = true;
            this.CHFRadioButton.Text = "CHF";
            this.CHFRadioButton.UseVisualStyleBackColor = true;
            this.CHFRadioButton.Click += new System.EventHandler(this.Exchange);
            // 
            // calculatedAmmountTextBox
            // 
            this.calculatedAmmountTextBox.Location = new System.Drawing.Point(223, 182);
            this.calculatedAmmountTextBox.Name = "calculatedAmmountTextBox";
            this.calculatedAmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.calculatedAmmountTextBox.TabIndex = 14;
            // 
            // calculatedAmmountLabel
            // 
            this.calculatedAmmountLabel.AutoSize = true;
            this.calculatedAmmountLabel.Location = new System.Drawing.Point(225, 164);
            this.calculatedAmmountLabel.Name = "calculatedAmmountLabel";
            this.calculatedAmmountLabel.Size = new System.Drawing.Size(98, 15);
            this.calculatedAmmountLabel.TabIndex = 15;
            this.calculatedAmmountLabel.Text = "Kwota w walucie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 289);
            this.Controls.Add(this.calculatedAmmountLabel);
            this.Controls.Add(this.calculatedAmmountTextBox);
            this.Controls.Add(this.CHFRadioButton);
            this.Controls.Add(this.EURRadioButton);
            this.Controls.Add(this.USDRadioButton);
            this.Controls.Add(this.ammountPLNLabel);
            this.Controls.Add(this.ammountPLNTextBox);
            this.Controls.Add(this.exchangeLabel);
            this.Controls.Add(this.rateCHFLabel);
            this.Controls.Add(this.rateEURLabel);
            this.Controls.Add(this.rateCHFTextBox);
            this.Controls.Add(this.rateEURTextBox);
            this.Controls.Add(this.rateUSDLabel);
            this.Controls.Add(this.rateUSDTextBox);
            this.Controls.Add(this.fetchApiButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button fetchApiButton;
        private TextBox rateUSDTextBox;
        private Label rateUSDLabel;
        private TextBox rateEURTextBox;
        private TextBox rateCHFTextBox;
        private Label rateEURLabel;
        private Label rateCHFLabel;
        private Label exchangeLabel;
        private TextBox ammountPLNTextBox;
        private Label ammountPLNLabel;
        private RadioButton USDRadioButton;
        private RadioButton EURRadioButton;
        private RadioButton CHFRadioButton;
        private TextBox calculatedAmmountTextBox;
        private Label calculatedAmmountLabel;
    }
}