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
    public class AdminDal : IAdminDal
    {
        public void Create(Question entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Question entity)
        {
            throw new NotImplementedException();
        }

        public Question Find(Expression<Func<Question, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            using (var context=new DataContext())
            {
                return context.Questions.ToList();
            }
        }

        public Question GetById(int id)
        {
            using (var context=new DataContext())
            {
                return context.Questions.Find(id);
            }
        }

        public void Update(Question entity)
        {
            using (var context=new DataContext())
            {
                context.Questions.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
