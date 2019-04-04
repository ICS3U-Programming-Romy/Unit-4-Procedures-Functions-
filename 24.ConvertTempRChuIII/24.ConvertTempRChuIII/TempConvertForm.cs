/*
 * Created by: Romy I. Chu III
 * Created on: 04-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Pass By Value - Temp Converter
 * This program...Converts temperature from celsius to fahrenheit
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

namespace _24.ConvertTempRChuIII
{
    public partial class frmTempConvert : Form
    {
        public frmTempConvert()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declares a float for the temperature in celcius.
            float tempCel;

            //Converts the text box string to a float value
            tempCel = float.Parse(Convert.ToString(txtInput.Text));

            //Calls the procedure to run the conversion
            this.ConvertToFar(tempCel);
        }


        private void ConvertToFar(float tC)
        {
            //Declares a floar for the temperature in fahrenheit.
            float tempFar;
            //(9/5)*Tc+32

            //Converts the temperature in celcius to fahrenheit.
            tempFar = ((tC * 9) / 5) + 32;

            //Changes the label to display the temperature.
            lblTemperature.Text = "The temperature is : " + tempFar;
        }

    }
}
