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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetAllCustomer_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:53428/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync("api/CustomerCrud/GetAllCustomers");
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                List<CustomerModel> customerModels = JsonConvert.DeserializeObject<List<CustomerModel>>(result);
                dataGridView1.DataSource = customerModels;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("http://localhost:53428/");
            //httpClient.DefaultRequestHeaders.Accept.Clear();
            //httpClient.DefaultRequestHeaders.Accept.Add(
            //    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage responseMessage = await httpClient.Get("api/CustomerCrud/GetAllCustomer");
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    string result =  responseMessage.Content.ReadAsStringAsync();
            //    List<CustomerModel> customerModels = JsonConvert.DeserializeObject<List<CustomerModel>>(result);
            //    dataGridView1.DataSource = customerModels;
            //}
        }

        private async void btnGetCustomerById_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:53428/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"api/CustomerCrud/GetCustomerById/"+txtGetCustomerById.Text);
        
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
            httpClient.BaseAddress = new Uri("http://localhost:53428/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.DeleteAsync("api/CustomerCrud/DeleteCustomer/"+txtDelete.Text);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Musteri silindi");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel();
            customer.Id =Convert.ToInt32( txtId.Text);
            customer.Name = txtName.Text;
            customer.SureName = txtSureName.Text;
            customer.Date = dateTimeBirthday.Value;
               string jsonText = JsonConvert.SerializeObject(customer);

            var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:53428/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.PutAsync("api/CustomerCrud/CustomerUpdate",content);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Musteri Yenilendi");
            }
        }

        private async void  button4_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel();
            customer.Name = txtName.Text;
            customer.SureName = txtSureName.Text;
            customer.Date = dateTimeBirthday.Value;
            string jsonText = JsonConvert.SerializeObject(customer);

            var content = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:53428/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.PostAsync("api/CustomerCrud/CreateCustomer", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Musteri elave edildi");
            }
        }
    }
}
