using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillowWoods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void firstNextbtn_Click(object sender, EventArgs e)
        {
            OnceUponlbl.Visible = false;
            storylbl.Visible = true;
            next2btn.Visible = true;
        }

        private void next2btn_Click_1(object sender, EventArgs e)
        {
            storylbl.Visible = false;
            firstNextbtn.Visible = false;
            willowWoodslbl.Visible = true;
            continuebtn.Visible = true;

        }

        private void continuebtn_Click_1(object sender, EventArgs e)
        {
            IntroPanel.Visible = true; 
        }

        private void nextOnebtn_Click(object sender, EventArgs e)
        {
            continuebtn.Visible = false;
            wispDialogOnelbl.Visible = false;
            youDialogOnelbl.Visible = true;
            nextTwobtn.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextTwobtn.Visible = false;
            youDialogOnelbl.Visible = false;
            youDialog2lbl.Visible = true;
            next3btn.Visible = true;

        }

        private void next3btn_Click(object sender, EventArgs e)
        {
            next3btn.Visible = false;
            youDialog2lbl.Visible = false;
            youDialog3lbl.Visible = true;
            next4btn.Visible = true;

        }

        private void next4btn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
            youDialog3lbl.Visible = false;
            wispDialog2lbl.Visible = true;
            next5btn.Visible = true;
        }

        private void next5btn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
            mazePanel.Visible = true;
        
        }
 
        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            Point startPoint = mazePanel.Location;
            Cursor.Position = PointToScreen(startPoint);

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            nextMazebtn.Visible = true;
        }
        private void okbtn_Click(object sender, EventArgs e)
        {
            next5btn.Visible = false;
        }
        private void nextMazebtn_Click(object sender, EventArgs e)
        {
            swordPanel.BringToFront();
            swordPanel.Visible = true;
        }

        private void next1btn_Click(object sender, EventArgs e)
        {
            youDialog1lbl.Visible = false;
            youDialogTwolbl.Visible = true;
            nextsword2btn.Visible = true;
        }

        private void nextsword2btn_Click(object sender, EventArgs e)
        {
            youDialogTwolbl.Visible = false;
            next1btn.Visible = false;
            wispDialog1lbl.Visible = true;
            pickUpbtn.Visible = true;
        }

        private void pickUpbtn_Click(object sender, EventArgs e)
        {
            nextsword2btn.Visible = false;
            wispDialog1lbl.Visible = false;
            wisppic.Visible = false;
            swordDescriptionlbl.Visible = true;
            swordpic.Visible = true;
            continueSwordbtn.Visible = true;

        }

        private int a = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            a++;
            int min = 1;
            int max = 100;
            int chance;
            Random ranNumberGenerator = new Random();
            chance = ranNumberGenerator.Next(min, max);

            do
            {
                if (chance < 50)
                {
                    wispHit1lbl.Visible = true;

                    if (a == 2)
                    {
                        wispHit2lbl.Visible = true;

                    }
                    else if ( a == 3)
                    {
                        monsterPic.Visible = false;
                        defeatlbl.Visible = true;
                        monsterContinuebtn.Visible = true;

                    }
                }
                else
                {
                    wispMisslbl.Visible = true;

                    if (a == 2)
                    {
                        defeatlbl.Visible = true;

                    }
                    else if (a == 3)
                    {
                        monsterPic.Visible = false;
                        monsterContinuebtn.Visible = true;
                    }
                }
                
                
            } while (a > 3);

        }

        private void continueSwordbtn_Click(object sender, EventArgs e)
        {
            Monsterpanel.Visible = true;
            Monsterpanel.BringToFront();
        }

        private void monsterContinuebtn_Click(object sender, EventArgs e)
        {
            doorPanel.Visible = true;
            doorPanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userChoice;
            userChoice = Convert.ToInt32(userChoicetxt.Text);

            if (userChoice == 1)
            {
                Monsterpanel.BringToFront();
            }
            else if (userChoice == 2)
            {
                //show exit and congrats
            }
        }

       
    }
     
}
