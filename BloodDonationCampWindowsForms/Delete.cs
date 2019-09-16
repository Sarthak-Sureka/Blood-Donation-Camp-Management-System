using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiny.RestClient;

namespace BloodDonationCampWindowsForms
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.Show();
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDonationCampDataSet.DonorDetails' table. You can move, or remove it, as needed.
            this.donorDetailsTableAdapter.Fill(this.bloodDonationCampDataSet.DonorDetails);

        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(IdtextBox1.Text);
            WebApiHelper helper = new WebApiHelper();
            IdtextBox1.Text = "";
            helper.Delete(i);
        }
    }
}
