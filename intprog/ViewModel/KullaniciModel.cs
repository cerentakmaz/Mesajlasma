using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using intprog.Models;

namespace intprog.ViewModel
{
    public class KullaniciModel
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }
        public string Numara { get; set; }
    }
}