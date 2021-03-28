using Newtonsoft.Json;
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
namespace CustomerClient
{
    public partial class AdoClient : Form
    {
        public AdoClient()
        {
            InitializeComponent();
        }

        private  async void btnGetCustomerById_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:28479/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"api/Customer/GetId/" + txtGetCustomerById.Text);

            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                CustomerModel customerModels = JsonConvert.DeserializeObject<CustomerModel>(result);

                txtId.Text = customerModels.Id.ToString();
                txtName.Text = customerModels.Name;
                txtSureName.Text = customerModels.SureName;
                dateTimeBirthday.Value = customerModels.Date;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:28479/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.DeleteAsync("api/Customer/Delete/" + txtDelete.Text);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Musteri silindi");
            }
            GetAll();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel();
            customer.Id = Convert.ToInt32(txtId.Text);
            customer.Name = txtName.Text;
            customer.SureName = txtSureName.Text;
            customer.Date = dateTimeBirthday.Value;
            string jsonText = JsonConvert.SerializeObject(customer);

            var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:28479/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.PutAsync("api/Customer/Update", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Musteri Yenilendi");
            }
            GetAll();
        }

        private async void btn_Create_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel();
            customer.Name = txtName.Text;
            customer.SureName = txtSureName.Text;
            customer.Date = dateTimeBirthday.Value;
            string jsonText = JsonConvert.SerializeObject(customer);

            var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:28479/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.PostAsync("api/Customer/Create", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Musteri elave edildi");
            }
            GetAll();
        }

        private async void btnGetAllCustomer_Click(object sender, EventArgs e)
        {
            GetAll();
        }


        public async void GetAll()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:28479/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync("api/Customer/GetAll");
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                List<CustomerModel> customerModels = JsonConvert.DeserializeObject<List<CustomerModel>>(result);
                dataGridView1.DataSource = customerModels;
            }
        }
    }
}
