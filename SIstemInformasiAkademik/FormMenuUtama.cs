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
    public partial class FormMenuUtama : Form
    {
        private int childFormNumber = 0;

        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //bawaan Template MDI
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //bawaan Template MDI
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bawaan Template MDI
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //menutup form
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bawaan Template MDI
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bawaan Template MDI
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bawaan Template MDI
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bawaan Template MDI
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bawaan Template MDI
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            //untuk menampilkan Tanggal Dan Jam
            DateTime dateTime = DateTime.Now;
            toolStripStatusLabel1.Text = dateTime.ToString();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //untuk masuk ke FormPendataanMahasiswa
            FormPendataanMahasiswa mahasiswa = new FormPendataanMahasiswa();
            mahasiswa.Show();
            this.Close();
        }

        private void matakuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //masuk ke FormPendataanMatakuliah
            FormPendataanMataKuliah mataKuliah = new FormPendataanMataKuliah();
            mataKuliah.Show();
            this.Close();
        }

        private void dosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void penjadwalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //masuk ke FormPenjadwalan
            FormPenjadwalan jadwal = new FormPenjadwalan();
            jadwal.Show();
            this.Close();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kembali ke loginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
