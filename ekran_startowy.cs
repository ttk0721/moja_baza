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
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("moja_baza\n Wersja 1.0\n(c) ...");
        }
    }
}
