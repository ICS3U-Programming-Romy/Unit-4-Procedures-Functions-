/*
 * Created by: Romy I. Chu III
 * Created on: 11-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Address Program
 * This program... Uses optional parameter to display the user's address
 *                 They can choose to or to not input their apt. #
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

namespace _26.OptionalPerameterRChuIII
{
    public partial class frmAddress : Form
    {
        //Initializes the form
        public frmAddress()
        {
            InitializeComponent();
        }

        //These are the overloaded procedures that output a different string.
        #region Overloaded Procedures

        //This procedure will  display the address w/ the apt #
        private void YourAddress (string apt, string streetAddress, string city, string province, string postalCode) {
            lblOutput.Text = "Your Address is : " + " Apt " + apt + ", " + " " + streetAddress + ", " + city + " " + province + ", " + postalCode; }

        //This procedure will  display the address without the apt #
        private void YourAddress(string streetAddress, string city, string province, string postalCode) {
            lblOutput.Text = "Your Address is : " + streetAddress + ", " + city + " " + province + ", " + postalCode; }
        #endregion

        //This will determine which of the two procedures to use.
        private void btnDisplay_Click(object sender, EventArgs e) {

            //Gets the text in the textboxes and stores them in strings.
            string aptNum = txtAptNum.Text;
            string streetAdd = txtStreet.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;

            //Checks if the optional parameter (apt #) is empty or not, and chooses the procedure based on that.
            if (aptNum == "") {
                YourAddress(streetAdd, city, province, postalCode); }

            else {
                YourAddress(aptNum, streetAdd, city, province, postalCode); }
        }
    }
}
