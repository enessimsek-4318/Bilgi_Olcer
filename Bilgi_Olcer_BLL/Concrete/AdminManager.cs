using Bilgi_Olcer_BLL.Absract;
using Bilgi_Olcer_DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_BLL.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
    
        public void Create(Question entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Question entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Question entity)
        {
            throw new NotImplementedException();
        }

        public Question Get(int id)
        {
            return _adminDal.GetById(id);
        }

        public Question Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll()
        {
            return _adminDal.GetAll();
        }
    }
}
