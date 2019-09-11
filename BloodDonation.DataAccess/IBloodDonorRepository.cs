using BloodDonation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.DataAccess
{
    public interface IBloodDonorRepository
    {
        void SaveDonorDetails(string jsondata);
        string ReadDonorDetails();
        void DeleteDonorDetails(int DonorId);
        void UpdateDonorDetails(DonorDetails dd);
    }
}
