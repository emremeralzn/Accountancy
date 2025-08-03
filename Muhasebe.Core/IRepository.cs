using System.Collections.Generic;

namespace Muhasebe.Core
{
    public interface IRepository<T> where T : class
    {
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(T entity);
        T Getir(int id);
        List<T> Listele();
    }
}