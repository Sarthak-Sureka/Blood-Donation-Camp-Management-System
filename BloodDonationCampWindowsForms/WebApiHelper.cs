using BloodDonation.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonationCampWindowsForms
{
    public class WebApiHelper
    {
        private RestClient restClient = new RestClient(ConfigurationManager.AppSettings["uri"]);
        
        public List<DonorDetails> Get()
        {
            RestRequest request = new RestRequest("BloodDonor", Method.GET);
            IRestResponse<List<DonorDetails>> response = restClient.Execute<List<DonorDetails>>(request);
            return response.Data;
        }

        public void Post(string data)
        {
            var request = new RestRequest("BloodDonor?jsondata=" + data, Method.POST);
            var response = restClient.Execute(request);
            if (response.IsSuccessful)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Error");
        }

        public void Delete(int Id)
        {
            var request = new RestRequest("BloodDonor/" + Id, Method.DELETE);
            var response = restClient.Execute(request);
            if (response.IsSuccessful)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Error");
        }

        public DonorDetails Search(int Id)
        {
            RestRequest request = new RestRequest("BloodDonor/" + Id, Method.GET);
            IRestResponse<DonorDetails> response = restClient.Execute<DonorDetails>(request);
            return response.Data;
        }

        public void Put(string data)
        {
            var request = new RestRequest("BloodDonor?jsondata=" + data, Method.PUT);
            var response = restClient.Execute(request);
            if (response.IsSuccessful)
                MessageBox.Show("Successful");
            else
                MessageBox.Show("Error");
        }

    }
}
