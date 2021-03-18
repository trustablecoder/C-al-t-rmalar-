using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_application
{
    public partial class Form1 : Form
    {
        int x; int a;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            x = 2; //sil
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (x == 1) a = 1;
            if (x == 2) a = 2;


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            a = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
  
                Graphics alan = panel1.CreateGraphics();
                if (a == 1) { 
                    alan.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10);
                    
                }
                else if(a == 2)
                {
                    alan.FillEllipse(Brushes.White, e.X, e.Y, 30, 30);
                    
                alan.Dispose();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 1;
        }
    }
}
