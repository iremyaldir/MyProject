using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogInPage
{
    public partial class login : Form
    {
        // integrated security hangi authentication ile girdiğine bağlı bir durum.
        // Eğer windows authentication ise TRUE; Server authentication ile girersen FALSE olacak.
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-104K1D6\\SQLEXPRESS; Initial Catalog = TMCtest; Integrated Security = TRUE");
         public login()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Username")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Username";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if( textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = '*';
            }
        }
        // char'a null atamak için char'ın yanına bir soru işareti koyuyoruz.
        char? none = null;
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Password";
                textBox3.ForeColor = Color.Gray;
                textBox3.PasswordChar = Convert.ToChar(none);
            }
        }
        bool IsThere;
        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string pass = textBox3.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("select * from TMCtbl", connection);
            //executereader() oluşturduğum tablodaki tüm değerleri okuyor
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {   //TrimEnd() --stringler için kullanılır-- sondan bşlayarak karakter siler parantez içinde dahil edilmeyen bir karakter bulana kadar siler
                //Burada boşlukları siliyor. ToString yapmasaydık kullanamazdık.
                if (username == reader["username"].ToString().TrimEnd() && pass == reader["pass"].ToString().TrimEnd())
                {
                    IsThere = true;
                    break;
                }
                else
                {
                    IsThere = false;
                }
            }

                connection.Close();

                if(IsThere)
                {
                    MessageBox.Show("Login Success!", " ");
                }
                else
                {
                    MessageBox.Show("Login Failed!", " ");
                }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.ShowDialog();
        }
    }
}
