﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Uye
    {
        public int ID { get; set; }

        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public string KullaniciAdi { get; set; }

        public string Mail { get; set; }

        public string Sifre { get; set; }

        public DateTime KayitTarih { get; set; }

        public bool Durum { get; set; }
    }
}
