using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_tabanli_programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba otomobil1 = new Araba();
            otomobil1.marka = "BMW";
            otomobil1.model = "520";
            otomobil1.uretim_yili = "2020";
            otomobil1.fiyat = 850000;
            lblMarka1.Text = otomobil1.marka;
            lblModel1.Text = otomobil1.model;
            lblUretimYili1.Text = otomobil1.uretim_yili;
            lblFiyat1.Text = otomobil1.fiyat.ToString();
            Araba otomobil2 = new Araba();
            otomobil2.marka = "Renault";
            otomobil2.model = "Megane";
            otomobil2.uretim_yili = "2016";
            otomobil2.fiyat = 250000;
            lblMarka2.Text = otomobil2.marka;
            lblModel2.Text = otomobil2.model;
            lblUretimYili2.Text = otomobil2.uretim_yili;
            lblFiyat2.Text = otomobil2.fiyat.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
