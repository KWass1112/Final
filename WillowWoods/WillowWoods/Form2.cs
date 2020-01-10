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

        private void button1_Click(object sender, EventArgs e)
        {
            int userEntry;
            int choice;
            Random ranNumberGenerator = new Random();
            choice = ranNumberGenerator.Next(1, 2);

            Console.WriteLine("Looks like you're almost close to the exit! Now pick a door but be warned a monster may be waiting behind one. Choose wisely");
            userEntry = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (userEntry == choice)
                {
                    Console.WriteLine("Yay you chose the right door! You're now free!");
                    Console.WriteLine("--------------------------------------------------------------------");
                    DisplayGameEnd();
                    // In form would change panel 
                }
                else
                {
                    MonsterPanel();

                    // In form would change panel 
                }

            } while (userEntry != choice);
        }
    }
}
