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

namespace Browser
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Uri> Historique;
        int IndexHistorique;
        bool DepuisHistorique;

        public MainWindow()
        {
            Historique = new List<Uri>();
            IndexHistorique = 0;
            InitializeComponent();
            RunAddress("http://www.google.com");
            webBrowser.Navigated += new NavigatedEventHandler(Browser_Navigated);
        }

        public void RunAddress(string url)
        {
            textBoxURL.Text = url;
            webBrowser.Navigate(url);
            Historique.Add(new Uri(url));
            IndexHistorique = Historique.Count;

            string listURL = "";
            foreach (var currentURL in Historique)
            {
                listURL += currentURL.ToString();
                listURL += System.Environment.NewLine;
            }
            textBlockHistorique.Text = listURL;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            RunAddress(textBoxURL.Text);
        }

        private void PrevBotton_Click(object sender, RoutedEventArgs e)
        {
            if (IndexHistorique > 1)
            {
                IndexHistorique--;
                DepuisHistorique = true;
                webBrowser.Navigate(Historique[IndexHistorique - 1]);
                UpdateNavButtons();
            }
        }

        private void FrwdBotton_Click(object sender, RoutedEventArgs e)
        {
            if (IndexHistorique < Historique.Count)
            {
                IndexHistorique++;
                DepuisHistorique = true;
                webBrowser.Navigate(Historique[IndexHistorique - 1]);
                UpdateNavButtons();
            }
        }

        private void UpdateNavButtons()
        {
            PrevBotton.IsEnabled = IndexHistorique > 1;
            FrwdBotton.IsEnabled = IndexHistorique < Historique.Count;
        }

        private void Browser_Navigated(object sender, NavigationEventArgs e)
        {
            if (!DepuisHistorique)
            {
                if (IndexHistorique < Historique.Count)
                {
                    Historique.RemoveRange(IndexHistorique, Historique.Count - IndexHistorique);
                }

                Historique.Add(e.Uri);
                IndexHistorique++;
                UpdateNavButtons();
            }

            DepuisHistorique = false;
        }
    }
}
