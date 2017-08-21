using SeferTasi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.BLL.Repository
{
    public abstract class RepositoryBase<T, ID> where T : class
    {
        protected internal static MyContext dbContext;
        public virtual List<T> GetAll()
        {
            dbContext = new MyContext(); //her zaman son halini kullanmak için newledik.
            return dbContext.Set<T>().ToList();
        }
        public virtual T GetByID(ID id)
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);
        }
        public virtual void Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                dbContext = new MyContext();
                throw ex;
            }
        }
        public virtual void Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Update()
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
