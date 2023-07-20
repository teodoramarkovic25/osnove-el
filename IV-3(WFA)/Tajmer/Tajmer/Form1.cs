using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tajmer
{
    public partial class Form1 : Form
    {
        float sekunde = 0;
        float minute = 0;
        float sati = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekunde = sekunde + 0.5f;
            if(sekunde >= 60)
            {
                sekunde = 0;
                minute++;
                if(minute >= 60)
                {
                    minute = 0;
                    sati++;
                    if(sati > 23)
                    {
                        sati = 0;
                    }
                }
            }
            toolStripLabel1.Text = sati.ToString() + " : " + minute.ToString() + " :" + sekunde.ToString();
        }
    }
}