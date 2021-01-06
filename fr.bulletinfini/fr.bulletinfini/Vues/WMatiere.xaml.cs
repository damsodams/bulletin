﻿using fr.bulletinfini.Classes;
using MahApps.Metro.Controls;
using System.Collections.Generic;

namespace Bulletinfini
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WMatiere : MetroWindow
    {
            // InitializeComponent();

            public WMatiere()
            {
                InitializeComponent();
                List<Matiere> matiere = new List<Matiere>();
                matiere.Add(new Matiere(1, "Java", "Matière"));
                matiere.Add(new Matiere(2, "Anglais", "Matière"));
                matiere.Add(new Matiere(3, "Management", "Matière"));
                matiere.Add(new Matiere(4, "Réseaux", "Catégorie"));

                TableMatiere.ItemsSource = matiere;
            }
        }
     
    }
