using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemInformasiAkademik
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
             //untuk membuat password menjadi di tutupi menjadi *
            textBox2.PasswordChar = '*' ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //melakukan query dengan fungsi untuk Login 
            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(" select * from users where UserName = '" + textBox1.Text+"' and Password = '"+textBox2.Text+"'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            //membuat pengecekan jika Ada Username Dan Password di database Yang sama dengan input, maka buka FormMenuUtama
            if(rd.Read())
            {
                FormMenuUtama utama = new FormMenuUtama();
                utama.Show();
                this.Hide();
            }
            // jika tidak ada / salah maka Username atau Password salah
            else
            {
                MessageBox.Show("Usernamae atau Password salah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //untuk keluar dari aplikasi
            Application.Exit();
        }
    }
}
