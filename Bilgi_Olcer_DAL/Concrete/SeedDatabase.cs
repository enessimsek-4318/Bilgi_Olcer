using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_DAL.Concrete
{
    public class SeedDatabase
    {
        
        public static void Seed()
        {
            var context = new DataContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Questions.Count() == 0)
                {
                    context.Questions.AddRange(questions);
                }               
                context.SaveChanges();
            }
        }

        private static Question[] questions =
            {
                new Question(){Grade="9",Lesson="Matematik",Subject="Üslü Sayılar",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="10",Lesson="Matematik",Subject="Parabol",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="11",Lesson="Matematik",Subject="Limit",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="12",Lesson="Matematik",Subject="Türev",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="9",Lesson="Fizik",Subject="Newton Yasaları",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="10",Lesson="Fizik",Subject="Newton Yasaları2",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="11",Lesson="Fizik",Subject="Newton Yasaları3",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="12",Lesson="Fizik",Subject="Newton Yasaları4",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="9",Lesson="Türk Edebitatı",Subject="Şairler",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="10",Lesson="Türk Edebitatı",Subject="Şairler2",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="11",Lesson="Türk Edebitatı",Subject="Şairler3",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="12",Lesson="Türk Edebitatı",Subject="Şairler4",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="9",Lesson="Felsefe",Subject="Düşün",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="10",Lesson="Felsefe",Subject="Düşün2",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="11",Lesson="Felsefe",Subject="Düşün3",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="12",Lesson="Felsefe",Subject="Düşün4",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="9",Lesson="Kimya",Subject="Elementler",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="10",Lesson="Kimya",Subject="Elementler2",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="11",Lesson="Kimya",Subject="Elementler3",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"},
                new Question(){Grade="12",Lesson="Kimya",Subject="Elementler4",Text="abc",PhotoUrl="abc",OptionA="A",OptionB="B",OptionC="C",OptionD="D",OptionE="E",Answer="A"}
            };

    }
}
