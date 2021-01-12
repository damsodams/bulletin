using fr.bulletinfini.Classes;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

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

            matiere.Add(new Matiere(1, "Java", "Matière"));
            matiere.Add(new Matiere(2, "Anglais", "Matière"));
            matiere.Add(new Matiere(3, "Management", "Matière"));
            matiere.Add(new Matiere(4, "Réseaux", "Catégorie"));

            promo.Add(new Promotion(1, "ASI 2019-2021", "2019 - 2021"));
            promo.Add(new Promotion(2, "ASI 2020-2022", "2020 - 2022"));

            eleve.Add(new Eleve(1, "PAYET", "Damien"));
            eleve.Add(new Eleve(2, "PELLETIER", "Florent"));

            CBListeMatiere.ItemsSource = matiere;
            CBListePromotion.ItemsSource = promo;
            TB_ListeEleve.ItemsSource = eleve;

        }

    }
}
