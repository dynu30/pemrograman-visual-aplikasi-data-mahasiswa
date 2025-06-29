using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class MahasiswaController
    {
        private CollectionData data = new CollectionData();

        public void SimpanMahasiswa(Mahasiswa mhs)
        {
            data.InsertMahasiswa(mhs.NPM, mhs.NamaLengkap, mhs.JenisKelamin, mhs.Kelas,
                                  mhs.ProgramStudi, mhs.TempatLahir, mhs.TanggalLahir, mhs.Foto);
        }

        public void UpdateMahasiswa(Mahasiswa mhs)
        {
            data.UpdateMahasiswa(mhs.NPM, mhs.NamaLengkap, mhs.JenisKelamin, mhs.Kelas,
                                  mhs.ProgramStudi, mhs.TempatLahir, mhs.TanggalLahir);
        }

        public void HapusMahasiswa(string npm)
        {
            data.DeleteMahasiswa(npm);
        }

        public DataTable TampilkanSemua()
        {
            return data.GetAllMahasiswa();
        }

        public DataTable Cari(string keyword)
        {
            return data.SearchMahasiswa(keyword);
        }
    }
}
