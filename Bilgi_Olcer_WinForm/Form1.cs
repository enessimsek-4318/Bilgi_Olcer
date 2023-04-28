
using Entities;

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

        private async void btn_list_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5045/");
            HttpResponseMessage response = await client.GetAsync("api/Admin");
            string result = await response.Content.ReadAsStringAsync();
            List<Question> questions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Question>>(result);
            foreach (var item in questions)
            {
                
            }

        }
    }
}