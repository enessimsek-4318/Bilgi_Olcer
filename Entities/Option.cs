using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Option
    {
        public int Id { get; set; }
        public string Option_A { get; set; }
        public string Option_B { get; set; }
        public string Option_C { get; set; }
        public string Option_D { get; set; }
        public string Option_E { get; set; }
        public string Answer { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
