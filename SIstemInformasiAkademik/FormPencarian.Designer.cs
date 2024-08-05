namespace SIstemInformasiAkademik
{
    partial class FormPencarian
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.comboboxPencarian = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPencarian = new System.Windows.Forms.DataGridView();
            this.auth = new System.Windows.Forms.Label();
            this.lblsimpan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPencarian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPencarian);
            this.groupBox1.Controls.Add(this.comboboxPencarian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(254, 41);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(155, 20);
            this.txtPencarian.TabIndex = 2;
            // 
            // comboboxPencarian
            // 
            this.comboboxPencarian.FormattingEnabled = true;
            this.comboboxPencarian.Location = new System.Drawing.Point(127, 41);
            this.comboboxPencarian.Name = "comboboxPencarian";
            this.comboboxPencarian.Size = new System.Drawing.Size(121, 21);
            this.comboboxPencarian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan";
            // 
            // dgvPencarian
            // 
            this.dgvPencarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPencarian.Location = new System.Drawing.Point(25, 120);
            this.dgvPencarian.Name = "dgvPencarian";
            this.dgvPencarian.Size = new System.Drawing.Size(567, 223);
            this.dgvPencarian.TabIndex = 1;
            this.dgvPencarian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPencarian_CellClick);
            this.dgvPencarian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPencarian_CellContentClick);
            this.dgvPencarian.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPencarian_CellDoubleClick);
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Location = new System.Drawing.Point(599, 32);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(0, 13);
            this.auth.TabIndex = 2;
            // 
            // lblsimpan
            // 
            this.lblsimpan.AutoSize = true;
            this.lblsimpan.Location = new System.Drawing.Point(323, 179);
            this.lblsimpan.Name = "lblsimpan";
            this.lblsimpan.Size = new System.Drawing.Size(0, 13);
            this.lblsimpan.TabIndex = 29;
            // 
            // FormPencarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 371);
            this.Controls.Add(this.lblsimpan);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.dgvPencarian);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPencarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPencarian";
            this.Load += new System.EventHandler(this.FormPencarian_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPencarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboboxPencarian;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvPencarian;
        public System.Windows.Forms.TextBox txtPencarian;
        public System.Windows.Forms.Label auth;
        public System.Windows.Forms.Label lblsimpan;
    }
}