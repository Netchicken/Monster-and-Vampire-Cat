using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuffUNeedToKnow
{
   
    //todo We need a count down, or count up
   
    // we need to make methods in the class (or move your methods to the class)
    //todo we need to Unit Test our project 2X
    //todo create / load sound and Image
    //todo resource folder to store S & N
    //todo Host on GitHub

    public partial class Form1 : Form
    {
       
        GameCode myGameCode = new GameCode();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
            //my counter increases by 1 each time I click on the button
            myGameCode.count += 1;
            //show the counter for testing
            this.Text =   myGameCode.count.ToString();
 //We need a Random Number Generator
            int rnd = myGameCode.RNDGenerator(); 
            lbxOutput.Items.Insert(0,rnd);
            
            //if the random number = the counter show the cat
            if (myGameCode.count == rnd)
            {
                pbxImage.Image = Resource1.cat;
                lbxOutput.Items.Insert(0,rnd + " Vampire Cat!");
                MessageBox.Show("The Vampire Cat!");
                
                //reset the counter to 0
                myGameCode.count = 0;

                //don't run any more code from below.
                return;
            }


            switch (myGameCode.count)
            {
                  case 1:
                      pbxImage.Image = Resource1.Agor;
                      break;
                case 2:
                    pbxImage.Image = Resource1.Igor;
                    break;
                case 3:
                    pbxImage.Image = Resource1.Ogor;
                    break;
                case 4:
                    pbxImage.Image = Resource1.Ugor;
                    myGameCode.count = 0;
                    break;
            }


            return;
            if (myGameCode.count == 1)
            {
                pbxImage.Image = Resource1.Agor;
            }
            else if (myGameCode.count == 2)
            {
                pbxImage.Image = Resource1.Igor;
                }
            else if (myGameCode.count == 3)
            {
                pbxImage.Image = Resource1.Ogor;
            }
            else if (myGameCode.count == 4)
            {
                pbxImage.Image = Resource1.Ugor;
myGameCode.count = 0;
               }
          

           
           
        }

        #region OldCode

        private int RNDGenerator()
        {
           Random rndNumber = new Random();
            int rnd = rndNumber.Next(1, 7);
            return rnd;
        }
        #endregion

    }
}
