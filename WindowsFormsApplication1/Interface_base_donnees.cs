using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
namespace WindowsFormsApplication1
{
    public partial class Interface_base_donnees : Form
{
        public Interface_base_donnees()
        {
            InitializeComponent();
        }

        private void Interface_base_donnees_Load(object sender, EventArgs e)
        {
        string resultat = Global.email;

        ClientDAO Bdconnection = new ClientDAO("server=.; database=materiel_village; Integrated Security=True");    
        listBox2.DisplayMember = "nom_client";
        listBox2.DataSource = Bdconnection.List();

         
        
         }

         private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}