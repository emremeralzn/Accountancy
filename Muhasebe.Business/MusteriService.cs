using System.Collections.Generic;
using Muhasebe.DataAccess;
using Muhasebe.Entities;

namespace Muhasebe.Business
{
    public class MusteriService
    {
        private readonly MusteriRepository _repo;

        public MusteriService(MusteriRepository repo)
        {
            _repo = repo;
        }

        public void MusteriEkle(Musteri musteri) => _repo.Ekle(musteri);
        public void MusteriGuncelle(Musteri musteri) => _repo.Guncelle(musteri);
        public void MusteriSil(Musteri musteri) => _repo.Sil(musteri);
        public Musteri MusteriGetir(int id) => _repo.Getir(id);
        public List<Musteri> MusteriListele() => _repo.Listele();
    }
}