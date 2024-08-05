using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemInformasiAkademik
{
    public partial class FormPenjadwalan : Form
    {
        public FormPenjadwalan()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            FormMenuUtama utama = new FormMenuUtama();  
            utama.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKodeMk.Clear();
            matakuliah.Clear();
            sks.Clear();
            jenismk.Clear();
            kelompok.Clear();
            txtkodeDosen.Clear();
            textBox9.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            txtJam.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F5)
            {
                FormPencarian pencarian = new FormPencarian();
                pencarian.Show();
                DataTable dt = new DataTable();
                dt = (DataTable)Connection.getQuery("select * from matakuliah");
                pencarian.dgvPencarian.DataSource = dt;
                pencarian.auth.Text = "1";
                
            }


            if (e.KeyCode == Keys.F8)
            {
                txtKodeMk.Clear();
                matakuliah.Clear();
                sks.Clear();
                jenismk.Clear();
                kelompok.Clear();
                txtkodeDosen.Clear();
                textBox9.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                txtJam.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from matakuliah where kode_mk='"+txtKodeMk.Text+"'",conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                matakuliah.Text = rd["Nama_mk"].ToString();
                sks.Text = rd["SKS"].ToString();
                jenismk.Text = rd["Jenis_mk"].ToString();
            }
            else
            {
                MessageBox.Show("Kode Matakuliah Tidak terdaftar");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dosen where kode_dosen='" + txtkodeDosen.Text + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                textBox9.Text = rd["Nama"].ToString();
                
            }
            else if (txtkodeDosen.Text == "")
            {

            }

            else
            {
                lblAlert.Text = "Kode Dosen Tidak terdaftar";
                //MessageBox.Show("Kode dosen Tidak terdaftar");
            }
        }

        private void txtkodeDosen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                FormPencarian pencarian = new FormPencarian();
                pencarian.Show();
                DataTable dt = new DataTable();
                dt = (DataTable)Connection.getQuery("select * from dosen");
                pencarian.dgvPencarian.DataSource = dt;
                pencarian.auth.Text = "2";
               lblsimpan.Text = txtKodeMk.Text;
                pencarian.lblsimpan.Text = txtKodeMk.Text;

            }
        }
        void matkul()
        {
            Connection.Exquery("insert into Matakuliah (Kode_mk, Nama_mk, Jenis_mk, SKS) values('"+txtKodeMk.Text+"', '"+matakuliah.Text+"', '"+sks.Text+"', '"+jenismk.Text+"')");
        }
        void dosen()
        {
            Connection.Exquery("insert into dosen(kode_dosen, nama) values('"+txtkodeDosen.Text+"', '"+textBox9.Text+"')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtJam.Text == textBox5.Text)
            {
                MessageBox.Show("pastikan jam tidak berbenturan");
                return;
            }
            else
            {
                dataGridView1.Rows.Add(txtKodeMk.Text, matakuliah.Text, sks.Text, kelompok.Text, comboBox1.Text, textBox5.Text, textBox6.Text, comboBox2.Text, txtJam.Text, textBox7.Text, txtkodeDosen.Text, textBox9.Text);
            }


            //matkul();
            //dosen();
            MessageBox.Show("data berhasil di simpan");
        }

        private void FormPenjadwalan_Load(object sender, EventArgs e)
        {
            
        }

        private void FormPenjadwalan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                txtKodeMk.Clear();
                matakuliah.Clear();
                sks.Clear();
                jenismk.Clear();
                kelompok.Clear();
                txtkodeDosen.Clear();
                textBox9.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                txtJam.Clear();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                txtKodeMk.Clear();
                matakuliah.Clear();
                sks.Clear();
                jenismk.Clear();
                kelompok.Clear();
                txtkodeDosen.Clear();
                textBox9.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                txtJam.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                txtKodeMk.Clear();
                matakuliah.Clear();
                sks.Clear();
                jenismk.Clear();
                kelompok.Clear();
                txtkodeDosen.Clear();
                textBox9.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                txtJam.Clear();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
               dataGridView1.Rows.Clear();
            }
        }
    }
}
