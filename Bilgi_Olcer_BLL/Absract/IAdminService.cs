using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_BLL.Absract
{
    public interface IAdminService
    {
        void Create(Question entity);
        void Edit(Question entity);
        void Delete(Question entity);
        Question Get(int id);
        List<Question> GetAll();
    }
}
