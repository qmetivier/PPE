using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaCasting.repository
{
    class ProfessionnelRepository
    {

        public List<Professionnel> Select()
        {
            List<Professionnel>  professionnels = new List<Professionnel>();
            SqlConnection connection = new SqlConnection("Server=localhost;Database=megacasting;Trusted_Connection=True;");


            SqlCommand commande = new SqlCommand("SelectProfessionnel",connection);
            commande.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader dataReader = commande.ExecuteReader();

            while (dataReader.Read())
            { 

                Professionnel professionnel = new Professionnel();
                professionnel.Id = dataReader.GetInt64(0);
                professionnel.Libelle = dataReader.GetString(1);
                professionnel.URL = dataReader.GetString(2);
                professionnel.Adresse = dataReader.GetString(3);
                professionnel.Email = dataReader.GetString(4);
                professionnel.Telephone = dataReader.GetString(5);
                professionnel.Fax = dataReader.GetString(6);
                professionnel.NbrPoste = dataReader.GetInt32(7);

                professionnels.Add(professionnel);
            }

            connection.Close();

            return professionnels;
        }
        
    }
}