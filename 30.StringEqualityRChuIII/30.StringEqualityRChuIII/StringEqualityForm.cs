/*
 * Created by: Romy I. Chu III
 * Created on: 17-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #34 - String Equality
 * This program... Compares two strings to see if they're the same.
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

namespace _30.StringEqualityRChuIII
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            //Declare variable.
            bool isEqual;

            //Changes the strings to all upper case.
            string1 = string1.ToUpper();
            string2 = string2.ToUpper();

            //Checks if the strings are equal
            if (string1 == string2)
            {
                //Set the bool to true
                isEqual = true;
            }
            else
            {
                //Set the bool to false
                isEqual = false;
            }

            //Retrun the bool
            return isEqual;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Decalring variables
            string string1, string2;
            bool isEqual;

            //Getting the strings from the textboxes
            string1 = txtString1.Text;
            string2 = txtString2.Text;

            //Calls the function StringsAreEqual to check if the strings are equal.
            isEqual = StringsAreEqual(string1, string2);

            //Shows the answer.
            if (isEqual == true)
            {
                lblOutput.Text = "The Strings Are : Equal";
            }
            else
            {
                lblOutput.Text = "The Strings Are : Not Equal";
            }
        }
    }
}