using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using intprog.Models;

namespace intprog.ViewModel
{
    public class GrupModel
    {
        public int GrupId { get; set; }

        public string GrupAdi { get; set; }

        public int? Kurucu { get; internal set; }
        public int? KullaniciId { get; internal set; }
    }
}