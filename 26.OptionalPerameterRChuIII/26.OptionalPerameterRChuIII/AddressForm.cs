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
        public frmAddress()
        {
            InitializeComponent();
        }

        private void YourAddress (string apt, string streetAddress, string city, string province, string postalCode) {
            lblOutput.Text = "Your Address is : " + " " + apt + " " + streetAddress + ", " + city + " " + province + ", " + postalCode;

        }

        private void YourAddress(string streetAddress, string city, string province, string postalCode) {
            lblOutput.Text = "Your Address is : " + streetAddress + ", " + city + " " + province + ", " + postalCode;
        }

        private void btnDisplay_Click(object sender, EventArgs e) {
            string aptNum = txtAptNum.Text;
            string streetAdd = txtStreet.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;

            if (aptNum == "")
            {
                YourAddress(streetAdd, city, province, postalCode);
            }
            else
            {
                YourAddress(aptNum, streetAdd, city, province, postalCode);
            }
        }
    }
}
