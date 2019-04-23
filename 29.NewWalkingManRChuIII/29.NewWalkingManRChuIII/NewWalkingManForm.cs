/*
 * Created by: Romy I. CHu III
 * Created on: 16-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - New Walking Man
 * This program... is basically a new and improved walking man program. It uses new click 
 *                 events on the picture boxes so that when they are clicked the man starts to walk.
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
using System.Threading;

namespace _29.NewWalkingManRChuIII
{
    public partial class frmNewWalkingMan : Form
    {
        public frmNewWalkingMan()
        {
            InitializeComponent();

            //Hides the what to do label.
            this.lblWhatToDo.Hide();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //Show the label of what to do.
            this.lblWhatToDo.Show();

            //call the create picture boxes function
            CreatePicBoxes();

            this.btnClickMe.Hide();
        }

        //Adds locations for where to put the picture boxes
        private void CreatePicBoxes()
        {
            //generate each of the picture boxes
            CreatePic(61, 78);
            CreatePic(464, 78);
            CreatePic(61, 358);
            CreatePic(464, 358);
        }

        //Creates each of the picture boxes
        private void CreatePic(int x, int y)
        {
            //Creates a spcae for the picturebox
            PictureBox tmpPicMan = new PictureBox();

            //Gives the loction of where to put the picture box
            Point pntPic = new System.Drawing.Point(x, y);

            //Sets the above coordinates as the location for the picture box.
            tmpPicMan.Location = pntPic;

            //Puts an image on the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            //Make the image fit the picture box height and width
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //Make the picture box size
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //Add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            //Add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        //The procedure from the regular walking man program but changed a little bit.
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //Cast the oject to a picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            //Write a message checking which picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //declare the local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //From the regular walking man program.
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }

                //increment the counter
                pictureFrameCounter++;

                //refresh the screen
                this.Refresh();

                //pause the loop
                Thread.Sleep(50);

            }
        }
    }
}
