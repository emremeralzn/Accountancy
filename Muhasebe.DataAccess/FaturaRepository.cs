using System.Collections.Generic;
using System.Linq;
using Muhasebe.Core;
using Muhasebe.Entities;
using Microsoft.EntityFrameworkCore;

namespace Muhasebe.DataAccess
{
    public class FaturaRepository : IRepository<Fatura>
    {
        private readonly MuhasebeContext _context;

        public FaturaRepository(MuhasebeContext context)
        {
            _context = context;
        }

        public void Ekle(Fatura entity)
        {
            _context.Faturalar.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(Fatura entity)
        {
            _context.Faturalar.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(Fatura entity)
        {
            _context.Faturalar.Remove(entity);
            _context.SaveChanges();
        }

        public Fatura Getir(int id)
        {
            return _context.Faturalar.Include(f => f.FaturaDetaylar).FirstOrDefault(f => f.Id == id);
        }

        public List<Fatura> Listele()
        {
            return _context.Faturalar.Include(f => f.FaturaDetaylar).ToList();
        }
    }
}