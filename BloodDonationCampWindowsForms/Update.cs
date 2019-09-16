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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Updatebutton4_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Operations i = new Operations();
            i.Show();
            this.Close();
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            NametextBox.Text = " ";
            DobtextBox.Text = " ";
            WeighttextBox.Text = " ";
            BloodGrouptextBox.Text = " ";
            UnitCollectedtextBox.Text = " ";
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            //var data ="{'DonorID': " + int.Parse(textBox1.Text)+",'Name': '"+NametextBox.Text+"','DOB': '"+Convert.ToDateTime(DobtextBox.Text)+",'Weight': "+int.Parse(WeighttextBox.Text)+",'BloodGroup': '"+BloodGrouptextBox.Text+"','UnitCollected': "+int.Parse(UnitCollectedtextBox.Text)+"}";
            DonorDetails d = new DonorDetails
            {
                DonorID = int.Parse(textBox1.Text),
                Name = NametextBox.Text,
                DOB = Convert.ToDateTime(DobtextBox.Text),
                Weight = int.Parse(WeighttextBox.Text),
                BloodGroup = BloodGrouptextBox.Text.ToString(),
                UnitCollected = int.Parse(UnitCollectedtextBox.Text)
            };
            string data = JsonConvert.SerializeObject(d);
            WebApiHelper helper = new WebApiHelper();
            helper.Put(data);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            WebApiHelper helper = new WebApiHelper();
            DonorDetails dd = helper.Search(i);
            NametextBox.Text = dd.Name;
            DobtextBox.Text = dd.DOB.ToString();
            WeighttextBox.Text = dd.Weight.ToString();
            BloodGrouptextBox.Text = dd.BloodGroup;
            UnitCollectedtextBox.Text = dd.UnitCollected.ToString();
        }
    }
}
