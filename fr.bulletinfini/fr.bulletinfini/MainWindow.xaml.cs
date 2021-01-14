using fr.bulletinfini.Classes;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.IO;
using Microsoft.Win32;

using System.Windows.Navigation;
using MenuItem = fr.bulletinfini.Classes.MenuItem;
using Newtonsoft.Json;

namespace fr.bulletinfini
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly NavigationServiceEx navigationServiceEx;

        public MainWindow()
        {
            this.InitializeComponent();
            this.navigationServiceEx = new NavigationServiceEx();
            this.navigationServiceEx.Navigated += this.NavigationServiceEx_OnNavigated;
            this.HamburgerMenuControl.Content = this.navigationServiceEx.Frame;

            // Navigate to the home page.
            this.Loaded += (sender, args) => this.navigationServiceEx.Navigate(new Uri("Vues/Test.xaml", UriKind.RelativeOrAbsolute));
        }

        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            if (e.InvokedItem is MenuItem menuItem && menuItem.IsNavigation)
            {
             
                this.navigationServiceEx.Navigate(menuItem.NavigationDestination);
            }
        }

        private void NavigationServiceEx_OnNavigated(object sender, NavigationEventArgs e)
        {
            this.HamburgerMenuControl.SelectedItem = this.HamburgerMenuControl
                                                         .Items
                                                         .OfType<MenuItem>()
                                                         .FirstOrDefault(x => x.NavigationDestination == e.Uri);
            this.HamburgerMenuControl.SelectedOptionsItem = this.HamburgerMenuControl
                                                                .OptionsItems
                                                                .OfType<MenuItem>()
                                                                .FirstOrDefault(x => x.NavigationDestination == e.Uri);
        }
           

        private void test()
        {
            List<Promotion> promol = new List<Promotion>();
            Promotion p1 = new Promotion();
            p1.Intitule = "yguy";
            p1.Date = "2020";
            // or when using the NavigationType on menu item
            // this.HamburgerMenuControl.SelectedItem = this.HamburgerMenuControl
            //                                              .Items
            //                                              .OfType<MenuItem>()
            //                                              .FirstOrDefault(x => x.NavigationType == e.Content?.GetType());
            // this.HamburgerMenuControl.SelectedOptionsItem = this.HamburgerMenuControl
            //                                                     .OptionsItems
            //                                                     .OfType<MenuItem>()
            //                                                     .FirstOrDefault(x => x.NavigationType == e.Content?.GetType());

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
            // update back button
            this.GoBackButton.Visibility = this.navigationServiceEx.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
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

        private void GoBack_OnClick(object sender, RoutedEventArgs e)
        {
            this.navigationServiceEx.GoBack();
        }
        /*   try
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
        *
        **
        **
        **
        **
        **
        **
        **
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
            test();*/

    }
}