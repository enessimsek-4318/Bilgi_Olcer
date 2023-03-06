namespace Entities
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuestionId { get; set; }
        public List<Question> Question { get; set; }
    }
}