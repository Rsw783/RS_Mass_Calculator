using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS_Mass_Calculator
{
    public partial class form_Herblore_PotionAmountCalc : Form
    {
        public form_Herblore_PotionAmountCalc()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double dbl_Coins, dbl_IngrediantA, dbl_IngrediantB, dbl_Vial, dbl_IngAmount, dbl_Total, dbl_ItemFromWell, dbl_ItemFromSoC;
            int counter = 0;

            try
            {
                //Get the Input from the text boxes
                dbl_Coins = double.Parse(txt_Coins.Text);
                dbl_IngrediantA = double.Parse(txt_IngrediantA.Text);
                dbl_IngrediantB = double.Parse(txt_IngrediantB.Text);
                dbl_Vial = double.Parse(txt_Vial.Text);

                dbl_IngAmount = dbl_Coins / (dbl_IngrediantA + dbl_IngrediantB);

                counter = ;

            }
            catch
            {

            }
        }
    }
}
