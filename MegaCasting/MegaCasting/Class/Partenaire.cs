﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.Class
{
    public class Partenaire
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
        private string fax;

        public string Fax
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
