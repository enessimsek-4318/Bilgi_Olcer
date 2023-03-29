using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Grade { get; set; }
        public string Lesson { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string PhotoUrl { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }
        public string Answer { get; set; }
    }
}
