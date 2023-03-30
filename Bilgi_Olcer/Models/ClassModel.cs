using Entities;

namespace Bilgi_Olcer.Models
{
	public class ClassModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Question> questions { get; set; }

	}
}
