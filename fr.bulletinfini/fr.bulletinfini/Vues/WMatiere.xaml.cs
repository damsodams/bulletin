using fr.bulletinfini.Classes;
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
            matiere.Add(new Matiere( "Java", "Matière"));
            matiere.Add(new Matiere( "Anglais", "Matière"));
            matiere.Add(new Matiere( "Management", "Matière"));
            matiere.Add(new Matiere( "Réseaux", "Catégorie"));
     
            TableMatiere.ItemsSource = matiere;
        }
    }

}
