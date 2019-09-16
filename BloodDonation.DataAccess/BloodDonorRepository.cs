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

        public bool DeleteDonorDetails(int DonorId)
        {
            var item = db.DonorDetails.SingleOrDefault(c => c.DonorID == DonorId);
            if (item == null)
                return false;
            db.DonorDetails.Remove(item);
            db.SaveChanges();
            return true;
        }

        public string ReadDonorDetails()
        {
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(db.DonorDetails);
            return JsonString;
        }

        public bool SaveDonorDetails(string jsondata)
        {
            DonorDetails data = JsonConvert.DeserializeObject<DonorDetails>(jsondata);
            if (data == null)
                return false;
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
            return true;
        }

        public DonorDetails SearchDonorDetails(int DonorId)
        {
            return db.DonorDetails.Where(c => c.DonorID == DonorId).First();
        }

        public bool UpdateDonorDetails(string jsondata)
        {
            DonorDetails data = JsonConvert.DeserializeObject<DonorDetails>(jsondata);
            if (data == null)
                return false;
            db.DonorDetails.AddOrUpdate(data);
            db.SaveChanges();
            return true;
            //var item = db.DonorDetails.Where(c => c.DonorID == dd.DonorID);
            //if (item == null)
            //    return false;
            //foreach (var i in item)
            //{
            //    i.Name = dd.Name;
            //    i.DOB = dd.DOB;
            //    i.Weight = dd.Weight;
            //    i.BloodGroup = dd.BloodGroup;
            //    i.UnitCollected = dd.UnitCollected;
            //}
            //db.SaveChanges();
            //return true;
        }
    }
}
