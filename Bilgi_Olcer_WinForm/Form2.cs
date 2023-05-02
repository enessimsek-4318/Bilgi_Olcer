using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Olcer_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private string PhotoURL;
        private async void button2_Click(object sender, EventArgs e)
        {
            if (txt_Grade.Text == "" || txt_Lesson.Text == "" || txt_Subject.Text == "" ||
                txt_Text.Text == "" || txt_A.Text == "" || txt_B.Text == "" || txt_C.Text==""||
                txt_D.Text==""|| txt_E.Text==""|| txt_Answer.Text=="")
            {
                MessageBox.Show("Zorunlu Alanlar Boş Geçilemez.");
            }
            else
            {
                if (PhotoURL==null)
                {
                    PhotoURL = "";
                }
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5045/");
                var addQuestion = new Question
                {
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
                    PhotoUrl = PhotoURL
                };
                var content = new StringContent(JsonConvert.SerializeObject(addQuestion), Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"api/Admin", content);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PhotoURL = openFileDialog.FileName;
                }
            }
        }
    }
}
