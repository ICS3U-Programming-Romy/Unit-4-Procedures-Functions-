/*
 * Created by: Romy I. Chu III
 * Created on: 10-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Rounding Program
 * This program...Rounds an inputted number to a specified decimal place
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

namespace _25.RoundingProgramRChuIII
{
    public partial class frmRoundingProgram : Form
    {
        //Declares the variables
        double inputNum;
        int decimalPlace;

        public frmRoundingProgram()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Gets the numbers from the text box and the numeric up-down box
            inputNum = double.Parse(txtNumberInput.Text);
            decimalPlace = Convert.ToInt16(nudDecimalPlaceInput.Value);
            
            //Calls the Math_Round function with the reference to the input number, and a int for the decimal place.
            Math_Round(ref inputNum, decimalPlace);
        }

        //Rounds the number
        private void Math_Round (ref double Number, double roundTo) {
            //Multiplies the number by 10 to the power of the desired decimal point amount.
            Number *= (Math.Pow(10, roundTo));

            //Adds 0.5 to the number.
            Number += 0.5;

            //Gets rid of all the remaining decimal points
            Number = Math.Truncate(Number);

            //Divides the number by 10 to the power of the desired decimal point amount.
            Number /= (Math.Pow(10, roundTo));

            //Changes the label to display the answer.
            lblOutput.Text = "The Rounded number is : " + Number;
        }
    }
}
