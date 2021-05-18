using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octave.NET;
namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        string operacion = "";
        OctaveContext octave;
        Point originalLocationLabel1;
        Point originalLocationLabel2;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();



        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            OctaveSettings settings = new OctaveSettings();
            settings.OctaveCliPath = @"C:\Users\sinoa\AppData\Local\Programs\GNU Octave\Octave-6.2.0\mingw64\bin\octave.bat";
            OctaveContext.OctaveSettings = settings;
            octave = new OctaveContext();

            octave.Execute("5*5");
            
            originalLocationLabel1 = label1.Location;
            originalLocationLabel2 = label2.Location;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion += "1";
            label1.Text += " 1";
            label1.Location = new Point(label1.Location.X-15,label1.Location.Y);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            operacion += "2";
            label1.Text += " 2";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            operacion += "3";
            label1.Text += " 3";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            operacion += "4";
            label1.Text += " 4";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operacion += "5";
            label1.Text += " 5";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operacion += "6";
            label1.Text += " 6";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operacion += "7";
            label1.Text += " 7";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operacion += "8";
            label1.Text += " 8";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacion += "9";
            label1.Text += " 9";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            operacion += "0";
            label1.Text += " 0";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operacion += "/";
            label1.Text += " /";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operacion += "*";
            label1.Text += " X";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            operacion += "+";
            label1.Text += " +";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            operacion += "-";
            label1.Text += " -";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            operacion += ".";
            label1.Text += " .";
            label1.Location = new Point(label1.Location.X - 15, label1.Location.Y);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            
            label2.Text=octave.Execute(operacion);
          
            label2.Location = new Point(originalLocationLabel2.X - (15 * label2.Text.Length), label2.Location.Y);

        }

        private bool IsValidCharacter(char key)
        {
            char[] keys = { '1','2','3','4','5','6','7','8','9','0','+','-','x','/','=','.','X'};

            foreach (char k in keys)
                if (k == key)
                    return true;

            return false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
            label1.Text = "";
            label2.Text = "";
            operacion = "";
            label4.Visible = true;
            label1.Location = originalLocationLabel1;
            label2.Location = originalLocationLabel2;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int length = label1.Text.Length - 1;
            int lengthOp = operacion.Length - 1;
            label1.Location = new Point(label1.Location.X + 15, label1.Location.Y);
            try
            {
                label1.Text = label1.Text.Substring(0, length - 1);
                operacion = operacion.Substring(0, lengthOp);
            }
            catch { };
            
                

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (octave != null)
                {

                    label4.Visible = false;

                    label2.Text = "Loading...";
                    label2.Text = octave.Execute(operacion);
                    label2.Location = new Point(originalLocationLabel2.X - (15 * label2.Text.Length), label2.Location.Y);
              
                }

            }
            catch { label2.Text = ""; }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
