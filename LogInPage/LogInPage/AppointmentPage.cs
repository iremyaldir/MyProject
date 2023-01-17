using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogInPage
{
    
    public partial class AppointmentPage : Form
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment has been made.");
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            TB.Text = e.Start.ToString();
        }
    }
}
