using EFCoreAssignment01.Contexts;
using EFCoreAssignment01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Repository
{
    public  class CourseRepository :Repository<Course>
    {
        public CourseRepository()
        {
            _dbSet = iTIDbContext.Set<Course>();
        }
        public void Delete(int Id)
        {
            var entity = _dbSet.Find(Id);
            try
            {

                if (entity == null) { throw new Exception("there is no like this Table"); }
                iTIDbContext.Remove(entity);

                iTIDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }



        public void Update(Course entity)
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
