using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Muhasebe.Entities
{
    public class Fatura
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal ToplamTutar { get; set; }

        [JsonIgnore]
        public Musteri? Musteri { get; set; }
        [JsonIgnore]
        public List<FaturaDetay>? FaturaDetaylar { get; set; }
    }
}