using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafik_cizdirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, f, faz, w, p, t = 0d, v;
            a = Convert.ToDouble(textBox1.Text);
            f = Convert.ToDouble(textBox2.Text);
            faz = Convert.ToDouble(textBox3.Text);
            w = 2 * Math.PI * f;
            faz *= Math.PI / 180; //derece girilen değeri radyana dönüştürmek için.
            p = 1 / f;
            chart1.Series[0].Points.Clear();
            while ( t <= p)
            {
                v = a * Math.Sin(w * t + faz);
                chart1.Series[0].Points.AddXY(t, v);
                t += p / 600;

            }


        }
    }
}
