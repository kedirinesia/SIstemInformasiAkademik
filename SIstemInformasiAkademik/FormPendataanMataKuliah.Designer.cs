namespace SIstemInformasiAkademik
{
    partial class FormPendataanMataKuliah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSimpanUpdate = new System.Windows.Forms.TextBox();
            this.kodeProdgi = new System.Windows.Forms.ComboBox();
            this.Jenis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodeMataKuliah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncari = new System.Windows.Forms.Button();
            this.Cari = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSimpanUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(662, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 32);
            this.button6.TabIndex = 47;
            this.button6.Text = "Keluar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(415, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 32);
            this.button5.TabIndex = 46;
            this.button5.Text = "Batal";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Enabled = false;
            this.btnHapus.Location = new System.Drawing.Point(314, 377);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(95, 32);
            this.btnHapus.TabIndex = 45;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 44;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 43;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 373);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSimpanUpdate);
            this.tabPage1.Controls.Add(this.kodeProdgi);
            this.tabPage1.Controls.Add(this.Jenis);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.sks);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnama);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtKodeMataKuliah);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSimpanUpdate
            // 
            this.txtSimpanUpdate.Location = new System.Drawing.Point(112, 29);
            this.txtSimpanUpdate.Name = "txtSimpanUpdate";
            this.txtSimpanUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtSimpanUpdate.TabIndex = 11;
            this.txtSimpanUpdate.Visible = false;
            this.txtSimpanUpdate.TextChanged += new System.EventHandler(this.txtSimpanUpdate_TextChanged);
            // 
            // kodeProdgi
            // 
            this.kodeProdgi.FormattingEnabled = true;
            this.kodeProdgi.Items.AddRange(new object[] {
            "PR001",
            "PR002"});
            this.kodeProdgi.Location = new System.Drawing.Point(112, 137);
            this.kodeProdgi.Name = "kodeProdgi";
            this.kodeProdgi.Size = new System.Drawing.Size(121, 21);
            this.kodeProdgi.TabIndex = 10;
            // 
            // Jenis
            // 
            this.Jenis.FormattingEnabled = true;
            this.Jenis.Items.AddRange(new object[] {
            "T",
            "P",
            "TP"});
            this.Jenis.Location = new System.Drawing.Point(112, 81);
            this.Jenis.Name = "Jenis";
            this.Jenis.Size = new System.Drawing.Size(121, 21);
            this.Jenis.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kode Prodgi";
            // 
            // sks
            // 
            this.sks.Location = new System.Drawing.Point(112, 107);
            this.sks.Name = "sks";
            this.sks.Size = new System.Drawing.Size(100, 20);
            this.sks.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jenis";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(112, 55);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(100, 20);
            this.txtnama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // txtKodeMataKuliah
            // 
            this.txtKodeMataKuliah.Location = new System.Drawing.Point(112, 29);
            this.txtKodeMataKuliah.Name = "txtKodeMataKuliah";
            this.txtKodeMataKuliah.Size = new System.Drawing.Size(100, 20);
            this.txtKodeMataKuliah.TabIndex = 1;
            this.txtKodeMataKuliah.TextChanged += new System.EventHandler(this.txtKodeMataKuliah_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Matakuliah";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btncari);
            this.tabPage2.Controls.Add(this.Cari);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Display Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(309, 309);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(75, 23);
            this.btncari.TabIndex = 3;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // Cari
            // 
            this.Cari.Location = new System.Drawing.Point(107, 309);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(196, 20);
            this.Cari.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Cari Nama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSimpanUpdate
            // 
            this.btnSimpanUpdate.Location = new System.Drawing.Point(213, 377);
            this.btnSimpanUpdate.Name = "btnSimpanUpdate";
            this.btnSimpanUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnSimpanUpdate.TabIndex = 48;
            this.btnSimpanUpdate.Text = "Simpan";
            this.btnSimpanUpdate.UseVisualStyleBackColor = true;
            this.btnSimpanUpdate.Click += new System.EventHandler(this.btnSimpanUpdate_Click);
            // 
            // FormPendataanMataKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 420);
            this.Controls.Add(this.btnSimpanUpdate);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPendataanMataKuliah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPendataanMataKuliah";
            this.Load += new System.EventHandler(this.FormPendataanMataKuliah_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKodeMataKuliah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.TextBox Cari;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox kodeProdgi;
        private System.Windows.Forms.ComboBox Jenis;
        private System.Windows.Forms.TextBox txtSimpanUpdate;
        private System.Windows.Forms.Button btnSimpanUpdate;
    }
}