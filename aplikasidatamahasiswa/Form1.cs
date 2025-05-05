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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=dbMahasiswa;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Mahasiswa (NPM, NamaLengkap, JenisKelamin, Kelas, ProgramStudi, TempatLahir, TanggalLahir) VALUES (@NPM, @NamaLengkap, @JenisKelamin, @Kelas, @ProgramStudi, @TempatLahir, @TanggalLahir)", con);
            cmd.Parameters.AddWithValue("@NPM", textBox6.Text);
            cmd.Parameters.AddWithValue("@NamaLengkap", textBox1.Text);
            cmd.Parameters.AddWithValue("@JenisKelamin", textBox2.Text);
            cmd.Parameters.AddWithValue("@Kelas", textBox3.Text);
            cmd.Parameters.AddWithValue("@ProgramStudi", textBox4.Text);
            cmd.Parameters.AddWithValue("@TempatLahir", textBox5.Text);
            cmd.Parameters.AddWithValue("@TanggalLahir", dateTimePicker1.Value.Date);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=dbMahasiswa;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mahasiswa", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=dbMahasiswa;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Mahasiswa SET NamaLengkap=@NamaLengkap, JenisKelamin=@JenisKelamin, Kelas=@Kelas, ProgramStudi=@ProgramStudi, TempatLahir=@TempatLahir, TanggalLahir=@TanggalLahir WHERE NPM=@NPM", con);
            cmd.Parameters.AddWithValue("@NPM", textBox6.Text);
            cmd.Parameters.AddWithValue("@NamaLengkap", textBox1.Text);
            cmd.Parameters.AddWithValue("@JenisKelamin", textBox2.Text);
            cmd.Parameters.AddWithValue("@Kelas", textBox3.Text);
            cmd.Parameters.AddWithValue("@ProgramStudi", textBox4.Text);
            cmd.Parameters.AddWithValue("@TempatLahir", textBox5.Text);
            cmd.Parameters.AddWithValue("@TanggalLahir", dateTimePicker1.Value.Date);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil diupdate!");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Silakan isi NPM terlebih dahulu untuk menghapus data.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=dbMahasiswa;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Mahasiswa WHERE NPM=@NPM", con);
            cmd.Parameters.AddWithValue("@NPM", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil dihapus!");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
