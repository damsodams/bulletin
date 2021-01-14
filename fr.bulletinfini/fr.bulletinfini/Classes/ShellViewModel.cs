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
                NavigationType = typeof(WAccueil),
                NavigationDestination = new Uri("Vues/WAccueil.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.UserGraduateSolid },
                Label = "Promotion",
                NavigationType = typeof(WPromo),
                NavigationDestination = new Uri("Vues/WPromo.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem() 
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.ChalkboardTeacherSolid },
                Label = "Awesome",
                NavigationType = typeof(WMatiere),
                NavigationDestination = new Uri("Vues/WMatiere.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.MarkerSolid },
                Label = "User",
                NavigationType = typeof(WNote),
                NavigationDestination = new Uri("Vues/WNote.xaml", UriKind.RelativeOrAbsolute)
            });
       

            /* this.OptionsMenu.Add(new MenuItem()
             {
                 Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.CogsSolid },
                 Label = "Settings",
                 NavigationType = typeof(SettingsPage),
                 NavigationDestination = new Uri("Views/SettingsPage.xaml", UriKind.RelativeOrAbsolute)
             });
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