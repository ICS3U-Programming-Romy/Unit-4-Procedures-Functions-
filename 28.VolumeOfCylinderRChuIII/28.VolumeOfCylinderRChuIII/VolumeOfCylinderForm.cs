/*
 * Created by: Romy I. Chu III
 * Created on: 15-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Volume of a Cylinder
 * This program...Calculates the volume of a cylinder with dimensions given by the user
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28.VolumeOfCylinderRChuIII
{
    public partial class frmVolumeOfCylinder : Form
    {
        public frmVolumeOfCylinder()
        {
            InitializeComponent();
        }

        //Changes the label of the output to display the volume.
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Gets the height and radius of the cylinder from the user.
            decimal userHeight = Convert.ToDecimal(txtHeight.Text);
            decimal userRadius = Convert.ToDecimal(txtRadius.Text);

            lblOutput.Text = "The volume of the cylinder is : " + CalculateVolume(userHeight, userRadius); 
        }

        //Calculates the volume of the cylinder
        private decimal CalculateVolume(decimal height, decimal radius) {
            //A decimal for the volume.
            decimal volume;

            //Calculates the volume
            volume = (decimal)Math.PI * (decimal)Math.Pow((double)radius, 2) * height;

            //Rounds the answer to 2 decimal points
            volume = Math.Round(volume, 2);

            //returns the value of volume.
            return volume;

        }
    }
}
