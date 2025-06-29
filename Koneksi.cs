using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Koneksi
    {
        private readonly string connectionString = @"Data Source=LAPTOP-DUA52BHV;Initial Catalog=db_Mahasiswa;TrustServerCertificate=True;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
