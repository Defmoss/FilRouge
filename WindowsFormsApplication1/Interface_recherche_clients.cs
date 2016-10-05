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
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Microsoft.SqlServer.Server;
using Classes;

namespace WindowsFormsApplication1
{
    public partial class Interface_recherche_clients : Form
    {
        ClientDAO db = new ClientDAO("server=.;database=materiel_village;integrated security=true");
        bool nom_, prenom_, sexe_, date_, adress_, code_, tel_, mail_;

        public object True { get; private set; }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        public Interface_recherche_clients()
        {
            InitializeComponent();
        }

        private void interface_recherche_clients_Load(object sender, EventArgs e)
        {

            // ClientDAO database = new ClientDAO("server=.; database=materiel_village; Integrated Security=True");
            // textBox8.DisplayMember = "Nom";
            // textBox8.DataSource = database.List();

          }

          private void label8_Click(object sender, EventArgs e)
          {

          }
 
          private void button3_Click(object sender, EventArgs e)
          {

         // Call for a global class created in a specific class file

           Global.email = mail.Text;

         

           string pattern = @"^\w+@[a-zA-Z_]+?.[a-zA-Z]{2,3}$";

            if (Regex.IsMatch(mail.Text, pattern))
            {
                mail.BackColor = Color.Green;
                mail_ = true;
            
            }
            else
            {
            mail.BackColor = Color.Red;
                mail_ = false;
            }

            // Verif sur nom_client
            Regex NomPattern =new Regex(@"^[A-Za-z]+$");
            if (NomPattern.IsMatch(nom.Text))
            {
             nom.BackColor = Color.Green;
                nom_ = true;
            }
            else
            { 
            nom.BackColor = Color.Red;
                nom_ = false;
            }
            
            
            // Verif sur prenom_client 
            Regex PrenomPattern = new Regex(@"^[A-Za-z]+$");
            if (PrenomPattern.IsMatch(prenom.Text))
            {
            prenom.BackColor = Color.Green;
                prenom_ = true;
            }
            else
            {
            prenom.BackColor = Color.Red;
                prenom_ = false;

            }

            
            // Verif sur sexe_client
           Regex SexePattern = new Regex(@"^([H||F||h||f]){1}$");
           if (SexePattern.IsMatch(sexe.Text))
           {
           sexe.BackColor = Color.Green;
                sexe_ = true;
           }
           else
           {
           sexe.BackColor = Color.Red;
                sexe_ = false;
           }


            // Verif sur date_naiss_client
           Regex DatePattern = new Regex (@"^([0-9]{1,2})-([0-9]{1,2})-([0-9]{1,4})$");
           if (DatePattern.IsMatch(date_naiss.Text))
           {
           date_naiss.BackColor = Color.Green;
                date_ = true;
           }
           else
           {
           date_naiss.BackColor = Color.Red;
                date_ = false;
            }

          
           // Verif sur adress_client
           Regex AdressPattern = new Regex (@"^([0-9a-z'àâéèêôùûçÀÂÉÈÔÙÛÇ\s-]{1,50})$");
           if (AdressPattern.IsMatch(adress.Text))
           {
           adress.BackColor = Color.Green;
                adress_ = true;
           }
           else
           {
           adress.BackColor = Color.Red;
                adress_ = false;
           }


        // Verif sur code_postal_client
          Regex CodePattern =new Regex (@"^[0-9]{5}$");
          if (CodePattern.IsMatch(code_postal.Text))
           {
           code_postal.BackColor = Color.Green;
                code_ = true;
           }
           else
           {
           code_postal.BackColor = Color.Red;
                code_ = false;
           }


            // Verif sur telephone_client
            Regex TelephonePattern = new Regex (@"^[0-9]{10}$");
            if (TelephonePattern.IsMatch(telephone.Text))
            {
            telephone.BackColor = Color.Green;
                tel_ = true;

            }
            else
            {
            telephone.BackColor = Color.Red;
                tel_ = false;
            }
            if(nom_==false||prenom_ == false ||sexe_ == false ||date_ == false ||adress_ == false ||code_ == false ||tel_ == false ||mail_ == false)
            {
                button1.Enabled = false;
            }else
            {
                button1.Enabled = true;
            }

}

            private void textBox8_TextChanged(object sender, EventArgs e)
           {

           }

          private void button1_Click(object sender, EventArgs e)
          {
            Client cli = new Client();
            cli.ref_client = Convert.ToInt32(refClient.Text);
            cli.adress_client = adress.Text;
            cli.code_postal_client = code_postal.Text;
            cli.date_naiss_client = date_naiss.Text;
            cli.mail_client = mail.Text;
            cli.nom_client = nom.Text;
            cli.prenom_client = prenom.Text;
            cli.sexe_client = sexe.Text;
            cli.telephone_client = telephone.Text;
            db.Insert(cli);
          
         Interface_base_donnees maforme = new Interface_base_donnees();
         this.Hide();
         maforme.ShowDialog();
         this.Show();

          }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
