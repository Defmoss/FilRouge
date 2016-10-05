using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    public class Client
    {


        public int ref_client { get; set; }
        public string nom_client { get; set; }
        public string prenom_client { get; set; }
        public string sexe_client { get; set; }
        public string date_naiss_client { get; set; }

        public string adress_client {get; set;}

        public string code_postal_client{ get; set; }
        public string telephone_client { get; set; }

        public string mail_client { get; set; }
    }
}
