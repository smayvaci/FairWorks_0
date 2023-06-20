using Project.BLL.DesignPatterns.SingletonPattern;
using Project.BLL.Repositories.IntRep;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {// burada contextimizin instancenı alarak ctor içerisine yazdık. Böylelikle singleton patterni burada kullanacağız.Repositorymizin bir kere instanceı alınmış olarak tekrar tekrar insantance alınmayacak.
        protected MyContext _db;
        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }
        protected void Save() //kaydetme metodumuz
        { 
            _db.SaveChanges();
        }
        public void Add(T item)// ekleme yapmak için kullanırız
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> list) // birden fazla nesneyi ekleme yapmak için kullanırız
        {
            _db.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp) // /belirli bir koşulu sağlayan en az bir nesne var mı diye kontrol etmek için kullanılır. Bunu database de eşleşme var mı diye kontrol etmek için kullanırsın onu düşün
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item) // veriyi pasife çekmek için kullanırız
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();


        }

        public void DeleteRange(List<T> list) // birden fazla veriyi pasife çekmek için kullanırız
        {
            foreach (T item in list) Delete(item);
        }

        public void Destroy(T item) // bir verinin databaseinden komple silinmesi için kullanırız.
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list) // birden fazla verinin databaseden komple silinmesi için kullanırız
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(params int[] id) // id üzerinden bir veriyi bulmamızı sağlar
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp) // bir classta ilk veya default değeri getirir
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()// aktif olan verileri getirir
        {
            return Where(x => x.DataStatus != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()// istenilen tüm verileri getirir
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetFirstDatas(int number) // ilk veriyi getirir
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetLastDatas(int number) // son veriyi getirir
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetModifieds() // güncellenen verilerin hepsini getirir
        {
            return Where(x => x.DataStatus == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassives() // pasif olan tüm verilerin hepsini getirir
        {
            return Where(x => x.DataStatus == ENTITIES.Enums.DataStatus.Deleted);
        }

        public object Select(Expression<Func<T, object>> exp) //object>> exp olmalı ki istediğimiz hale çevirebilelim T nesnesini object her türü içinde barındırır unutma. bool>>exp olsaydı filtreleme yaparken kullanabilirdik.
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp) //veri kaynağı üzerinde belirli bir dönüşüm veya özellik seçimi yapmak için kullanılır 
        {
            return _db.Set<T>().Select(exp);
        }

        public virtual void  Update(T item) // veriyi güncellemek için kullanılır
        {
            item.DataStatus = ENTITIES.Enums.DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            T toBeUpdated = Find(item.ID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdateRange(List<T> list) // birden fazla veriyi güncellemek için kullanılır
        {
            foreach (T item in list) Update(item);
        }

        public List<T> Where(Expression<Func<T, bool>> exp) //Where metodu, belirli bir koşulu sağlayan nesneleri filtrelemek için kullanılır ve sonuç olarak uygun koşulu sağlayan nesnelerin bir listesini döndürür.
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
