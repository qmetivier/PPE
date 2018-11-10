using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.Class
{
    public class Partenaire
    {
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

        private int? telephone;

        public int? Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private int? fax;

        public int? Fax
        {
            get { return fax; }
            set { fax = value; }
        }

       public Partenaire() {
            libelle = "";
            adresse = "";
            url = "";
            adresse = "";
        }

    }
}
