namespace TsSoft.AspNet.Utils
{
    partial class GeneratorForm
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
            this.generateButton = new System.Windows.Forms.Button();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.inPassLabel = new System.Windows.Forms.Label();
            this.outputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.outPassLabel = new System.Windows.Forms.Label();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.providerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.providerTypeNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(299, 140);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(79, 19);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(414, 20);
            this.inputPasswordTextBox.TabIndex = 1;
            // 
            // inPassLabel
            // 
            this.inPassLabel.AutoSize = true;
            this.inPassLabel.Location = new System.Drawing.Point(42, 22);
            this.inPassLabel.Name = "inPassLabel";
            this.inPassLabel.Size = new System.Drawing.Size(31, 13);
            this.inPassLabel.TabIndex = 2;
            this.inPassLabel.Text = "Input";
            // 
            // outputPasswordTextBox
            // 
            this.outputPasswordTextBox.Location = new System.Drawing.Point(79, 72);
            this.outputPasswordTextBox.Multiline = true;
            this.outputPasswordTextBox.Name = "outputPasswordTextBox";
            this.outputPasswordTextBox.ReadOnly = true;
            this.outputPasswordTextBox.Size = new System.Drawing.Size(415, 52);
            this.outputPasswordTextBox.TabIndex = 4;
            // 
            // outPassLabel
            // 
            this.outPassLabel.AutoSize = true;
            this.outPassLabel.Location = new System.Drawing.Point(16, 75);
            this.outPassLabel.Name = "outPassLabel";
            this.outPassLabel.Size = new System.Drawing.Size(57, 13);
            this.outPassLabel.TabIndex = 6;
            this.outPassLabel.Text = "Generated";
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(380, 140);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(113, 23);
            this.copyToClipboardButton.TabIndex = 7;
            this.copyToClipboardButton.Text = "Copy to clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // providerTypeComboBox
            // 
            this.providerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerTypeComboBox.FormattingEnabled = true;
            this.providerTypeComboBox.Location = new System.Drawing.Point(79, 45);
            this.providerTypeComboBox.Name = "providerTypeComboBox";
            this.providerTypeComboBox.Size = new System.Drawing.Size(205, 21);
            this.providerTypeComboBox.TabIndex = 8;
            // 
            // providerTypeNameLabel
            // 
            this.providerTypeNameLabel.AutoSize = true;
            this.providerTypeNameLabel.Location = new System.Drawing.Point(27, 48);
            this.providerTypeNameLabel.Name = "providerTypeNameLabel";
            this.providerTypeNameLabel.Size = new System.Drawing.Size(46, 13);
            this.providerTypeNameLabel.TabIndex = 9;
            this.providerTypeNameLabel.Text = "Provider";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 174);
            this.Controls.Add(this.providerTypeNameLabel);
            this.Controls.Add(this.providerTypeComboBox);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.outPassLabel);
            this.Controls.Add(this.outputPasswordTextBox);
            this.Controls.Add(this.inPassLabel);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.generateButton);
            this.MaximizeBox = false;
            this.Name = "GeneratorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TsSoft.AspNet.Utils Membership Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.Label inPassLabel;
        private System.Windows.Forms.TextBox outputPasswordTextBox;
        private System.Windows.Forms.Label outPassLabel;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.ComboBox providerTypeComboBox;
        private System.Windows.Forms.Label providerTypeNameLabel;
    }
}

