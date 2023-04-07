using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_BLL.Absract
{
    public interface IQuestionService
    {
        List<Question> GetAll(Expression<Func<Question, bool>> filter = null);
        List<Question> GetSubject(int Id);
        List<Question> GetQuestion(string subject);

    }
}
