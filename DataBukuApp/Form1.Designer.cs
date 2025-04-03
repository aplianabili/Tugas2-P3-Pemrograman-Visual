namespace DataBukuApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPenulis;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.Label lblTahun;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPenulis = new System.Windows.Forms.Label();
            this.lblPenerbit = new System.Windows.Forms.Label();
            this.lblTahun = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // Labels
            this.lblJudul.Location = new System.Drawing.Point(12, 220);
            this.lblJudul.Size = new System.Drawing.Size(100, 23);
            this.lblJudul.Text = "Judul Buku:";

            this.lblPenulis.Location = new System.Drawing.Point(12, 250);
            this.lblPenulis.Size = new System.Drawing.Size(100, 23);
            this.lblPenulis.Text = "Penulis:";

            this.lblPenerbit.Location = new System.Drawing.Point(12, 280);
            this.lblPenerbit.Size = new System.Drawing.Size(100, 23);
            this.lblPenerbit.Text = "Penerbit:";

            this.lblTahun.Location = new System.Drawing.Point(12, 310);
            this.lblTahun.Size = new System.Drawing.Size(100, 23);
            this.lblTahun.Text = "Tahun Terbit:";

            // TextBox
            this.txtJudul.Location = new System.Drawing.Point(120, 220);
            this.txtPenulis.Location = new System.Drawing.Point(120, 250);
            this.txtPenerbit.Location = new System.Drawing.Point(120, 280);
            this.txtTahun.Location = new System.Drawing.Point(120, 310);

            // Buttons
            this.btnTambah.Location = new System.Drawing.Point(250, 220);
            this.btnTambah.Size = new System.Drawing.Size(100, 23);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            this.btnEdit.Location = new System.Drawing.Point(250, 250);
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnHapus.Location = new System.Drawing.Point(250, 280);
            this.btnHapus.Size = new System.Drawing.Size(100, 23);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // Add Controls to Form
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPenulis);
            this.Controls.Add(this.lblPenerbit);
            this.Controls.Add(this.lblTahun);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Aplikasi Data Buku";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
