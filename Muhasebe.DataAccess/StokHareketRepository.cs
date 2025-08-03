using System.Collections.Generic;
using System.Linq;
using Muhasebe.Core;
using Muhasebe.Entities;
using Microsoft.EntityFrameworkCore;

namespace Muhasebe.DataAccess
{
    public class StokHareketRepository : IRepository<StokHareket>
    {
        private readonly MuhasebeContext _context;

        public StokHareketRepository(MuhasebeContext context)
        {
            _context = context;
        }

        public void Ekle(StokHareket entity)
        {
            _context.StokHareketler.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(StokHareket entity)
        {
            _context.StokHareketler.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(StokHareket entity)
        {
            _context.StokHareketler.Remove(entity);
            _context.SaveChanges();
        }

        public StokHareket Getir(int id)
        {
            return _context.StokHareketler.Include(sh => sh.Urun).FirstOrDefault(sh => sh.Id == id);
        }

        public List<StokHareket> Listele()
        {
            return _context.StokHareketler.Include(sh => sh.Urun).ToList();
        }
    }
}