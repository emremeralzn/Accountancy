using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.UI.Models
{
    public class StokHareketViewModel
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }  // API'de Urun -> Ad maplenmiş olacak
        public int Miktar { get; set; }
        public bool GirisMi { get; set; }
        public DateTime Tarih { get; set; }
    }

}

