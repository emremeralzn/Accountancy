using System;
using System.Text.Json.Serialization;

namespace Muhasebe.Entities
{
    public class StokHareket
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public bool GirisMi { get; set; } // true: giriş, false: çıkış
        public DateTime Tarih { get; set; }

        [JsonIgnore]
        public Urun? Urun { get; set; }
    }
}