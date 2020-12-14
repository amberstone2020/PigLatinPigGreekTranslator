//Amber Holcomb-Stone
//Lab 6
//Description: This program create a form that accepts a text entry from the 
//user and converts it to either Pig Latin or Pig Greek. 
//Some code for translation adapted and modified from: https://github.com/jameswillhoite/CITC2311/tree/master/Lab6

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxEnglish.Text = "";
            this.textBoxTranslate.Text = "";
            lblTranslator.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbLatin_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslator.Text = "Pig Latin Translation: ";
        }

        private void rbGreek_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslator.Text = "Pig Greek Translation: ";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string english = textBoxEnglish.Text;

            
            if (String.IsNullOrEmpty(english))
            {
                MessageBox.Show("Please type something in the top box to translate.");
                return;
            }
            string response = "";
            if (rbLatin.Checked)
            {
                response = (new PigLatinTranslator()).Translate(english);
            }
            else if (rbGreek.Checked)
            {
                response = (new PigGreekTranslator()).Translate(english);
            }
            else
            {
                MessageBox.Show("Please choose either Pig Latin or Pig Greek");
            }

            textBoxTranslate.Text = response;
        }
    }
}
