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
    public partial class SystemioTest : Form
    {
        public SystemioTest()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SystemioTest_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Bir Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya seç";
            openFileDialog1.InitialDirectory = @"C:\Users\irem\Desktop";
            openFileDialog1.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpeg|Jpg Dosyaları (*.jpg)|*.jpeg|Png Dosyaları (*.png)*.png|";

        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
