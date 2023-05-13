using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_BLL.Absract
{
    public interface IResultService
    {
        public void Save(Result entity);
        public List<Result> GetResult(string UserId);
        public Result Find(int Id);
        public void Delete(Result entity);
    }
}
