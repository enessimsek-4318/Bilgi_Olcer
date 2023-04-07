using Bilgi_Olcer_BLL.Absract;
using Bilgi_Olcer_DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_BLL.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private IQuestionDal _questionDal;
        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            return _questionDal.GetAll(filter).ToList();
        }

        public List<Question> GetQuestion(string subject)
        {
            return _questionDal.GetQuestion(subject);
        }

        public List<Question> GetSubject(int Id)
        {
            return _questionDal.GetSubject(Id);
        }
    }
}
