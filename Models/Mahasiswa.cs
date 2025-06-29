using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Mahasiswa
    {
        public string NPM { get; set; }
        public string NamaLengkap { get; set; }
        public string JenisKelamin { get; set; }
        public string Kelas { get; set; }
        public string ProgramStudi { get; set; }
        public string TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public byte[] Foto { get; set; }
    }
}
