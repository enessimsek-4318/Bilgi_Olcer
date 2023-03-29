using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Result
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public int Correct { get; set; }
        public int False { get; set; }
        public int Empty { get; set; }
    }
}
