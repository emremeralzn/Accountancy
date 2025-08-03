using System.Collections.Generic;
using Muhasebe.DataAccess;
using Muhasebe.Entities;

namespace Muhasebe.Business
{
    public class StokHareketService
    {
        private readonly StokHareketRepository _repo;

        public StokHareketService(StokHareketRepository repo)
        {
            _repo = repo;
        }

        public void StokHareketEkle(StokHareket hareket) => _repo.Ekle(hareket);
        public void StokHareketGuncelle(StokHareket hareket) => _repo.Guncelle(hareket);
        public void StokHareketSil(StokHareket hareket) => _repo.Sil(hareket);
        public StokHareket StokHareketGetir(int id) => _repo.Getir(id);
        public List<StokHareket> StokHareketListele() => _repo.Listele();
    }
}