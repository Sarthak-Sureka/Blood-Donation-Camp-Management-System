using BloodDonation.DataAccess;
using BloodDonation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DonorDetails dd = new DonorDetails
            //{
            //    DonorID = 4,
            //    Name = "AA",
            //    DOB = Convert.ToDateTime("04-09-2019"),
            //    Weight = 50,
            //    BloodGroup = "A+",
            //    UnitCollected = 500
            //};
            IBloodDonorRepository bd = new BloodDonorRepository();
            string data = @"{'DonorID': 7, 'Name':'Sarthak Sureka','DOB':'06/08/1997','Weight': 70,'BloodGroup':'B+','UnitCollected': 750}";
            //bd.SaveDonorDetails(data);
            //Console.WriteLine(bd.ReadDonorDetails());
            //bd.DeleteDonorDetails(1);
            //Console.WriteLine();
            //Console.WriteLine(bd.ReadDonorDetails());
            bd.UpdateDonorDetails(data);
            //Console.WriteLine();
            //Console.WriteLine(bd.ReadDonorDetails());
        }
    }
}
