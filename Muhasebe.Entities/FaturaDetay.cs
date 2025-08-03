using System.Text.Json.Serialization;

namespace Muhasebe.Entities
{
    public class FaturaDetay
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        [JsonIgnore]
        public Fatura? Fatura { get; set; }
        [JsonIgnore]
        public Urun? Urun { get; set; }
    }
}