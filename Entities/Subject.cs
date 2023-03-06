using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public int QuestionId { get; set; }
        public List<Question> Question { get; set; }

    }
}
