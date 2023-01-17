using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInPage
{
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment has been completed.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txt1 = Convert.ToInt32(NumberSessionTb.Text);
            int txt2 = Convert.ToInt32(SessionCostTb.Text);

            int sum = txt1 * txt2;
            TotalTb.Text = sum.ToString();
            
        }
    }
}
