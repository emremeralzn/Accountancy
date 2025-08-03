using System.Collections.Generic;
using Muhasebe.DataAccess;
using Muhasebe.Entities;

namespace Muhasebe.Business
{
    public class FaturaDetayService
    {
        private readonly FaturaDetayRepository _repo;

        public FaturaDetayService(FaturaDetayRepository repo)
        {
            _repo = repo;
        }

        public void FaturaDetayEkle(FaturaDetay detay) => _repo.Ekle(detay);
        public void FaturaDetayGuncelle(FaturaDetay detay) => _repo.Guncelle(detay);
        public void FaturaDetaySil(FaturaDetay detay) => _repo.Sil(detay);
        public FaturaDetay FaturaDetayGetir(int id) => _repo.Getir(id);
        public List<FaturaDetay> FaturaDetayListele() => _repo.Listele();
    }
}