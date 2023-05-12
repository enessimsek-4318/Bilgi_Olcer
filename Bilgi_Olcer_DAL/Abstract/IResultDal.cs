using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_DAL.Abstract
{
    public interface IResultDal:IGenericRepository<Result>
    {
        List<Result> GetResult(string id);
    }
}
