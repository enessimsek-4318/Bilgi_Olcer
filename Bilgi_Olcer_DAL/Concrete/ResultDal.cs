using Bilgi_Olcer_DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_DAL.Concrete
{
    public class ResultDal : IResultDal
    {
        public void Create(Result entity)
        {
            try
            {
                using (var context = new DataContext())
                {
                    context.Results.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Delete(Result entity)
        {
            try
            {
                using (var context = new DataContext())
                {
                    context.Results.Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Result Find(int Id)
        {
            using (var context=new DataContext())
            {
                return context.Results.FirstOrDefault(i => i.Id == Id);
            }
        }

        public List<Result> GetAll(Expression<Func<Result, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Result GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Result> GetResult(string id)
        {
            using (var context=new DataContext())
            {
                return context.Results.Where(i => i.userId == id).ToList();
            }
        }

        public void Update(Result entity)
        {
            throw new NotImplementedException();
        }
    }
}
