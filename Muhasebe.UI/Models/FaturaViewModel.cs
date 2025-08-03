using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.UI.Models
{
    public class FaturaViewModel
    {
        public int Id { get; set; }
        public string MusteriAdSoyad { get; set; }
        public DateTime Tarih { get; set; }
        public decimal ToplamTutar { get; set; }
        public List<FaturaDetayViewModel> Detaylar { get; set; }
    }

}
