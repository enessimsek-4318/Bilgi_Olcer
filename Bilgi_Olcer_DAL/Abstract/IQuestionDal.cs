using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_DAL.Abstract
{
    public interface IQuestionDal:IGenericRepository<Question>
    {
        List<Question> GetSubject(int id);
        List<Question> GetQuestion(string subject);
    }
}
