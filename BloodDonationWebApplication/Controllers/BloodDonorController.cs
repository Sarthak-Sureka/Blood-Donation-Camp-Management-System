using BloodDonation.DataAccess;
using BloodDonation.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodDonationWebApplication.Controllers
{
    public class BloodDonorController : ApiController
    {
        private BloodDonorRepository bdr = new BloodDonorRepository();

        public List<DonorDetails> GetDetails()
        {
            return JsonConvert.DeserializeObject<List<DonorDetails>>(bdr.ReadDonorDetails());
        }

        public void PostDetails(string jsondata)
        {
            bdr.SaveDonorDetails(jsondata);
        }

        public void DeleteDetails(int Id)
        {
            bdr.DeleteDonorDetails(Id);
        }

        public void PutDetails(DonorDetails d)
        {
            bdr.UpdateDonorDetails(d);
        }

    }
}
