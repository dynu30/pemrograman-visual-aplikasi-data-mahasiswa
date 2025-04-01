using System;

namespace aplikasidatamahasiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nama, prodi, pria, wanita, kelamin, lahir, tgllahir;
            nama = Convert.ToString(labelnama.Text);
            prodi = Convert.ToString(labelprodi.Text);
            pria = Convert.ToString(pilpria.Text);
            wanita = Convert.ToString(pilwanita.Text);

            if (pilpria.Checked == true)
            {
                kelamin = pria;
            }
            else if (pilwanita.Checked == true)
            {
                kelamin = wanita;
            }
            else
            {
                kelamin = "";
            }
            lahir = Convert.ToString(labeltmplahir.Text);
            tgllahir = Convert.ToString(labeltgllahir.Text);
            MessageBox.Show(
                $"Program Studi : {prodi} \n" +
                $"Nama Lengkap) : {nama} \n" +
                $"Jenis Kelamin : {kelamin} \n" +
                $"Tempat & Tgl Lahir : {lahir} / {tgllahir}", "Pesan", MessageBoxButtons.OK);
        }

        private void labelprodi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
