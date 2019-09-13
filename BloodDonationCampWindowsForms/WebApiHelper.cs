using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Delete(int Id)
        {
            HttpResponseMessage response = client.DeleteAsync(url + Id).Result;
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

    }
}
