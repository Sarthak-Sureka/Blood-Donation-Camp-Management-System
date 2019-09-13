using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationCampWindowsForms
{
    public class WebApiHelper
    {
        private string url = string.Empty;
        HttpClient client = new HttpClient();

        public WebApiHelper(string url)
        {
            this.url = url;
        }

        public string Delete(int Id)
        {
            HttpResponseMessage response = client.DeleteAsync(url + Id).Result;
            return response.Content.ToString();
        }

    }
}
