using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMP_13_3_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(izabrano());
        }

        private string izabrano()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rdb = (RadioButton)ctrl;

                    if (rdb.Checked)
                        return rdb.Text;
                }
            }

            return "";
        }
    }
}
