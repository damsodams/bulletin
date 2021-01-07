using Bulletinfini;
using fr.bulletinfini.Classes;
using fr.bulletinfini.Vues;
using MahApps.Metro.Controls;
using Newtonsoft.Json;
using System;
using System.Windows;

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
            WNote n = new WNote();
            n.Show();
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
                Promotion deserializedProduct = JsonConvert.DeserializeObject<Promotion>(System.IO.File.ReadAllText(Browser.FileName));
                Console.WriteLine(deserializedProduct);
                //List<Promotion> deserializedProduct = JsonConvert.DeserializeObject<List<Promotion>>(output);
            }
        }

        private void Click_GenerateNewFile(object sender, RoutedEventArgs e)
        {
            Promotion p1 = new Promotion(1, "ASI 2019-2021", "2019-2021");
            string json = JsonConvert.SerializeObject(p1, Formatting.Indented);
            Promotion deserializedProduct = JsonConvert.DeserializeObject<Promotion>(json);

            Console.WriteLine(json);

        }
    }
}
