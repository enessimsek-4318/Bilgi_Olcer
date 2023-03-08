using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Exam
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TestId { get; set; }
        public List<Test> Test { get; set; }
        public int GradeId { get; set; }
        public List<Grade> Grade { get; set; }
    }
}
