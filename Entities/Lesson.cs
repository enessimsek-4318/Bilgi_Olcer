using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public List<Subject> Subject { get; set; }
        public int  GradeId { get; set; }
        public List<GradeLesson> GradeLesson { get; set; }
    }
}
