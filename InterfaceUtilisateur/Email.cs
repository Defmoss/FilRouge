using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace InterfaceUtilisateur
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Regex reg = new Regex(@"^\w +@[a - zA - Z_] +?\.[a-zA-Z]{2,3}$");
            string pattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{3,4}$";
            
            if (Regex.IsMatch(textBox1.Text, pattern))


            {
                textBox1.BackColor = Color.Green;
                
            }

            else
            {
                textBox1.BackColor = Color.Aqua;
            }

        }


        public bool email()
        {
            bool validing;
           
            string email = textBox1.Text;
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                validing = true;
            else
                validing = false;
            return validing;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool validing = email();

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
            
        
          
         
         
       /*
            string ValidingEmail = (Regex.IsMatch(textBox1.Text, @"^[a-z][0-9a-z.éèàô-]{2,100}[@][a-zéèàô]{2,100}[.][a-z]{2,100}?$")) ? "Adresse valide" : "Adresse invalide";
            MessageBox.Show(ValidingEmail);
        }
        */

            /*private bool ValidMail(string mail_address)
                    {
                        Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
                        return myRegex.IsMatch(mail_address);
                    }

            */





