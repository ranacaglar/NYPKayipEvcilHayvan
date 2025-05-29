using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayıpEvcilHayvanTakipSistemi
{
    public class Hayvan
    {
        public int HayvanID { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public string Renk { get; set; }
        public DateTime KaybolmaTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public int SahipID { get; set; }
    }
}
