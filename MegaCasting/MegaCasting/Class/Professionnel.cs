using System;

namespace MegaCasting.repository
{
    public class Professionnel
    {
        private Int64 id;
       
            
        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string libelle;

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        private string url;

        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int nbrPoste;

        public int NbrPoste
        {
            get { return nbrPoste; }
            set { nbrPoste = value; }
        }

        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public Professionnel()
        {
            libelle = "";
            adresse = "";
            url = "";
            adresse = "";
        }
    }
}