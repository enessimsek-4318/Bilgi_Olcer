using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GradeLesson
    {
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
