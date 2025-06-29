using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using ClosedXML.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1
{
    public partial class lihatdata : Form
    {
        private readonly LihatDataController controller = new LihatDataController();

        public lihatdata()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string keyword = textBoxCari.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Silakan masukkan Nama atau NPM untuk mencari data.");
                return;
            }

            dataGridView1.DataSource = controller.Cari(keyword);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk didownload.");
                return;
            }

            // Pilih folder tujuan
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Pilih folder untuk menyimpan file Excel";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                    string filePath = Path.Combine(folderPath, "DataMahasiswa.xlsx");

                    try
                    {
                        // Membuat workbook Excel
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            DataTable dt = (DataTable)dataGridView1.DataSource;
                            wb.Worksheets.Add(dt, "Mahasiswa");
                            wb.SaveAs(filePath);
                        }

                        MessageBox.Show("Data berhasil didownload ke: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menyimpan file: " + ex.Message);
                    }
                }
            }
        }
    }
}
