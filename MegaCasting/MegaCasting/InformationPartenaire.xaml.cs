using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MegaCasting.Class;

namespace MegaCasting
{
    /// <summary>
    /// Logique d'interaction pour InformationPartenaire.xaml
    /// </summary>
    public partial class InformationPartenaire : UserControl
    {
        Partenaire partenaire;
        GestionPartenaire gestionPartenaire;
        List<Partenaire> partenaires;
        bool ajout;
        public InformationPartenaire(List<Partenaire> _partenaires, GestionPartenaire _gestionPartenaire,bool _ajout)
        {
            InitializeComponent();

            ajout = _ajout;
            gestionPartenaire = _gestionPartenaire;
            partenaires = _partenaires;

            if (_ajout)
            {
                partenaire = new Partenaire();
            }
            else
            {
                partenaire = _partenaires[_gestionPartenaire.lvUsers.SelectedIndex];
            }
            TxtBlibelle.Text = partenaire.Libelle.ToString();
            TxtBAdresse.Text = partenaire.Adresse.ToString();
            TxtTel.Text = partenaire.Telephone.ToString();
            TxtBFax.Text = partenaire.Fax.ToString();
            TxtBUrl.Text = partenaire.URL.ToString();
            
           
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {            
            partenaire.Libelle = TxtBlibelle.Text;
            partenaire.Adresse = TxtBAdresse.Text;
            partenaire.Telephone = Int32.Parse(TxtTel.Text);
            partenaire.Fax = Int32.Parse(TxtBFax.Text);
            partenaire.URL = TxtBUrl.Text;
            if (ajout)
            {
                partenaires.Add(partenaire);
            }
            gestionPartenaire.lvUsers.Items.Refresh();
            gestionPartenaire.STKPinformationPartenaire.Children.Clear();
        }
    }
}
