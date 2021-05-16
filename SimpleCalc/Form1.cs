using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octave.NET;
namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        OctaveContext octave;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            OctaveSettings settings = new OctaveSettings();
            settings.OctaveCliPath = @"C:\Users\sinoa\AppData\Local\Programs\GNU Octave\Octave-6.2.0\mingw64\bin\octave.bat";
            OctaveContext.OctaveSettings = settings;
            octave = new OctaveContext();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            label1.Text += "X";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string op = label1.Text.Replace('X','*');
            label2.Text=octave.Execute(op);
        }
      
        private bool IsValidCharacter(char key)
        {
            char[] keys = { '1','2','3','4','5','6','7','8','9','0','+','-','x','/','=','.','X'};

            foreach (char k in keys)
                if (k == key)
                    return true;

            return false;
        }

      
    }
}
