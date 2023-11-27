using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.isim = "Büşra Merve Ekmen";
            hasta.yas = 15;
            hasta.tcNumara = 11111111111;
            hasta.telefon=5555555555;
            hasta.yakini = "Arkadaş";
            hasta.bakiciAdi = "Meryem Aynur";

            label1.Text = hasta.isim + "    " + hasta.yas + "    " + hasta.tcNumara + "    " + hasta.telefon + "    " + hasta.yakini + "    " + hasta.bakiciAdi + "    ";
             
        }
    }
}
