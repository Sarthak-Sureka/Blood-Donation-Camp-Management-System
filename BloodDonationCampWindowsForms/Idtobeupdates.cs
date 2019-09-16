using BloodDonation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonationCampWindowsForms
{
    public partial class Idtobeupdates : Form
    {
        public Idtobeupdates()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.Show();
            this.Close();
        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            WebApiHelper helper = new WebApiHelper();
            DonorDetails dd = helper.Search(int.Parse(IdtextBox1.Text));
            Update u = new Update();
            //dd.Name=
            u.Show();
            this.Close();
        }

        private void Idtobeupdates_Load(object sender, EventArgs e)
        {

        }
    }
}
