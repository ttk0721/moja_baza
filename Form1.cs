using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moja_baza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            private void button1_Click(object sender, EventArgs e)
            {
                timer1.Start();
                Form2 Form2 = new Form2();
                Form2.ShowDialog();
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                label3.Text = "Window 1 will close in " + ((float)time1 / 10).ToString() + " seconds";
                time1--;
                if (time1 == 0)
                {
                    Program.interrupt = false;
                    this.Close(); //Close Form1 Form
                }
            }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (Program.interrupt)
                    Application.Exit();  //Close application on click window close
            }
        }
    }
}
