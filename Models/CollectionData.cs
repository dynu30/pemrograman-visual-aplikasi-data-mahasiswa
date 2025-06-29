using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CollectionData
    {
        private readonly SqlConnection _connection;

        public CollectionData()
        {
            Koneksi koneksi = new Koneksi();
            _connection = koneksi.GetConnection();
        }

        public void InsertMahasiswa(string npm, string nama, string jk, string kelas, string prodi, string tempatLahir, DateTime tglLahir, byte[] foto)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Mahasiswa (NPM, NamaLengkap, JenisKelamin, Kelas, ProgramStudi, TempatLahir, TanggalLahir, Foto) " +
                "VALUES (@NPM, @NamaLengkap, @JenisKelamin, @Kelas, @ProgramStudi, @TempatLahir, @TanggalLahir, @Foto)", _connection))
            {
                cmd.Parameters.AddWithValue("@NPM", npm);
                cmd.Parameters.AddWithValue("@NamaLengkap", nama);
                cmd.Parameters.AddWithValue("@JenisKelamin", jk);
                cmd.Parameters.AddWithValue("@Kelas", kelas);
                cmd.Parameters.AddWithValue("@ProgramStudi", prodi);
                cmd.Parameters.AddWithValue("@TempatLahir", tempatLahir);
                cmd.Parameters.AddWithValue("@TanggalLahir", tglLahir);
                cmd.Parameters.AddWithValue("@Foto", foto ?? (object)DBNull.Value);

                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void UpdateMahasiswa(string npm, string nama, string jk, string kelas, string prodi, string tempatLahir, DateTime tglLahir)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Mahasiswa SET NamaLengkap=@NamaLengkap, JenisKelamin=@JenisKelamin, Kelas=@Kelas, ProgramStudi=@ProgramStudi, TempatLahir=@TempatLahir, TanggalLahir=@TanggalLahir WHERE NPM=@NPM", _connection))
            {
                cmd.Parameters.AddWithValue("@NPM", npm);
                cmd.Parameters.AddWithValue("@NamaLengkap", nama);
                cmd.Parameters.AddWithValue("@JenisKelamin", jk);
                cmd.Parameters.AddWithValue("@Kelas", kelas);
                cmd.Parameters.AddWithValue("@ProgramStudi", prodi);
                cmd.Parameters.AddWithValue("@TempatLahir", tempatLahir);
                cmd.Parameters.AddWithValue("@TanggalLahir", tglLahir);

                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void DeleteMahasiswa(string npm)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Mahasiswa WHERE NPM=@NPM", _connection))
            {
                cmd.Parameters.AddWithValue("@NPM", npm);

                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public DataTable GetAllMahasiswa()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Mahasiswa", _connection))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public DataTable SearchMahasiswa(string keyword)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Mahasiswa WHERE NamaLengkap LIKE @keyword OR NPM LIKE @keyword", _connection))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
    }

}
