using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1
{
    public partial class FormUtama : Form
    {
        byte[] fotoMahasiswa;
        MahasiswaController controller = new MahasiswaController();

        public FormUtama()
        {
            InitializeComponent();
        }
        //button simpan//
        private void button1_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa
            {
                NPM = textBox6.Text,
                NamaLengkap = textBox1.Text,
                JenisKelamin = textBox2.Text,
                Kelas = textBox3.Text,
                ProgramStudi = textBox4.Text,
                TempatLahir = textBox5.Text,
                TanggalLahir = dateTimePicker1.Value.Date,
                Foto = fotoMahasiswa
            };

            controller.SimpanMahasiswa(mhs);
            MessageBox.Show("Data berhasil disimpan!");
        }

        //button load data//
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.TampilkanSemua();
        }

        //button update//
        private void button3_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa
            {
                NPM = textBox6.Text,
                NamaLengkap = textBox1.Text,
                JenisKelamin = textBox2.Text,
                Kelas = textBox3.Text,
                ProgramStudi = textBox4.Text,
                TempatLahir = textBox5.Text,
                TanggalLahir = dateTimePicker1.Value.Date
                // Tidak perlu foto
            };

            controller.UpdateMahasiswa(mhs);
            MessageBox.Show("Data berhasil diupdate!");
        }

        // button delete//
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Silakan isi NPM terlebih dahulu untuk menghapus data.");
                return;
            }

            controller.HapusMahasiswa(textBox6.Text);
            MessageBox.Show("Data berhasil dihapus!");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox6.Text = row.Cells["NPM"].Value.ToString();
                textBox1.Text = row.Cells["NamaLengkap"].Value.ToString();
                textBox2.Text = row.Cells["JenisKelamin"].Value.ToString();
                textBox3.Text = row.Cells["Kelas"].Value.ToString();
                textBox4.Text = row.Cells["ProgramStudi"].Value.ToString();
                textBox5.Text = row.Cells["TempatLahir"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["TanggalLahir"].Value);

                if (row.Cells["Foto"].Value != DBNull.Value)
                {
                    byte[] foto = (byte[])row.Cells["Foto"].Value;
                    using (MemoryStream ms = new MemoryStream(foto))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCari_Click_1(object sender, EventArgs e)
        {
            string keyword = textBoxCari.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Silakan masukkan Nama atau NPM untuk mencari data.");
                return;
            }

            dataGridView1.DataSource = controller.Cari(keyword);
        }

        private void btnuplod_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                fotoMahasiswa = File.ReadAllBytes(open.FileName); // simpan ke array byte
            }
        }
    }
}
