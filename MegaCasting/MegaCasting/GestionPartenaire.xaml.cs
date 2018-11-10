﻿using System;
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
using System.Windows.Shapes;
using MegaCasting.Class;
namespace MegaCasting
{
    /// <summary>
    /// Logique d'interaction pour GestionPartenaire.xaml
    /// </summary>
    public partial class GestionPartenaire : Window
    {
        List<Partenaire> partenaires;
        public GestionPartenaire(List<Partenaire> _partenaires)
        {
            partenaires = _partenaires;

            InitializeComponent();

            lvUsers.ItemsSource = partenaires;
            lvUsers.Items.Refresh();


        }

        private void lvUsers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            STKPinformationPartenaire.Children.Clear();
            InformationPartenaire informationPartenaire = new InformationPartenaire(partenaires, this,false);
            STKPinformationPartenaire.Children.Add(informationPartenaire);
            
            


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            STKPinformationPartenaire.Children.Clear();
            InformationPartenaire informationPartenaire = new InformationPartenaire(partenaires, this, true);
            STKPinformationPartenaire.Children.Add(informationPartenaire);
            

        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            

            if (lvUsers.SelectedIndex >=0 && lvUsers.SelectedIndex < partenaires.Count)
            {
                STKPinformationPartenaire.Children.Clear();
                partenaires.Remove(partenaires[lvUsers.SelectedIndex]);
                lvUsers.Items.Refresh();
            }

        }
    }
}
