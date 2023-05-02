using Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Olcer_WinForm
{
    public partial class Form3 : Form
    {
        private string id;
        public Form3(string id)
        {
            InitializeComponent();
            this.id= id;    
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5045/");
            HttpResponseMessage response = await client.GetAsync($"api/Admin/{id}");
            string result = await response.Content.ReadAsStringAsync();
            Question question = Newtonsoft.Json.JsonConvert.DeserializeObject<Question>(result);
            txt_Grade.Text = question.Grade;
            txt_Lesson.Text=question.Lesson;
            txt_Subject.Text = question.Subject;
            txt_Text.Text = question.Text;
            txt_A.Text = question.OptionA;
            txt_B.Text = question.OptionB;
            txt_C.Text = question.OptionC;
            txt_D.Text = question.OptionD;
            txt_E.Text = question.OptionE;
            txt_Answer.Text = question.Answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5045/");

            var updatedQuestion = new Question
            {
                Id = Convert.ToInt32(id),
                Grade = txt_Grade.Text,
                Lesson = txt_Lesson.Text,
                Subject = txt_Subject.Text,
                Text = txt_Text.Text,
                OptionA = txt_A.Text,
                OptionB = txt_B.Text,
                OptionC = txt_C.Text,
                OptionD = txt_D.Text,
                OptionE = txt_E.Text,
                Answer = txt_Answer.Text,
                PhotoUrl = "abc"
            };

            var content = new StringContent(JsonConvert.SerializeObject(updatedQuestion), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/Admin/{updatedQuestion.Id}", content);
        }
    }
}
