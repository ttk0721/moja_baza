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
    public partial class logowanie : Form
    {
        private const String user = "Tomek"; //SP5IOU
        private const String password = "Kowalski"; //SP5IOU
        public logowanie()
        {
            InitializeComponent();
        } //SP5IOU Missing } This generated compilation errors
            private void button1_Click(object sender, EventArgs e)
            {
            //               timer1.Start(); //SP5IOU Missing Timer1 component
            if (textBox1.Text == user && textBox2.Text == password) //SP5IOU
            {
                this.SetVisibleCore(false); //SP5IOU Hide login form
                textBox1.Text = ""; //SP5IOU User text clean
                textBox2.Text = ""; //SP5IOU Password text clean
                ekran_startowy Form2 = new ekran_startowy();
                Form2.ShowDialog();
                this.SetVisibleCore(true); //SP5IOU Show login form again
//               this.Close(); //SP5IOU Missing closing form command
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
            {
 //               label3.Text = "Window 1 will close in " + ((float)time1 / 10).ToString() + " seconds";
//                time1--;
 //               if (time1 == 0)
                {
//                    Program.interrupt = false;
                    this.Close(); //Close Form1 Form
                }
            }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
  //              if (Program.interrupt)
                    Application.Exit();  //Close application on click window close
            }
        }
    //    }  //SP5IOU This } is not needed anymore This generated compilation errors
}
