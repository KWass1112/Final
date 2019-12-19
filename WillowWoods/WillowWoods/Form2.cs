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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void next1btn_Click(object sender, EventArgs e)
        {
            wispdialoglbl.Visible = false;
            youdialog1lbl.Visible = true;
            next2btn.Visible = true;
        }

        private void next2btn_Click(object sender, EventArgs e)
        {
            wispdialog2lbl.Visible = true;
            youdialog1lbl.Visible = false;
            next3btn.Visible = true;
            
        }

        private void next3btn_Click(object sender, EventArgs e)
        {
            

        }
    }
}
