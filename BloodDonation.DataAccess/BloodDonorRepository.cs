using BloodDonation.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace BloodDonation.DataAccess
{
    public class BloodDonorRepository : IBloodDonorRepository
    {
        private BloodDonationDbContext db = new BloodDonationDbContext();

        public void DeleteDonorDetails(int DonorId)
        {
            var item = db.DonorDetails.SingleOrDefault(c => c.DonorID == DonorId);
            if(item != null)
            {
                db.DonorDetails.Remove(item);
                db.SaveChanges();
            }
        }

        public string ReadDonorDetails()
        {
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(db.DonorDetails);
            return JsonString;
        }

        public void SaveDonorDetails(string jsondata)
        {
            var data = JsonConvert.DeserializeObject<List<DonorDetails>>(jsondata);
            foreach (var item in data)
            {
                DonorDetails dd = new DonorDetails();
                dd.Name = item.Name;
                dd.DOB = item.DOB;
                dd.Weight = item.Weight;
                dd.BloodGroup = item.BloodGroup;
                dd.UnitCollected = item.UnitCollected;
                db.DonorDetails.Add(dd);
            }
            db.SaveChanges();
        }

        public void UpdateDonorDetails(DonorDetails dd)
        {
            var item = db.DonorDetails.Where(c => c.DonorID == dd.DonorID);
            foreach (var i in item)
            {
                i.Name = dd.Name;
                i.DOB = dd.DOB;
                i.Weight = dd.Weight;
                i.BloodGroup = dd.BloodGroup;
                i.UnitCollected = dd.UnitCollected;
            }
            db.SaveChanges();
        }
    }
}
