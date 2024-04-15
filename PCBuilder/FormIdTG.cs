using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class FormIdTG : Form
    {
        string mstg = "";
       
        public FormIdTG(string message)
        {
            mstg = message;
            InitializeComponent();
        }
        async Task tgMessageAsync(string messag, string chat)
        {
            string botToken = "7087331796:AAGG7BQAb-08YlJ9rgF3HA7mnjD4ompULsU"; //замени бот токен
            string chatId = chat; 

            string message = messag;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"https://api.telegram.org/bot{botToken}/sendMessage?chat_id={chatId}&text={message}");
                response.EnsureSuccessStatusCode();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string chat = textBox1.Text;
            tgMessageAsync(mstg,chat);
            this.Close();
        }
    }
}
