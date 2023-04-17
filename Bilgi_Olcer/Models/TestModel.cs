using Entities;

namespace Bilgi_Olcer.Models
{
    public class TestModel
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public int Index { get; set; }
        public string Subject { get; set; }
        public string Option { get; set; }
        public string Answer { get; set; }
        public int QuestionNumber { get; set; }
    }
}
