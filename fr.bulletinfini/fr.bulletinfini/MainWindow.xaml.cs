using Bulletinfini;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            WMatiere m = new WMatiere();
            m.Show();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog Browser = new Microsoft.Win32.OpenFileDialog();
            Browser.Title = "Selectionner votre fichier de données";
            Browser.DefaultExt = ".json";
            Nullable<bool> result = Browser.ShowDialog();
            if (result == true)
            {
                string filename = Browser.FileName;
                MessageBox.Show(filename);
            }
        }

        private void Click_GenerateNewFile(object sender, RoutedEventArgs e)
        {

        }
    }
}
