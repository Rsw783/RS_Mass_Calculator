namespace RS_Mass_Calculator
{
    partial class form_Herblore
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
            this.btn_PotionAmountCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PotionAmountCalc
            // 
            this.btn_PotionAmountCalc.Location = new System.Drawing.Point(12, 12);
            this.btn_PotionAmountCalc.Name = "btn_PotionAmountCalc";
            this.btn_PotionAmountCalc.Size = new System.Drawing.Size(102, 35);
            this.btn_PotionAmountCalc.TabIndex = 0;
            this.btn_PotionAmountCalc.Text = "Potion Amount Calc";
            this.btn_PotionAmountCalc.UseVisualStyleBackColor = true;
            this.btn_PotionAmountCalc.Click += new System.EventHandler(this.btn_PotionAmountCalc_Click);
            // 
            // form_Herblore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_PotionAmountCalc);
            this.Name = "form_Herblore";
            this.Text = "Herblore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PotionAmountCalc;
    }
}