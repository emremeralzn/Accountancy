using System.Collections.Generic;
using Muhasebe.DataAccess;
using Muhasebe.Entities;

namespace Muhasebe.Business
{
    public class UrunService
    {
        private readonly UrunRepository _repo;

        public UrunService(UrunRepository repo)
        {
            _repo = repo;
        }

        public void UrunEkle(Urun urun) => _repo.Ekle(urun);
        public void UrunGuncelle(Urun urun) => _repo.Guncelle(urun);
        public void UrunSil(Urun urun) => _repo.Sil(urun);
        public Urun UrunGetir(int id) => _repo.Getir(id);
        public List<Urun> UrunListele() => _repo.Listele();
    }
}