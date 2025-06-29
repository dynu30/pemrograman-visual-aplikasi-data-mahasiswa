using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnMenuUtama_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama(); // Buat instance Form2
            formUtama.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            lihatdata lihatdata = new lihatdata(); // Buat instance Form2
            lihatdata.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
