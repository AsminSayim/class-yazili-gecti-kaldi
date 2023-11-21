using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sinav sinav = new Sinav();

            sinav.yazili1 = Convert.ToDouble(txtYazili1.Text);
            sinav.yazili2 = Convert.ToDouble(txtYazili2.Text);

            label3.Text = "Ortalamanız:" + sinav.Ortalama();


            if (sinav.Ortalama() < 50)
            {
                label4.Text = "Kaldı";
            }
            else
            {
                label4.Text = "Geçti";
            }
        }
    }
}
