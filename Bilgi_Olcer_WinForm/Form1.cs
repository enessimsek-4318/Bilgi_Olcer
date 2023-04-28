
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
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5045/");
            HttpResponseMessage response = await client.GetAsync("api/Admin");
            string result = await response.Content.ReadAsStringAsync();
            List<Question> questions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Question>>(result);

            List<Question> distinctListGrade = questions.GroupBy(q => q.Grade).Select(g => g.First()).ToList();
            List<Question> distinctListLesson = questions.GroupBy(q => q.Lesson).Select(g => g.First()).ToList();

            foreach (var item in distinctListGrade)
            {
                Grade_combobox.Items.Add(item.Grade);
            }
            foreach (var item in distinctListLesson)
            {
                Lesson_combobox.Items.Add(item.Lesson);
            }

            foreach (var item in questions)
            {
                string[] question = { item.Grade, item.Lesson, item.Subject, item.Text, item.Answer };
                ListViewItem listItem = new ListViewItem(question);
                question_list.Items.Add(listItem);
            };

        }

        private void btn_list_Click(object sender, EventArgs e)
        {

        }
    }
}