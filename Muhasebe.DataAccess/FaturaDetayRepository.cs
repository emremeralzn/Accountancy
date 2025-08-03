using System.Collections.Generic;
using System.Linq;
using Muhasebe.Core;
using Muhasebe.Entities;
using Microsoft.EntityFrameworkCore;

namespace Muhasebe.DataAccess
{
    public class FaturaDetayRepository : IRepository<FaturaDetay>
    {
        private readonly MuhasebeContext _context;

        public FaturaDetayRepository(MuhasebeContext context)
        {
            _context = context;
        }

        public void Ekle(FaturaDetay entity)
        {
            _context.FaturaDetaylar.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(FaturaDetay entity)
        {
            _context.FaturaDetaylar.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(FaturaDetay entity)
        {
            _context.FaturaDetaylar.Remove(entity);
            _context.SaveChanges();
        }

        public FaturaDetay Getir(int id)
        {
            return _context.FaturaDetaylar.Include(fd => fd.Urun).FirstOrDefault(fd => fd.Id == id);
        }

        public List<FaturaDetay> Listele()
        {
            return _context.FaturaDetaylar.Include(fd => fd.Urun).ToList();
        }
    }
}