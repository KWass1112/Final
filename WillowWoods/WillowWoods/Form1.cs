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
            nextbtn.Visible = true;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
        }

        private void next1btn_Click(object sender, EventArgs e)
        {
            youDialog1lbl.Visible = false;
            youDialog2lbl.Visible = true;
            nextsword2btn.Visible = true;
        }

        private void nextsword2btn_Click(object sender, EventArgs e)
        {
            youDialog2lbl.Visible = false;
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

        }
    }
     
}
