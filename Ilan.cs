using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayıpEvcilHayvanTakipSistemi
{
    public class Ilan
    {
        public int IlanID { get; set; }
        public int HayvanID { get; set; }
        public DateTime IlanTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}
