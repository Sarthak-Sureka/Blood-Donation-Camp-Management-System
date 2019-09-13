using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(IdtextBox1.Text);
            WebApiHelper helper = new WebApiHelper(ConfigurationManager.AppSettings["uri"]);
            try
            {
                helper.Delete(i);
                MessageBox.Show($"Donor Id: {i} successfully deleted");
            }
            catch(Exception)
            {
                MessageBox.Show($"Donor Id: {i} does not exist");
            }
            IdtextBox1.Text = "";
        }
    }
}
