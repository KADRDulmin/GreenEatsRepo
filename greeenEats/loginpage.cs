using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace greeenEats
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private static readonly HttpClient client = new HttpClient();

        private async Task<string> MakeApiCall(string url, string email, string password)
        {
            var payload = new
            {
                email = email,
                password = password
            };

            string jsonPayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }

            throw new Exception($"API call failed with status code {response.StatusCode}");
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://159.89.203.249:2001/api/client/login";
            string email = entered_username.Text;
            string password = enter_password_login.Text;
            ChooseForm objhf = new ChooseForm();
            try
            {
                string response = await MakeApiCall(apiUrl, email, password);
                Console.WriteLine(response);              
                objhf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            staffLogin obj_log = new staffLogin();
            obj_log.Show();
            this.Hide();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            starting_form objs = new starting_form();
            objs.Show();
            this.Hide();
        }
    }
}