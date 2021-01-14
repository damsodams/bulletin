using Bulletinfini;
using fr.bulletinfini.Vues;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.ObjectModel;

namespace fr.bulletinfini.Classes
{
    public class ShellViewModel : Prism.Mvvm.BindableBase
    {
        private static readonly ObservableCollection<MenuItem> AppMenu = new ObservableCollection<MenuItem>();
        private static readonly ObservableCollection<MenuItem> AppOptionsMenu = new ObservableCollection<MenuItem>();

        public ObservableCollection<MenuItem> Menu => AppMenu;

        public ObservableCollection<MenuItem> OptionsMenu => AppOptionsMenu;

        public ShellViewModel()
        {
            // Build the menus
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.HomeSolid },
                Label = "Accueil",
                NavigationType = typeof(PHome),
                NavigationDestination = new Uri("Vues/PHome.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.UserGraduateSolid },
                Label = "Promotion",
                NavigationType = typeof(PPromo),
                NavigationDestination = new Uri("Vues/PPromo.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem() 
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.ChalkboardTeacherSolid },
                Label = "Matières",
                NavigationType = typeof(PMatiere),
                NavigationDestination = new Uri("Vues/PMatiere.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.MarkerSolid },
                Label = "Notes",
                NavigationType = typeof(PNote),
                NavigationDestination = new Uri("Vues/PNote.xaml", UriKind.RelativeOrAbsolute)
            });
       

             this.OptionsMenu.Add(new MenuItem()
             {
                 Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.SaveSolid },
                 Label = "Sauvegarde",
                 NavigationType = typeof(PSauvegarde),
                 NavigationDestination = new Uri("Vues/PSauvegarde.xaml", UriKind.RelativeOrAbsolute)
             });/*
             this.OptionsMenu.Add(new MenuItem()
             {
                 Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.InfoCircleSolid },
                 Label = "About",
                 NavigationType = typeof(AboutPage),
                 NavigationDestination = new Uri("Views/AboutPage.xaml", UriKind.RelativeOrAbsolute)
             });*/
        }
    }
}