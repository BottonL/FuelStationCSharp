namespace GasPumpAppCSharp
{
    partial class PriceScreen
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.priceTextBoxDisable = new System.Windows.Forms.TextBox();
            this.volumeTextBoxDisable = new System.Windows.Forms.TextBox();
            this.unitPriceTextBoxDisable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(171, 93);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 20);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Prix";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(171, 191);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(63, 20);
            this.volumeLabel.TabIndex = 1;
            this.volumeLabel.Text = "Volume";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(171, 302);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(31, 20);
            this.unitPriceLabel.TabIndex = 2;
            this.unitPriceLabel.Text = "€/L";
            // 
            // priceTextBoxDisable
            // 
            this.priceTextBoxDisable.Enabled = false;
            this.priceTextBoxDisable.Location = new System.Drawing.Point(410, 93);
            this.priceTextBoxDisable.Name = "priceTextBoxDisable";
            this.priceTextBoxDisable.Size = new System.Drawing.Size(100, 26);
            this.priceTextBoxDisable.TabIndex = 3;
            // 
            // volumeTextBoxDisable
            // 
            this.volumeTextBoxDisable.Enabled = false;
            this.volumeTextBoxDisable.Location = new System.Drawing.Point(410, 185);
            this.volumeTextBoxDisable.Name = "volumeTextBoxDisable";
            this.volumeTextBoxDisable.Size = new System.Drawing.Size(100, 26);
            this.volumeTextBoxDisable.TabIndex = 4;
            // 
            // unitPriceTextBoxDisable
            // 
            this.unitPriceTextBoxDisable.Enabled = false;
            this.unitPriceTextBoxDisable.Location = new System.Drawing.Point(410, 296);
            this.unitPriceTextBoxDisable.Name = "unitPriceTextBoxDisable";
            this.unitPriceTextBoxDisable.Size = new System.Drawing.Size(100, 26);
            this.unitPriceTextBoxDisable.TabIndex = 5;
            // 
            // PriceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unitPriceTextBoxDisable);
            this.Controls.Add(this.volumeTextBoxDisable);
            this.Controls.Add(this.priceTextBoxDisable);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.priceLabel);
            this.Name = "PriceScreen";
            this.Text = "Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.TextBox priceTextBoxDisable;
        private System.Windows.Forms.TextBox volumeTextBoxDisable;
        private System.Windows.Forms.TextBox unitPriceTextBoxDisable;
    }
}