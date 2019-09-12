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

        [Route("api/getdetails")]
        public List<DonorDetails> GetDetails()
        {
             return JsonConvert.DeserializeObject<List<DonorDetails>>(bdr.ReadDonorDetails());
        }

        [Route("api/postdetails")]
        public void PostDetails(string jsondata)
        {
            bdr.SaveDonorDetails(jsondata);
        }

        [Route("api/deletedetails/{DonorId}")]
        public void DeleteDetails(int DonorId)
        {
            bdr.DeleteDonorDetails(DonorId);
        }

        public void UpdateDetails()
        {

        }

    }
}
