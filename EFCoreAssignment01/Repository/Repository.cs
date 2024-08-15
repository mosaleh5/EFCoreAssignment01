using EFCoreAssignment01.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected  ITIDbContext iTIDbContext;
        protected  DbSet<T> _dbSet;
        public Repository()
        {
            iTIDbContext = new ITIDbContext();
           
        }
        public void Add(T entity)
        {
            using(iTIDbContext)
            {
                iTIDbContext.Add(entity);
                iTIDbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            var entity = _dbSet.Find(Id);
            try
            {
                if (entity != null) { throw new Exception("there is no like this Table"); }
                iTIDbContext.Remove(entity);

                iTIDbContext.SaveChanges();
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);

            }
        }

     

        public void Update(T entity)
        {

           
            try
            {
                if (entity != null) { throw new Exception("there is no like this Table"); }
                iTIDbContext.Update(entity);

                iTIDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
