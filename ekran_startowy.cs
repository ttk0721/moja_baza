using System;
using System.Diagnostics;
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

        private void button2_Click_1(object sender, EventArgs e)// program dla drugiego przycisku na ekranie starowym. (okienko informacyjne)
        {
            MessageBox.Show("moja_baza\n Wersja 1.2.1.1\n(c) Dodano kalkulator");
        }

        private void button1_Click(object sender, EventArgs e)// tu jest miejse na prograam pierwszego przycisku od lewej na ekranie startowym.(prejście do szybkiego notatnika)
        {
            this.SetVisibleCore(false); //SP5IOU Hide login form
            szybki_notatnik Form2 = new szybki_notatnik();
            Form2.ShowDialog();
            this.SetVisibleCore(true); //SP5IOU Show login form again
                                       //               this.Close(); //SP5IOU Missing closing form command
        }

        private void button3_Click(object sender, EventArgs e)// tu jest miejse na prograam trzeciego przycisku od lewej na ekranie startowym.
        {
            Call_Program.CallKalkulator();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Call_Program.CallJitsi();
//        "https://meet.jit.si/ciekawe_projekty"
        }
    }
}
