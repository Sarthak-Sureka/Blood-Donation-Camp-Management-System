﻿using System;
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
            Idtobeupdates i = new Idtobeupdates();
            i.Show();
            this.Hide();
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            NametextBox.Text = " ";
            DobtextBox.Text = " ";
            WeighttextBox.Text = " ";
            BloodGrouptextBox.Text = " ";
            UnitCollectedtextBox.Text = " ";
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
