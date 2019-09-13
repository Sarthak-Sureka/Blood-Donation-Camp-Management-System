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
        bool SaveDonorDetails(string jsondata);
        string ReadDonorDetails();
        bool DeleteDonorDetails(int DonorId);
        bool UpdateDonorDetails(string data);
        string SearchDonorDetails(int DonorId);
    }
}
