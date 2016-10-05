using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace Classes
{
    public class ClientDAO
    {

        SqlConnection connect;
        public ClientDAO(string phrase)
        {
            connect = new SqlConnection(phrase);
        }

        public Client Find(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client where cli_id=" + id, connect);
            SqlDataReader lecture = requete.ExecuteReader();
            Client cli = new Client();
            if (lecture.Read())
            {
                //cli.Id = id;
                cli.ref_client = Convert.ToInt32(lecture["cli_id"]);
                cli.nom_client = lecture["nom_client"].ToString();
                cli.prenom_client = lecture["prenom_client"].ToString();
                cli.sexe_client = lecture["sexe_client"].ToString();
                cli.date_naiss_client = lecture["date_naiss_client"].ToString();
                cli.adress_client = lecture["adress_client"].ToString();
                cli.code_postal_client = lecture["code_postal_client"].ToString();
                cli.telephone_client = lecture["telephone_client"].ToString();
                cli.mail_client = lecture["mail_client"].ToString();
            }

            connect.Close();
            return cli;

        }

        public List<Client> List()
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from Clients ", connect);
            SqlDataReader lecture = requete.ExecuteReader();
            List<Client> liste = new List<Client>();
            while (lecture.Read())
            {
                Client cli = new Client();
                // cli.ref_client = Convert.ToInt32(lecture["cli_id"]);
                cli.prenom_client = lecture["prenom_client"].ToString();
                cli.nom_client = lecture["nom_client"].ToString();
                cli.sexe_client = lecture["sexe_client"].ToString();
                cli.date_naiss_client = lecture["date_naiss_client"].ToString();
                cli.adress_client = lecture["adress_client"].ToString();
                cli.code_postal_client = lecture["code_postal_client"].ToString();
                cli.telephone_client = lecture["telephone_client"].ToString(); ;
                cli.mail_client = lecture["mail_client"].ToString();


                liste.Add(cli);
            }

            connect.Close();
            return liste;
        }

        public void Delete(Client cli)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("delete from client where cli_id =" + cli.ref_client, connect);
            requete.ExecuteNonQuery();
            connect.Close();
        }

        public void Insert(Client cli)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("insert into Clients (ref_client,nom_client,prenom_client,sexe_client,adress_client,code_postal_client,telephone_client,mail_client) values (@ref,@nom,@prenom,@sexe,@adress,@code_postal,@telephone,@mail)", connect);
            requete.Parameters.AddWithValue("@ref", cli.ref_client);
            requete.Parameters.AddWithValue("@nom", cli.nom_client);
            requete.Parameters.AddWithValue("@prenom", cli.prenom_client);
            requete.Parameters.AddWithValue("@sexe", cli.sexe_client);
           // requete.Parameters.AddWithValue("@date", cli.date_naiss_client);
            requete.Parameters.AddWithValue("@adress", cli.adress_client);
            requete.Parameters.AddWithValue("@code_postal", cli.code_postal_client);
            requete.Parameters.AddWithValue("@telephone", cli.telephone_client);
            requete.Parameters.AddWithValue("@mail", cli.mail_client);


            requete.ExecuteNonQuery();
            connect.Close();
        }

        public void Update(Client cli)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("update client set nom_client = @nom, prenom_client = @prenom, sexe_client = @sexe, date_naiss = @date, adress_client = @adress,code_postal_client = @code_postal, telephone_client = @telephone, mail_client = @mail where cli_id = @ref", connect);
            requete.Parameters.AddWithValue("@ref", cli.ref_client);
            requete.Parameters.AddWithValue("@nom", cli.nom_client);
            requete.Parameters.AddWithValue("@prenom", cli.prenom_client);
            requete.Parameters.AddWithValue("@sexe", cli.sexe_client);
            requete.Parameters.AddWithValue("@date", cli.date_naiss_client);
            requete.Parameters.AddWithValue("@adress", cli.adress_client);
            requete.Parameters.AddWithValue("@code_postal", cli.code_postal_client);
            requete.Parameters.AddWithValue("@telephone", cli.telephone_client);
            requete.Parameters.AddWithValue("@mail", cli.mail_client);

            requete.ExecuteNonQuery();
            connect.Close();
        }


    }
}