using Bulletinfini;
using fr.bulletinfini.Classes;
using fr.bulletinfini.Vues;
using MahApps.Metro.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace fr.bulletinfini
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog Browser = new Microsoft.Win32.OpenFileDialog();
            Browser.Title = "Selectionner votre fichier de données";
            Browser.DefaultExt = ".json";
            Browser.Filter = "Json Files (*.json)|*.json";
            Browser.FilterIndex = 1;

            Nullable<bool> result = Browser.ShowDialog();
            if (result == true)
            {
                try
                {
                    //Test de deserialization
                    List <Promotion> deserializedProduct = JsonConvert.DeserializeObject<List<Promotion>>(System.IO.File.ReadAllText(Browser.FileName));
                    //Sauvegarde du chemin
                    GenerateConfigurationFile(Browser.FileName);
                    //Copy du json en local 
                    System.IO.File.WriteAllText(@Directory.GetCurrentDirectory() + "\\jsondb.json", System.IO.File.ReadAllText(Browser.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Le fichier fourni est corompu, \n Merci de forunir un Fichier valide", "Erreur", MessageBoxButton.OK);
                }
            }
        }

        private void Click_GenerateNewFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Séléctionner l'emplacement du fichier";
            saveFileDialog.DefaultExt = ".json";
            saveFileDialog.Filter = "Json Files (*.json)|*.json";
            saveFileDialog.FileName = "bddjson.json";
            saveFileDialog.FilterIndex = 1;
            Nullable<bool> result = saveFileDialog.ShowDialog();
            if(result == true)
            {
                GenerateConfigurationFile(saveFileDialog.FileName);
                // Appel de la novelle page
            }
            test();
        }

        private void test()
        {
            List<Promotion> promol = new List<Promotion>();
            Promotion p1 = new Promotion();
            p1.Intitule = "yguy";
            p1.Date = "2020";

            Eleve e1 = new Eleve();
            e1.Nom = "Damien";
            e1.Promotion = p1;
            
            
            Matiere m1 = new Matiere();
            m1.Nom = "math";
            m1.Promotion = p1;
            m1.Type = "categorie";

            Note n1 = new Note();
            n1.Eleve = e1;
            n1.Coefficient = "3";
            n1.Matiere = m1;

            p1.Eleves.Add(e1);
            p1.Matieres.Add(m1);
            m1.Notes.Add(n1);
            e1.Notes.Add(n1);
            promol.Add(p1);

            //    Console.WriteLine(json);


            System.IO.File.WriteAllText(@"C:\Users\Damien\Desktop\test1.json", JsonConvert.SerializeObject(promol, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
        }

        private void WindowLoad(object sender, RoutedEventArgs e)
        {
            String ProjectPath = Directory.GetCurrentDirectory() + "\\jsondb.json";
            Console.WriteLine(ProjectPath);
            if (File.Exists(ProjectPath))
            {
                
                MessageBoxResult result = MessageBox.Show("Un fichier de donnée du à été retrouvé, souhaitez vous l'utiliser", "Reprendre ? ", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    //JE lance l'appli sans rien faire
                }
            }
        }
        private void GenerateConfigurationFile(String src)
        {
            System.IO.File.WriteAllText(@Directory.GetCurrentDirectory() + "\\config.txt", src);
        }
    }
}
