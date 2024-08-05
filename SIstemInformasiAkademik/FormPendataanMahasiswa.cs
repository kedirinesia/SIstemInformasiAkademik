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
    public partial class FormPendataanMahasiswa : Form
    {
        public FormPendataanMahasiswa()
        {
            InitializeComponent();
        }


        //Query untuk melakukan GET DatagridVIew Dari Database

        void dgv()
        {
            DataTable dataTable = new DataTable();
     dataTable = (DataTable)       Connection.getQuery("select * from mahasiswa");
            dataGridView1.DataSource = dataTable;

        }

        //method untuk clear
        public  void clear()
        {
            txtNim.Clear();
            txtAlamat.Clear();
            txtKota.Clear();
            txtNama.Clear();
            txtPassword.Clear();
            txtTempatLahir.Clear();
            ComboboxAgama.Text = "";
            Telp.Clear();
            Ipk.Clear();
            txtNimUpdate.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //menonaktifkan button dan textBox
            txtNim.Focus();
            txtNimUpdate.Visible = false;
            btnSimpanUpdate.Visible = false;
        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {
            //melakukan autentikasi data jika nim yang diisikan sudah ada maka akan menampilkan data sudah ada dan menghentikan operasi
            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from mahasiswa where nim = '"+txtNim.Text+"'",conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("data sudah ada");
                clear();
                return ;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //kembali ke FormMenuUtama
            FormMenuUtama utama = new FormMenuUtama();
            utama.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //membuat variable agar bisa dipanggil dengan mudah untuk query yang lebih mudah
            string gender = null;
            if (radioButton1.Checked)
            {
                 gender = "L";
            }
            else if (radioButton2.Checked)
            {
                 gender = "P"; 
            }
            string datetime = dateTimePicker1.Value.ToString();




            //query insert ke tabel mahasiswa
            Connection.Exquery("insert into mahasiswa values('"+txtNim.Text+"', '"+txtNama.Text+"', '"+txtAlamat.Text+"', '"+txtKota.Text+"', '"+txtTempatLahir.Text+ "', '1998-10-19' , '" + gender+"', '"+ComboboxAgama.Text+"', '"+Telp.Text+"', '"+Ipk.Text+"', '"+KodeProdgi.Text+"', '"+StatusRegistrasi.Text+"', '"+Akademik.Text+"', '"+txtPassword.Text+"')");
            //refresh datagridview
            dgv();
            //pesan berhasil
            MessageBox.Show("data berhasil di simpan");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormPendataanMahasiswa_Load(object sender, EventArgs e)
        {
            //query untuk comboboxKodeProdgi
            DataTable dt = new DataTable();

           Object query =  Connection.getQuery("select * from program_studi");
            KodeProdgi.Items.Add(query);    
            //mematikan btnhapus ketika Form Dibuka
            btnhapus.Enabled = false;
            //refresh
            dgv();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //melakukan clear
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mengaktifakn txt dan btn, sekaligus melakukan fokus
            txtNimUpdate.Visible = true;
            btnSimpanUpdate.Visible = true;
            btnhapus.Enabled = true;
            txtNim.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ketika  button pencarian di klik dan textbox ada isinya maka melakukan pencarian ke database dan langsung di tampilkan ke datagridview
            DataTable dt = new DataTable();
            dt = (DataTable)Connection.getQuery("select * from mahasiswa where nama like '%"+textBox5.Text+"%'");
            dataGridView1.DataSource=dt;
        }

        private void btnSimpanUpdate_Click(object sender, EventArgs e)
        {
            //query untuk melakukan simpan data
            dateTimePicker1.Text = "(yy/mm/dd)";
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = "L";
            }
            else if (radioButton2.Checked)
            {
                gender = "P";
            }
            Connection.Exquery("update mahasiswa set  nama= '"+txtNama.Text+"', Alamat_asal = '"+txtAlamat.Text+"',kota_asal= '"+txtKota.Text+ "',Tempat_lahir= '"+txtTempatLahir.Text+ "',Tanggal_lahir= '1998-10 -19',Jenis_Kel= '" + gender+ "',Agama= '" + ComboboxAgama.Text+ "',Telp= '" + Telp.Text+ "',IPK= '" + Ipk.Text+ "',Kode_prodgi= '" + KodeProdgi.Text+ "',Status_reg= '" + StatusRegistrasi.Text+ "',Status_akd= '" + Akademik.Text+ "', Password='" + txtPassword.Text+"' where nim = '" + txtNim.Text+"'");
            dgv();
            MessageBox.Show("berhasil melakukan update");
        }

        private void txtNimUpdate_TextChanged(object sender, EventArgs e)
        {
            
            //melakukan autentikasi nim, ketika button update ditekan dan user mengisi nim dan ternyata data nya ada maka langsung mengisi textbox di form sesuai dengan tempat nya seperti nama = nama 
          

            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from mahasiswa where nim = '" + txtNimUpdate.Text + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtNama.Text = rd["Nama"].ToString();
                txtAlamat.Text = rd["alamat_asal"].ToString() ;
                txtKota.Text = rd["Kota_asal"].ToString() ;
                txtTempatLahir.Text = rd["Tempat_lahir"].ToString() ;
                dateTimePicker1.Text = rd["Tanggal_lahir"].ToString() ;
                ComboboxAgama.Text = rd["Agama"].ToString() ;
                Telp.Text = rd["Telp"].ToString() ;
                Ipk.Text = rd["IPK"].ToString() ;
                KodeProdgi.Text = rd["Kode_prodgi"].ToString() ;
                StatusRegistrasi.Text = rd["Status_reg"].ToString() ;
                Akademik.Text = rd["Status_akd"].ToString() ;
                txtPassword.Text = rd["Password"].ToString() ;
                //txtAlamat.Text = rd[""].ToString() ;
            }
            else
            {
                MessageBox.Show("data tidak ditemukan");
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            //query untuk melakukan penghapusan data dari tabel Mahasiswa     
            Connection.Exquery(" delete from Mahasiswa where NIM = '"+txtNim.Text+"'");
            MessageBox.Show("Data Berhasil Dihapus");
            dgv();
            clear();
        }
    }
}
