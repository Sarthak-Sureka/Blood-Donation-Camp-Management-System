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

        public IHttpActionResult GetDetails()
        {
            List<DonorDetails> data = JsonConvert.DeserializeObject<List<DonorDetails>>(bdr.ReadDonorDetails());
            if (data == null)
                return NotFound();
            return Ok(data);
        }

        public IHttpActionResult PostAllDetails(string jsondata)
        {
            var data = bdr.SaveDonorDetails(jsondata);
            if (data == false)
                return NotFound();
            return Ok(data);
        }

        public IHttpActionResult DeleteDetails(int Id)
        {
            var result = bdr.DeleteDonorDetails(Id);
            if (result == false)
                return NotFound();
            return Ok();
        }

        public IHttpActionResult PutDetails(string d)
        {
            var data = bdr.UpdateDonorDetails(d);
            if (data == false)
                return NotFound();
            return Ok(data);
        }

        public IHttpActionResult PostDetails(int Id)
        {
            DonorDetails data = JsonConvert.DeserializeObject<DonorDetails>(bdr.SearchDonorDetails(Id));
            if (data == null)
                return NotFound();
            return Ok(data);
        }

    }
}
