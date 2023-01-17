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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            login loginpage = new login();
            loginpage.ShowDialog();
        }

        private void CreateProfileBtn_Click(object sender, EventArgs e)
        {
            CreateProfile createprofile = new CreateProfile();
            createprofile.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            AppointmentPage appopage = new AppointmentPage();
            appopage.ShowDialog();
        }

        private void OnlineMeetingBtn_Click(object sender, EventArgs e)
        {
            OnlineMeetingPage onlinemeeting = new OnlineMeetingPage();
            onlinemeeting.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentPage payment = new PaymentPage();
            payment.ShowDialog();
        }

        
    }
}
