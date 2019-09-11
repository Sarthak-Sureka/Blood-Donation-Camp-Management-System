using BloodDonation.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.DataAccess
{
    public class BloodDonationDbContext : DbContext
    {
        public DbSet<DonorDetails> DonorDetails { get; set; }
    }
}
