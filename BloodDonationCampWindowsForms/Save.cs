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
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            NametextBox.Text = " ";
            //DobtextBox.Text = " ";
            WeighttextBox.Text = " ";
            BloodGrouptextBox.Text = " ";
            UnitCollectedtextBox.Text = " ";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Save_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.Show();
            this.Close();
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            string bg = string.Empty;
            if(BloodGrouptextBox.Text == "AB+")
            {
                bg = "AB%2B";
            }
            else if(BloodGrouptextBox.Text == "O+")
            {
                bg = "O%2B";
            }
            else if (BloodGrouptextBox.Text == "A+")
            {
                bg = "A%2B";
            }
            else if (BloodGrouptextBox.Text == "B+")
            {
                bg = "B%2B";
            }
            else
            {
                bg = BloodGrouptextBox.Text;
            }
            string data = "{'Name':'" + NametextBox.Text + "','DOB':'" + Convert.ToDateTime(dateTimePicker1.Value.Date) + "','Weight': " + WeighttextBox.Text + ",'BloodGroup':'" + bg + "','UnitCollected': " + UnitCollectedtextBox.Text + "}";
            WebApiHelper helper = new WebApiHelper();
            helper.Post(data);
        }

        private void BloodGrouptextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
