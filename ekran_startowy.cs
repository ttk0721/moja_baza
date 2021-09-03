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
    public partial class ekran_startowy : Form
    {
        public ekran_startowy()
        {
            InitializeComponent();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("moja_baza\n Wersja 1.1.0\n(c) działają przyciski na ekranie głównym");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false); //SP5IOU Hide login form
            szybki_notatnik Form2 = new szybki_notatnik();
            Form2.ShowDialog();
            this.SetVisibleCore(true); //SP5IOU Show login form again
                                       //               this.Close(); //SP5IOU Missing closing form command
        }
    }
}
