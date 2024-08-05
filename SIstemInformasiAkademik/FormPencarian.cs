using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemInformasiAkademik
{
    public partial class FormPencarian : Form
    {
        public FormPencarian()
        {
            InitializeComponent();
        }

        

        private void FormPencarian_Load(object sender, EventArgs e)
        {
            //Form ini digunakan untuk melakukan pencarian di semua form yang membutuhkan Data Yang fleksibel
        }

        private void dgvPencarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dgvPencarian_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FormPenjadwalan jadwal = new FormPenjadwalan();
           
            //autentikasi kode (Disesuaikan dengan kode yang dikirim ), saya disini menggunakan variabel untuk melakukan autentikasi jika angka 1 yang dikirim maka akan melakukan pencarian ke Cells Kode_mk
             if(auth.Text == "1")
            {
                jadwal.Show();
                string kode = dgvPencarian.Rows[e.RowIndex].Cells["Kode_mk"].Value.ToString();

                jadwal.txtKodeMk.Text = kode;
                this.Close();
                //disini jika kode autentikasi 2
            }else if(auth.Text == "2")
            {
                jadwal.Show();
                string kode = dgvPencarian.Rows[e.RowIndex].Cells["Kode_dosen"].Value.ToString() ;
                jadwal.txtkodeDosen.Text = kode;
                this.Close();
                jadwal.lblsimpan.Text = lblsimpan.Text;
            } 
          
        }

        private void dgvPencarian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
