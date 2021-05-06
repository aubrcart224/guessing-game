using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessing_game
{
    public partial class Form1 : Form
    {
        //gloabl variables 
        Random randGen = new Random();
        double input;
        double number;

        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //variuasbles 
            input = Convert.ToDouble(inputBox.Text);
            number = randGen.Next(1, 100);

            //caluclations 
            if(input > number)
            {
                outputLabel.Text = "too high";
            }
            else if (input < number)
            {
                outputLabel.Text = "too low ";

            }
            else
            {
                outputLabel.Text = "You got it! ";
            }
            // out put / if else 

        }
    }
}
