using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n, x, y, z;
            x = y = 1;
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add(x);
            listBox1.Items.Add(y);
            for(i=1; i <= n - 2; i++)
            {
                z = x + y; listBox1.Items.Add(z);
                x = y; y = z;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
