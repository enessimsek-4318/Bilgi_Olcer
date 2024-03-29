﻿using Bilgi_Olcer_BLL.Absract;
using Bilgi_Olcer_DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_BLL.Concrete
{
    public class ResultManager : IResultService
    {
        private IResultDal _resultDal;
        public ResultManager(IResultDal resultDal)
        {
            _resultDal = resultDal;
        }

        public void Delete(Result entity)
        {
            _resultDal.Delete(entity);
        }

        public Result Find(int Id)
        {
            return _resultDal.Find(Id);
        }

        public List<Result> GetResult(string UserId)
        {
            return _resultDal.GetResult(UserId);
        }

        public void Save(Result entity)
        {
             _resultDal.Create(entity);
        }
    }
}
