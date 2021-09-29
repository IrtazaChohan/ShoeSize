using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeSize
{
    public partial class FrmShoeSize : Form
    {
        public FrmShoeSize()
        {
            InitializeComponent();
        }

        int shoesize;
        double price;
        int numberofshoes;
        double total=0;

        private void BtnShoeSize_Click(object sender, EventArgs e)
        {
            // shoesize = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter shoe size", "Shoe Size Entry Box", ""));

            shoesize = (int)numericUpDown2.Value;
            numberofshoes = (int)numericUpDown1.Value;

            if (shoesize <= 4)
            {
                price = 5.00;
                total = (price * numberofshoes);
                txtMessageBox.Text = "Head over to the Children Section and price will be " + total.ToString("c");
            }
            else if (shoesize >= 5 && shoesize <= 9){
                price = 10.00;
                total = (price * numberofshoes);
                txtMessageBox.Text = "Head over to Teenagers Section and price will be " + total.ToString("c");
            }
            else if (shoesize >= 9)
            {
                price = 15.00;
                total = (price * numberofshoes);
                txtMessageBox.Text = "Head over to the Adults section and price will be " + total.ToString("c");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMessageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
