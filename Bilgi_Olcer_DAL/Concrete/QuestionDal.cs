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
    public class QuestionDal : IQuestionDal
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
            throw new NotImplementedException();
        }

        public List<Question> GetSubject(int id)
        {
            using (var context=new DataContext())
            {
                 return context.Questions.Where(i => i.Grade == id.ToString()).ToList();
            }
        }

        public Question GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
