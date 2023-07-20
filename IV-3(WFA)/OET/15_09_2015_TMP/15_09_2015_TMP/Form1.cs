using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15_09_2015_TMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel_vrijeme.Text = DateTime.Now.ToString();
            toolStripStatus_vrijemee.Text = DateTime.Now.ToString();
        }

        private void timer_sat_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_vrijeme.Text = DateTime.Now.ToString();
            toolStripStatus_vrijemee.Text = DateTime.Now.ToString();
        }

        private void txtbox_struja_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_struja.Text != "" && txtbox_napon.Text != "")
            {
                btn_izracunaj_omovzakon.Enabled = true;
            }
            else if (txtbox_struja.Text != "" && txtbox_otpornost.Text != "")
            {
                btn_izracunaj_omovzakon.Enabled = true;
            }
            else
            {
                btn_izracunaj_omovzakon.Enabled = false;
            }
        }

        private void txtbox_napon_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_napon.Text != "" && txtbox_struja.Text != "")
            {
                btn_izracunaj_omovzakon.Enabled = true;
            }
            else if (txtbox_napon.Text != "" && txtbox_otpornost.Text != "")
            {
                btn_izracunaj_omovzakon.Enabled = true;
            }
            else
            {
                btn_izracunaj_omovzakon.Enabled = false;
            }
        }

        private void txtbox_otpornost_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_otpornost.Text != "" && txtbox_napon.Text != "")
            {
                btn_izracunaj_omovzakon.Enabled = true;
            }
            else if (txtbox_otpornost.Text != "" && txtbox_struja.Text != "")
            {
                btn_izracunaj_omovzakon.Enabled = true;
            }
            else
            {
                btn_izracunaj_omovzakon.Enabled = false;
            }
        }

        private void btn_izracunaj_omovzakon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_struja.Text != "" && txtbox_napon.Text != "")
                {
                    txtbox_otpornost.Text = (Convert.ToInt16(txtbox_napon.Text) / Convert.ToInt16(txtbox_struja.Text)).ToString();
                }
                if (txtbox_struja.Text != "" && txtbox_otpornost.Text != "")
                {
                    txtbox_napon.Text = (Convert.ToInt16(txtbox_struja.Text) * Convert.ToInt16(txtbox_otpornost.Text)).ToString();
                }
                if (txtbox_otpornost.Text != "" && txtbox_napon.Text != "")
                {
                    txtbox_struja.Text = (Convert.ToInt16(txtbox_napon.Text) / Convert.ToInt16(txtbox_otpornost.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unijeli ste slovo a trebali ste broj", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radiobtn_serijska_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_r1.Text != "" && txtbox_r2.Text != "")
                {
                    txtbox_rekv.Text = (Convert.ToInt16(txtbox_r1.Text) + Convert.ToInt16(txtbox_r2.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unijeli ste slovo ili neki drugi znak a trebali ste broj", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radiobtn_paralelna_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_r1.Text != "" && txtbox_r2.Text != "")
                {
                    txtbox_rekv.Text = ((Convert.ToInt16(txtbox_r1.Text) * Convert.ToInt16(txtbox_r2.Text)) / (Convert.ToInt16(txtbox_r1.Text) + Convert.ToInt16(txtbox_r2.Text))).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Unijeli ste slovo ili neki drugi znak a trebali ste broj", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
