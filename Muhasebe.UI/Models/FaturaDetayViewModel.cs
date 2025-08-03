using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.UI.Models
{
    public class FaturaDetayViewModel
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }   // BUNU EKLE
        public int UrunId { get; set; }     // BUNU EKLE
        public string UrunAd { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar => Miktar * BirimFiyat;
    }



}
