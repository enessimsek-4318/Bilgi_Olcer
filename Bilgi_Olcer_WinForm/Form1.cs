
using Entities;
using System.Reflection;

namespace Bilgi_Olcer_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void Form1_Load(object sender, EventArgs e)
        {

            List<Question> questions = await GetInfo(); 
            List<Question> distinctListGrade = questions.GroupBy(q => q.Grade).Select(g => g.First()).ToList();
            List<Question> distinctListLesson = questions.GroupBy(q => q.Lesson).Select(l => l.First()).ToList();

            foreach (var item in distinctListGrade)
            {
                Grade_combobox.Items.Add(item.Grade);
            }
            foreach (var item in distinctListLesson)
            {
                Lesson_combobox.Items.Add(item.Lesson);
            }

            SetList(questions);

        }

        private async void btn_list_Click(object sender, EventArgs e)
        {
            //question_list.Clear();
            //List<Question> questions = await GetInfo();
            //List<Question> filterQuestion = new List<Question>();
            //if (Grade_combobox.SelectedItem!=null)
            //{
            //    string grade=Grade_combobox.SelectedItem.ToString();
            //    string lesson = Lesson_combobox.SelectedItem.ToString();
            //    foreach (var item in questions)
            //    {
            //        if (grade == item.Grade.ToString())
            //        {
            //            filterQuestion.Add(item);
            //        }
            //        else if (lesson==item.Lesson.ToString())
            //        {
            //            filterQuestion.Add(item);
            //        }                    
            //    }
            //}
            
            //SetList(filterQuestion);

        }

        private async Task<List<Question>> GetInfo()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5045/");
            HttpResponseMessage response = await client.GetAsync("api/Admin");
            string result = await response.Content.ReadAsStringAsync();
            List<Question> questions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Question>>(result);
            return questions;
        }
        private void SetList(List<Question> list)
        {
            foreach (var item in list)
            {
                string[] question = { item.Grade, item.Lesson, item.Subject, item.Text, item.Answer };
                ListViewItem listItem = new ListViewItem(question);
                question_list.Items.Add(listItem);
            };
        }

    }
}