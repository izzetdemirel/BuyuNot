using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Yorum
    {
        public int ID { get; set; }

        public int Notlar_ID { get; set; }

        public string Notlar{ get; set; }

        public int Uye_ID { get; set; }

        public string Uye { get; set; }

        public int Yonetici_ID { get; set; }

        public string Yonetici { get; set; }

        public string Icerik { get; set; }

        public DateTime YorumTarihi { get; set; }

        public DateTime YorumTarihiStr { get; set; }

        public bool Durum { get; set; }


    }
}
