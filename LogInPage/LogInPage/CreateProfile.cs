using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LogInPage
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Bir Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya seç";
            //Eğer @ kullanmasaydık backslash'ları çift yapmamız gerekirdi.
            openFileDialog1.InitialDirectory = @"C:\Users\irem\Desktop";
            openFileDialog1.Filter = "Jpeg Dosyaları (*.Jpeg)|*.Jpeg|Jpg Dosyaları (*.Jpg)|*.Jpg|Png Dosyaları (*.Png)|*.Png";

        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            //StartupPath yazdıktan sonra path'i buldum users irem source şeklinde sonra debug'ın içine advisors klasörü oluşturdum.
            //Her kullanıcı için ayrı bir dosya oluşturacak.
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Advisor\\" + FirstNameTb.Text + " " + LastNameTb.Text + ".txt");
            sw.WriteLine(FirstNameLb.Text + " " + FirstNameTb.Text);
            sw.WriteLine(LastNameLb.Text + " " + LastNameTb.Text);
            sw.WriteLine(GenderLb.Text + " " + GenderCb.Text);
            sw.WriteLine(UniversityNameLb.Text + " " + UniversityNameTb.Text);
            sw.WriteLine(DepartmentLb.Text + " " + DepartmentTb.Text);
            sw.WriteLine(GpaLb.Text + " " + GpaTb.Text);
            sw.WriteLine(CurrentJobPositionLb.Text + " " + CurrentJobPositionTb.Text);
            sw.WriteLine(CurrentCompanyLb.Text + " " + CurrentCompanyTb.Text);
            sw.Close();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Advisor\\" + FirstNameTb.Text + " " + LastNameTb.Text + ".txt");
            ReadFilesRTB.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
