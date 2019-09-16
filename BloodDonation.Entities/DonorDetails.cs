using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Entities
{
    public class DonorDetails
    {
        [Key]
        public int DonorID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public int UnitCollected { get; set; }
    }
}
