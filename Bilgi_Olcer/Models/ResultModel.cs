namespace Bilgi_Olcer.Models
{
    public class ResultModel
    {
        public string userId { get; set; }
        public string Lesson { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Date { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }
        public int Empty { get; set; }
    }
}
