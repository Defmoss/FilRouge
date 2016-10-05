using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
 

namespace WindowsFormsApplication3
{
    public partial class Catalogue : Form
    {
        p

        public Catalogue()
        {
            InitializeComponent();
        }



        private void Produit_Load(object sender, EventArgs e)
        {

            /*  ClientDAO database = new ClientDAO("server=.; database=materiel_village; Integrated Security=True");
                 listBox1.DisplayMember = "Nom";
                 listBox1.DataSource = database.List();

                //    SqlCommand requete = new SqlCommand
                }

                */
            Interface_recherche_client maforme = new Interface_recherche_client();
            this.Hide();
            maforme.Show();


        }
        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            // listBox1.Items.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    internal class Interface_recherche_clients



    {

            {
                {

                    /*  ClientDAO database = new ClientDAO("server=.; database=materiel_village; Integrated Security=True");
                         listBox1.DisplayMember = "Nom";
                         listBox1.DataSource = database.List();

                        //    SqlCommand requete = new SqlCommand
                        }

                        */
                    Interface_recherche_client maforme = new Interface_recherche_client();
                    this.Hide();
        maforme.Show();







                }
}
        }

        internal void show()
{
    throw new NotImplementedException();
}


    }
}