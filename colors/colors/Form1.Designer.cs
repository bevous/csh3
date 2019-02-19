namespace colors
{
    partial class colorsForm
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
            this.hexValueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.colorNumberTextBox = new System.Windows.Forms.TextBox();
            this.tempatureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorNumberLabel = new System.Windows.Forms.Label();
            this.tempatureLabel = new System.Windows.Forms.Label();
            this.hextValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempatureNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // hexValueRichTextBox
            // 
            this.hexValueRichTextBox.Location = new System.Drawing.Point(119, 130);
            this.hexValueRichTextBox.Name = "hexValueRichTextBox";
            this.hexValueRichTextBox.Size = new System.Drawing.Size(217, 157);
            this.hexValueRichTextBox.TabIndex = 0;
            this.hexValueRichTextBox.Text = "";
            // 
            // colorNumberTextBox
            // 
            this.colorNumberTextBox.Location = new System.Drawing.Point(119, 66);
            this.colorNumberTextBox.Name = "colorNumberTextBox";
            this.colorNumberTextBox.Size = new System.Drawing.Size(91, 22);
            this.colorNumberTextBox.TabIndex = 1;
            // 
            // tempatureNumericUpDown
            // 
            this.tempatureNumericUpDown.Location = new System.Drawing.Point(216, 67);
            this.tempatureNumericUpDown.Name = "tempatureNumericUpDown";
            this.tempatureNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.tempatureNumericUpDown.TabIndex = 2;
            this.tempatureNumericUpDown.ValueChanged += new System.EventHandler(this.TemperatureNumericUpDownValueChanged);
            // 
            // colorNumberLabel
            // 
            this.colorNumberLabel.AutoSize = true;
            this.colorNumberLabel.Location = new System.Drawing.Point(116, 46);
            this.colorNumberLabel.Name = "colorNumberLabel";
            this.colorNumberLabel.Size = new System.Drawing.Size(91, 17);
            this.colorNumberLabel.TabIndex = 3;
            this.colorNumberLabel.Text = "color number";
            // 
            // tempatureLabel
            // 
            this.tempatureLabel.AutoSize = true;
            this.tempatureLabel.Location = new System.Drawing.Point(235, 46);
            this.tempatureLabel.Name = "tempatureLabel";
            this.tempatureLabel.Size = new System.Drawing.Size(77, 17);
            this.tempatureLabel.TabIndex = 4;
            this.tempatureLabel.Text = "Tempature";
            // 
            // hextValueLabel
            // 
            this.hextValueLabel.AutoSize = true;
            this.hextValueLabel.Location = new System.Drawing.Point(190, 110);
            this.hextValueLabel.Name = "hextValueLabel";
            this.hextValueLabel.Size = new System.Drawing.Size(68, 17);
            this.hextValueLabel.TabIndex = 5;
            this.hextValueLabel.Text = "hex value";
            // 
            // colorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 310);
            this.Controls.Add(this.hextValueLabel);
            this.Controls.Add(this.tempatureLabel);
            this.Controls.Add(this.colorNumberLabel);
            this.Controls.Add(this.tempatureNumericUpDown);
            this.Controls.Add(this.colorNumberTextBox);
            this.Controls.Add(this.hexValueRichTextBox);
            this.Name = "colorsForm";
            this.Text = "colors";
            ((System.ComponentModel.ISupportInitialize)(this.tempatureNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox hexValueRichTextBox;
        private System.Windows.Forms.TextBox colorNumberTextBox;
        private System.Windows.Forms.NumericUpDown tempatureNumericUpDown;
        private System.Windows.Forms.Label colorNumberLabel;
        private System.Windows.Forms.Label tempatureLabel;
        private System.Windows.Forms.Label hextValueLabel;
    }
}

