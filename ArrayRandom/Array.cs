/*
 * Created by: Perry Martin
 * Created on: 11-11-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#5-01
 * This program displays an example of a array
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

namespace ArrayRandom
{
    public partial class frmArray : Form
    {

        // global variables
        int[] arrayOfNumbers = new int[10];

      
        public frmArray()
        {
        

            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            this.lstRanBox.Items.Clear();


            // Varribles
            int loopCounter = 0;
            int average = 0;
            int listAdder;
            int randomNumbers;

            Random rnd = new Random();

            while (loopCounter < 10)
            {


                randomNumbers = rnd.Next(1, 11);
                arrayOfNumbers[loopCounter] = randomNumbers;
                listAdder = arrayOfNumbers[loopCounter];
                this.lstRanBox.Items.Add(listAdder);
                average = average + arrayOfNumbers[loopCounter];
                loopCounter++;
            }
                average = average / 10;
                this.lblQuestion.Text = "this is the average: " + average;
            
        }
     }
}
