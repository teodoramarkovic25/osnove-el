using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBooxUsername.Text == "Admin" && txtBoxPassword.Text == "lozinka1234")
            {
                string pol;
                if(radioButton1.Checked)
                {
                    pol = "Pol: Muski";
                }
                else
                {
                    pol = "Pol: Zenski";
                }
                MessageBox.Show("Uspjesno ste se logovali..." + pol, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBooxUsername.Clear();
                txtBoxPassword.Clear();
            }
            else
            {
                MessageBox.Show("Pogresno logovanje", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnSakrij_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxPassword.PasswordChar = '*';
        }

        private void btnSakrij_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPassword.PasswordChar = '\0';
        }
    }

   
}
