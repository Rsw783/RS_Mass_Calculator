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
    public partial class form_Herblore : Form
    {
        public form_Herblore()
        {
            InitializeComponent();
        }

        private void btn_PotionAmountCalc_Click(object sender, EventArgs e)
        {
            new form_Herblore_PotionAmountCalc().Show();

            this.Close();
        }
    }
}
