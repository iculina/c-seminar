using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHseminar
{
    public partial class Form1 : Form
    {

        AllCards deck1 = new AllCards();
        public Form1()
        {
            InitializeComponent();
            //m


        }



        //random 1 ili 2 broj karata -> toliko se puta Choose pozove
        //unutar button -> random ( i izvana) ; if 1 else if 2 -> 1 choose ili 2 choose

        private void button1_Click(object sender, EventArgs e)
        {

            Random random1 = new Random();
            int brIzvlacenja = random1.Next(1, 3);

            if (deck1.CardsLeftNum == 0) 
            {
                /*napisat kraj*/
                label3.Text = "NO CARDS LEFT";
                label1.Text = " ";
                label2.Text = " ";
                linkLabel1.Text = "RESTART";
                linkLabel2.Text = "EXIT";


            }
            else if (deck1.CardsLeftNum == 1)
            {
                label1.Text = deck1.Choose();
                label2.Text = " ";
            }
            else
            {

                if (brIzvlacenja == 1)
                {
                    //deck1.Choose();

                    label1.Text = deck1.Choose();
                    label2.Text = " ";
                }



                else if (brIzvlacenja == 2)
                {
                    //deck1.Choose();
                    label1.Text = deck1.Choose();

                    //deck1.Choose();
                    label2.Text = deck1.Choose();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
