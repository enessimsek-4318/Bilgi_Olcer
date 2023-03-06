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
        public string QText { get; set; }
        public string Image { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }

    }
}
