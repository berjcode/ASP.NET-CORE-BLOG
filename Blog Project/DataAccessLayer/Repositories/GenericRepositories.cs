using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {

        Context c = new Context();
        public void Delete(T t)
        {
            //using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            //  using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
           // using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
           // using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }


        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            //Filter'dan gelen değeri listele
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
           // using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
