using System.Collections.Generic;
using System.Linq;
using Muhasebe.Core;
using Muhasebe.Entities;

namespace Muhasebe.DataAccess
{
    public class MusteriRepository : IRepository<Musteri>
    {
        private readonly MuhasebeContext _context;

        public MusteriRepository(MuhasebeContext context)
        {
            _context = context;
        }

        public void Ekle(Musteri entity)
        {
            _context.Musteriler.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(Musteri entity)
        {
            _context.Musteriler.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(Musteri entity)
        {
            _context.Musteriler.Remove(entity);
            _context.SaveChanges();
        }

        public Musteri Getir(int id)
        {
            return _context.Musteriler.Find(id);
        }

        public List<Musteri> Listele()
        {
            return _context.Musteriler.ToList();
        }
    }
}