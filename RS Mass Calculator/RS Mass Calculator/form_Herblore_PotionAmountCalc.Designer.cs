namespace RS_Mass_Calculator
{
    partial class form_Herblore_PotionAmountCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Coins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IngrediantA = new System.Windows.Forms.TextBox();
            this.txt_IngrediantB = new System.Windows.Forms.TextBox();
            this.txt_Vial = new System.Windows.Forms.TextBox();
            this.chk_IgnoreVial = new System.Windows.Forms.CheckBox();
            this.chk_Well = new System.Windows.Forms.CheckBox();
            this.chk_SoC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Ingrediants = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TotalPotions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coins:";
            // 
            // txt_Coins
            // 
            this.txt_Coins.Location = new System.Drawing.Point(136, 27);
            this.txt_Coins.Name = "txt_Coins";
            this.txt_Coins.Size = new System.Drawing.Size(100, 20);
            this.txt_Coins.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrediant A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrediant B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Water Vial:";
            // 
            // txt_IngrediantA
            // 
            this.txt_IngrediantA.Location = new System.Drawing.Point(136, 47);
            this.txt_IngrediantA.Name = "txt_IngrediantA";
            this.txt_IngrediantA.Size = new System.Drawing.Size(100, 20);
            this.txt_IngrediantA.TabIndex = 5;
            // 
            // txt_IngrediantB
            // 
            this.txt_IngrediantB.Location = new System.Drawing.Point(136, 67);
            this.txt_IngrediantB.Name = "txt_IngrediantB";
            this.txt_IngrediantB.Size = new System.Drawing.Size(100, 20);
            this.txt_IngrediantB.TabIndex = 6;
            // 
            // txt_Vial
            // 
            this.txt_Vial.Location = new System.Drawing.Point(136, 87);
            this.txt_Vial.Name = "txt_Vial";
            this.txt_Vial.Size = new System.Drawing.Size(100, 20);
            this.txt_Vial.TabIndex = 7;
            this.txt_Vial.Text = "Use JSON here";
            // 
            // chk_IgnoreVial
            // 
            this.chk_IgnoreVial.AutoSize = true;
            this.chk_IgnoreVial.Location = new System.Drawing.Point(18, 119);
            this.chk_IgnoreVial.Name = "chk_IgnoreVial";
            this.chk_IgnoreVial.Size = new System.Drawing.Size(76, 17);
            this.chk_IgnoreVial.TabIndex = 8;
            this.chk_IgnoreVial.Text = "Ignore Vial";
            this.chk_IgnoreVial.UseVisualStyleBackColor = true;
            // 
            // chk_Well
            // 
            this.chk_Well.AutoSize = true;
            this.chk_Well.Location = new System.Drawing.Point(18, 142);
            this.chk_Well.Name = "chk_Well";
            this.chk_Well.Size = new System.Drawing.Size(51, 17);
            this.chk_Well.TabIndex = 9;
            this.chk_Well.Text = "Well*";
            this.chk_Well.UseVisualStyleBackColor = true;
            // 
            // chk_SoC
            // 
            this.chk_SoC.AutoSize = true;
            this.chk_SoC.Location = new System.Drawing.Point(136, 119);
            this.chk_SoC.Name = "chk_SoC";
            this.chk_SoC.Size = new System.Drawing.Size(50, 17);
            this.chk_SoC.TabIndex = 9;
            this.chk_SoC.Text = "SoC*";
            this.chk_SoC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Note*: Using the Well or SoC results in an estimated amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "# of Ingrediants to buy:";
            // 
            // lbl_Ingrediants
            // 
            this.lbl_Ingrediants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Ingrediants.Location = new System.Drawing.Point(150, 185);
            this.lbl_Ingrediants.Name = "lbl_Ingrediants";
            this.lbl_Ingrediants.Size = new System.Drawing.Size(100, 23);
            this.lbl_Ingrediants.TabIndex = 13;
            this.lbl_Ingrediants.Text = "0";
            this.lbl_Ingrediants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(12, 280);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 14;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(230, 280);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(123, 280);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Potions**:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Note**: It is assumed that ingrediant A is an herb";
            // 
            // lbl_TotalPotions
            // 
            this.lbl_TotalPotions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TotalPotions.Location = new System.Drawing.Point(150, 218);
            this.lbl_TotalPotions.Name = "lbl_TotalPotions";
            this.lbl_TotalPotions.Size = new System.Drawing.Size(100, 23);
            this.lbl_TotalPotions.TabIndex = 19;
            this.lbl_TotalPotions.Text = "0";
            this.lbl_TotalPotions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_Herblore_PotionAmountCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 370);
            this.Controls.Add(this.lbl_TotalPotions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_Ingrediants);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_SoC);
            this.Controls.Add(this.chk_Well);
            this.Controls.Add(this.chk_IgnoreVial);
            this.Controls.Add(this.txt_Vial);
            this.Controls.Add(this.txt_IngrediantB);
            this.Controls.Add(this.txt_IngrediantA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Coins);
            this.Controls.Add(this.label1);
            this.Name = "form_Herblore_PotionAmountCalc";
            this.Text = "form_Herblore_PotionAmountCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Coins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IngrediantA;
        private System.Windows.Forms.TextBox txt_IngrediantB;
        private System.Windows.Forms.TextBox txt_Vial;
        private System.Windows.Forms.CheckBox chk_IgnoreVial;
        private System.Windows.Forms.CheckBox chk_Well;
        private System.Windows.Forms.CheckBox chk_SoC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Ingrediants;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_TotalPotions;
    }
}