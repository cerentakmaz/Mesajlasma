using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using intprog.Models;

namespace intprog.ViewModel
{
    public class MesajModel
    {
        public int MesajId { get; set; }
        public string Mesaj1 { get; set; }
        public int? Gönderen { get; internal set; }
    }
}