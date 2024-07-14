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


    public partial class Form1 : Form
    {
        //Global counter
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            string MonsterName = string.Empty;

            Random rndNumber = new Random();
            int rnd = rndNumber.Next(1, 5);

            //show the counter for testing
            this.Text = "RANDOM " + rnd.ToString();

            //if the random number = the counter show the cat
            if (count == rnd)
            {
                pbxImage.Image = Resource1.cat;
                lbxOutput.Items.Insert(0, rnd + " Vampire Cat!");
                MessageBox.Show("The Vampire Cat!");

                //reset the counter to 0
                count = 0;

                //don't run any more code from below.
                return;
            }

            if (rnd == 1)
            {
                pbxImage.Image = Resource1.Agor;
                MonsterName = "Agor";

            }
            else if (rnd == 2)
            {
                pbxImage.Image = Resource1.Igor;
                MonsterName = "Igor";
            }
            else if (rnd == 3)
            {
                pbxImage.Image = Resource1.Ogor;
                MonsterName = "Ogor";
            }
            else if (rnd == 4)
            {
                pbxImage.Image = Resource1.Ugor;
                MonsterName = "Ugor";
            }
            lbxOutput.Items.Insert(0, count + " " + MonsterName);
            //the counter increases by 1 each time I click on the button
            count += 1;

            if (count == 4)
            {
                count = 0;
            }


            //switch (rnd)
            //{
            //    case 1:
            //        pbxImage.Image = Resource1.Agor;
            //        MonsterName = "Agor";
            //        break;
            //    case 2:
            //        pbxImage.Image = Resource1.Igor;
            //        MonsterName = "Igor";
            //        break;
            //    case 3:
            //        pbxImage.Image = Resource1.Ogor;
            //        MonsterName = "Ogor";
            //        break;
            //    case 4:
            //        pbxImage.Image = Resource1.Ugor;
            //        MonsterName = "Ugor";
            //        count = 0;
            //        break;
            //}




            //We need a Random Number Generator




        }



    }
}
