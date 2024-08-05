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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIstemInformasiAkademik
{
    public partial class FormPendataanMataKuliah : Form
    {
        public FormPendataanMataKuliah()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtKodeMataKuliah.Clear();
            txtnama.Clear();
            Jenis.Text = "";
            kodeProdgi.Text = "";
            sks.Clear();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = (DataTable)Connection.getQuery("select * from matakuliah where nama_mk like '%" + Cari.Text + "%'");
            dataGridView1.DataSource = dt;
        }

        void dgv()
        {
            DataTable dt = new DataTable();

            dt = (DataTable)Connection.getQuery("select * from matakuliah");
            dataGridView1.DataSource = dt;
        }

        private void FormPendataanMataKuliah_Load(object sender, EventArgs e)
        {
            dgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnHapus.Enabled = false;
            btnSimpanUpdate.Enabled = false;
             
            button3.Enabled = true;
            btnSimpanUpdate.Visible = false;
            
            txtKodeMataKuliah.Focus();
        }

        private void txtKodeMataKuliah_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from matakuliah where kode_mk = '" + txtKodeMataKuliah.Text + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("data sudah ada");
                clear();
                return;
            }else if (txtKodeMataKuliah.Text == "")
            {
                clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection.Exquery("insert into matakuliah values ('" + txtKodeMataKuliah.Text + "', '" + txtnama.Text + "', '" + Jenis.Text + "', '" + sks.Text + "', '" + kodeProdgi.Text + "')");
            dataGridView1.Rows.Add(kodeProdgi.Text);
            MessageBox.Show("berhasil melakukan simpan");
            dgv();
            clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenuUtama utama = new FormMenuUtama();
            utama.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            btnHapus.Enabled = true;
            txtSimpanUpdate.Visible = true;
            btnSimpanUpdate.Visible = true;
            txtSimpanUpdate.Focus();

        }

        private void btnSimpanUpdate_Click(object sender, EventArgs e)
        {
            Connection.Exquery("update matakuliah set  nama_mk= '" + txtnama.Text + "', jenis_mk= sks= '" + Jenis.Text + "', kode_progdi='" + sks.Text + "' , kode_progdi ='" + kodeProdgi.Text + "' where  kode_mk= '" + txtKodeMataKuliah.Text + "'");

            dgv();
            MessageBox.Show("berhasil melakukan ubah");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Connection.Exquery("delete from matakuliah where kode_mk='" + txtKodeMataKuliah.Text + "'");
            dgv();
            MessageBox.Show("data berhasil di hapus");
        }

        private void txtSimpanUpdate_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from matakuliah where kode_mk = '" + txtSimpanUpdate.Text + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtnama.Text = rd["Nama_mk"].ToString();
                Jenis.Text = rd["Jenis_mk"].ToString();
                sks.Text = rd["SKS"].ToString();
                kodeProdgi.Text = rd["Kode_progdi"].ToString();
            }else if (txtSimpanUpdate.Text == "")
            {
                clear();
            }
            else
            {
                MessageBox.Show("data tidak ada");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
