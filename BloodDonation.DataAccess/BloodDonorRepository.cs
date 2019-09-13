using BloodDonation.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            DonorDetails data = JsonConvert.DeserializeObject<DonorDetails>(jsondata);
            //foreach (var item in data)
            //{
            //    DonorDetails dd = new DonorDetails();
            //    dd.Name = item.Name;
            //    dd.DOB = item.DOB;
            //    dd.Weight = item.Weight;
            //    dd.BloodGroup = item.BloodGroup;
            //    dd.UnitCollected = item.UnitCollected;
            //    db.DonorDetails.Add(dd);
            //}
            db.DonorDetails.Add(data);
            db.SaveChanges();
        }

        public string SearchDonorDetails(int DonorId)
        {
            return db.DonorDetails.SingleOrDefault(c => c.DonorID == DonorId).ToString();
        }

        public void UpdateDonorDetails(string jsondata)
        {
            DonorDetails data = JsonConvert.DeserializeObject<DonorDetails>(jsondata);
            db.DonorDetails.AddOrUpdate(data);
            db.SaveChanges();
            //var item = db.DonorDetails.Where(c => c.DonorID == dd.DonorID);
            //foreach (var i in item)
            //{
            //    i.Name = dd.Name;
            //    i.DOB = dd.DOB;
            //    i.Weight = dd.Weight;
            //    i.BloodGroup = dd.BloodGroup;
            //    i.UnitCollected = dd.UnitCollected;
            //}
            //db.SaveChanges();
        }
    }
}
