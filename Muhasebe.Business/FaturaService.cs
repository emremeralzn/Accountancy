using System.Collections.Generic;
using Muhasebe.DataAccess;
using Muhasebe.Entities;

namespace Muhasebe.Business
{
    public class FaturaService
    {
        private readonly FaturaRepository _repo;

        public FaturaService(FaturaRepository repo)
        {
            _repo = repo;
        }

        public void FaturaEkle(Fatura fatura) => _repo.Ekle(fatura);
        public void FaturaGuncelle(Fatura fatura) => _repo.Guncelle(fatura);
        public void FaturaSil(Fatura fatura) => _repo.Sil(fatura);
        public Fatura FaturaGetir(int id) => _repo.Getir(id);
        public List<Fatura> FaturaListele() => _repo.Listele();
    }
}