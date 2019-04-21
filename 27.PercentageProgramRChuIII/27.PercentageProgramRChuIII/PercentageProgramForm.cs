/*
 * Created by: Romy I. Chu III
 * Created on: 14/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Percentage Program
 * This program... Gives you a percentage based on the mark you want.
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

namespace _27.PercentageProgramRChuIII
{
    public partial class frmPercentageProgram : Form
    {
        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        //Declares some variables.
        string level;
        int percentGrade;

        private void btnOutput_Click(object sender, EventArgs e)
        {
            level = txtGrade.Text;  //Gets the text from the textbox
            percentGrade = GivePercentage(level);  //Calls the function 'GivePercentage' w/ 'level' as an argument
            lblPercentage.Text = "The Percentage you want is : " + Convert.ToString(percentGrade) + "%"; //Changes the label to show the percentage
        }

        //Function: Percent
        //Input: string level
        //Output: int percentage
        //Description: Uses the input to determine what percentage you will get for the given grade.
        private int GivePercentage(string level)
        {
            //declares an int
            int percentage;

            //This switch statement is basically a really cool 'IF...THEN...ELSE IF...ELSE' statement.
            //Checks if the string 'level' is equal to one of the grades, then assigns a value to the int 'percentage'.
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            //Returns the value of the int 'percentage'
            return percentage;
        }
    }
}
