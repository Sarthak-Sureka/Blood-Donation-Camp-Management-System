using BloodDonation.Entities;
using Newtonsoft.Json;
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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.Show();
            this.Close();
        }

        private void ViewrichTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDonationCampDataSet.DonorDetails' table. You can move, or remove it, as needed.
            this.donorDetailsTableAdapter.Fill(this.bloodDonationCampDataSet.DonorDetails);

        }
    }
}
