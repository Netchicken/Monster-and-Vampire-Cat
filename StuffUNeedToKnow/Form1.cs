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
            //We need a Random Number Generator
            int rnd = myGameCode.RNDGenerator(); //RNDGenerator();

            lbxOutput.Items.Add(rnd);
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
