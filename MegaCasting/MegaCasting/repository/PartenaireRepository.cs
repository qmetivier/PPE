using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.repository
{
    class PartenaireRepository
    {
       // SqlConnection connection = new SqlConnection("Server=localhost;Database=megacasting;Trusted_Connection=True;");
        SqlConnection connection = new SqlConnection("Server=B16-04\\SQLEXPRESS2017;Database=megacasting;Trusted_Connection=True;");
        public List<Partenaire> Select()
        {
            List<Partenaire> partenaires = new List<Partenaire>();
            


            SqlCommand commande = new SqlCommand("SelectPartenaire", connection);
            commande.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader dataReader = commande.ExecuteReader();

            while (dataReader.Read())
            {

                Partenaire partenaire = new Partenaire();
                partenaire.Id = dataReader.GetInt64(0);
                partenaire.Libelle = dataReader.GetString(1);
                partenaire.URL = dataReader.GetString(2);
                partenaire.Adresse = dataReader.GetString(3);
                partenaire.Telephone = dataReader.GetString(4);
                if (!dataReader.IsDBNull(5))
                {
                    partenaire.Fax = dataReader.GetString(5);

                }
                partenaires.Add(partenaire);
            }

            connection.Close();

            return partenaires;
        }
       
        public void Insert(Partenaire partenaire)
        {

            SqlCommand commande = new SqlCommand("InsertPartenaire", connection);
            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@libelle", SqlDbType.NVarChar).Value = partenaire.Libelle;
            commande.Parameters.Add("@URL", SqlDbType.NVarChar).Value = partenaire.URL;
            commande.Parameters.Add("@adresse", SqlDbType.NVarChar).Value = partenaire.Adresse;
            commande.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = partenaire.Telephone;
            commande.Parameters.Add("@fax", SqlDbType.NVarChar).Value = partenaire.Fax;
            connection.Open();

             SqlDataReader dataReader = commande.ExecuteReader();

            connection.Close();
            

        }

        public void Update(Partenaire partenaire)
        {

            SqlCommand commande = new SqlCommand("UpdatePartenaire", connection);
            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@id", SqlDbType.BigInt).Value = partenaire.Id;
            commande.Parameters.Add("@libelle", SqlDbType.NVarChar).Value = partenaire.Libelle;
            commande.Parameters.Add("@URL", SqlDbType.NVarChar).Value = partenaire.URL;
            commande.Parameters.Add("@adresse", SqlDbType.NVarChar).Value = partenaire.Adresse;
            commande.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = partenaire.Telephone;
            commande.Parameters.Add("@fax", SqlDbType.NVarChar).Value = partenaire.Fax;
            connection.Open();

            SqlDataReader dataReader = commande.ExecuteReader();

            connection.Close();


        }

        public void Delete(Int64 Id)
        {

            SqlCommand commande = new SqlCommand("DeletePartenaire", connection);
            commande.CommandType = CommandType.StoredProcedure;

            commande.Parameters.Add("@id", SqlDbType.BigInt).Value = Id;

            connection.Open();

            SqlDataReader dataReader = commande.ExecuteReader();

            connection.Close();


        }

    }
}
