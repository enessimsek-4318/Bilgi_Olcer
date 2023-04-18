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
            using (var context=new DataContext())
            {
                context.Results.Add(entity);
            }
        }

        public void Delete(Result entity)
        {
            throw new NotImplementedException();
        }

        public Result Find(Expression<Func<Result, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Result> GetAll(Expression<Func<Result, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Result GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Result entity)
        {
            throw new NotImplementedException();
        }
    }
}
