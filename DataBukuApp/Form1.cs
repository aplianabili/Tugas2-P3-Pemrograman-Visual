using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DataBukuApp
{
    public partial class Form1 : Form
    {
        private BindingList<Buku> daftarBuku = new BindingList<Buku>(); // BindingList untuk auto-update DataGridView

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daftarBuku; // Hubungkan DataGridView dengan BindingList
            dataGridView1.AutoGenerateColumns = true; // Pastikan DataGridView bisa menampilkan data otomatis
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtJudul.Text) &&
                !string.IsNullOrWhiteSpace(txtPenulis.Text) &&
                !string.IsNullOrWhiteSpace(txtPenerbit.Text) &&
                !string.IsNullOrWhiteSpace(txtTahun.Text))
            {
                // Tambahkan buku ke daftar
                daftarBuku.Add(new Buku(txtJudul.Text, txtPenulis.Text, txtPenerbit.Text, txtTahun.Text));

                // Refresh DataGridView (seharusnya tidak perlu karena BindingList sudah otomatis update)
                dataGridView1.Refresh();

                // Bersihkan input setelah tambah data
                ClearFields();
            }
            else
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                daftarBuku.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                daftarBuku[index] = new Buku(txtJudul.Text, txtPenulis.Text, txtPenerbit.Text, txtTahun.Text);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Isi form dengan data dari baris yang dipilih
            if (e.RowIndex >= 0 && e.RowIndex < daftarBuku.Count)
            {
                txtJudul.Text = daftarBuku[e.RowIndex].Judul;
                txtPenulis.Text = daftarBuku[e.RowIndex].Penulis;
                txtPenerbit.Text = daftarBuku[e.RowIndex].Penerbit;
                txtTahun.Text = daftarBuku[e.RowIndex].Tahun;
            }
        }

        private void ClearFields()
        {
            txtJudul.Clear();
            txtPenulis.Clear();
            txtPenerbit.Clear();
            txtTahun.Clear();
        }

        // Jika tidak digunakan, event handler ini bisa dihapus dari designer
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Placeholder untuk event TextChanged
        }
    }

    public class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Penerbit { get; set; }
        public string Tahun { get; set; }

        public Buku(string judul, string penulis, string penerbit, string tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Penerbit = penerbit;
            Tahun = tahun;
        }
    }
}
