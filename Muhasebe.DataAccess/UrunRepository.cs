using System.Collections.Generic;
using System.Linq;
using Muhasebe.Core;
using Muhasebe.Entities;

namespace Muhasebe.DataAccess
{
    public class UrunRepository : IRepository<Urun>
    {
        private readonly MuhasebeContext _context;

        public UrunRepository(MuhasebeContext context)
        {
            _context = context;
        }

        public void Ekle(Urun entity)
        {
            _context.Urunler.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(Urun entity)
        {
            _context.Urunler.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(Urun entity)
        {
            _context.Urunler.Remove(entity);
            _context.SaveChanges();
        }

        public Urun Getir(int id)
        {
            return _context.Urunler.Find(id);
        }

        public List<Urun> Listele()
        {
            return _context.Urunler.ToList();
        }
    }
}