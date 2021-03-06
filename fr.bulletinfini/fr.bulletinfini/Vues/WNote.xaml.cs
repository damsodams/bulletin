﻿using fr.bulletinfini.Classes;
using MahApps.Metro.Controls;
using System.Collections.Generic;

namespace fr.bulletinfini.Vues
{
    /// <summary>
    /// Logique d'interaction pour WNote.xaml
    /// </summary>
    public partial class WNote : MetroWindow
    {
        public WNote()
        {
            InitializeComponent();
            List<Matiere> matiere = new List<Matiere>();
            List<Promotion> promo = new List<Promotion>();
            List<Eleve> eleve = new List<Eleve>();

            matiere.Add(new Matiere( "Java", "Matière"));
            matiere.Add(new Matiere( "Anglais", "Matière"));
            matiere.Add(new Matiere( "Management", "Matière"));
            matiere.Add(new Matiere( "Réseaux", "Catégorie"));

         //   promo.Add(new Promotion(1, "ASI 2019-2021", "2019 - 2021"));
           // promo.Add(new Promotion(2, "ASI 2020-2022", "2020 - 2022"));

            eleve.Add(new Eleve( "PAYET", "Damien"));
            eleve.Add(new Eleve( "PELLETIER", "Florent"));

            CBListeMatiere.ItemsSource = matiere;
            CBListePromotion.ItemsSource = promo;
            TB_ListeEleve.ItemsSource = eleve;

        }

    }
}
