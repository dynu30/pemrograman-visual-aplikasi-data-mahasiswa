using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class LihatDataController
    {
        private CollectionData data = new CollectionData();

        public DataTable GetAll()
        {
            return data.GetAllMahasiswa();
        }

        public DataTable Cari(string keyword)
        {
            return data.SearchMahasiswa(keyword);
        }
    }
}

