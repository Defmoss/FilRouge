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

namespace WindowsFormsApplication1
{
    public partial class Acces_login : Form
    {
        public Acces_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Acces_login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

       
            Interface_menu maforme = new Interface_menu();
            this.Hide();
            maforme.ShowDialog();
            this.Show();


            /*   Interface_recherche_clients maforme = new Interface_recherche_clients();
            this.Hide();
            maforme.ShowDialog();
            this.Show();
                         */       
    
    }
    }
}
