using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CocktailApp
{
    public partial class HomePage : Page, INotifyPropertyChanged
    {
        private bool isPopupOpen;
        public bool IsPopupOpen
        {
            get { return isPopupOpen; }
            set
            {
                if (isPopupOpen != value)
                {
                    isPopupOpen = value;
                    OnPropertyChanged(nameof(IsPopupOpen));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public HomePage()
        {
            InitializeComponent();
            DataContext = this;
        }

        /*private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the RecipesPage
            //NavigationService?.Navigate(new RecipesPage());

        }*/
        private void ViewPassion_Click(object sender, RoutedEventArgs e)
        {
            Passion.IsOpen = true; // Open the popup
            IsPopupOpen = true;
        }
        private void ClosePassion_Click(object sender, RoutedEventArgs e)
        {
            Passion.IsOpen = false; // Close the popup
            IsPopupOpen = false;
        }
        private void ViewCosmo_Click(object sender, RoutedEventArgs e)
        {
            Cosmo.IsOpen = true; // Open the popup
            IsPopupOpen = true;
        }
        private void CloseCosmo_Click(object sender, RoutedEventArgs e)
        {
            Cosmo.IsOpen = false; // Close the popup
            IsPopupOpen = false;
        }
        private void ViewFash_Click(object sender, RoutedEventArgs e)
        {
            Fash.IsOpen = true; // Open the popup
            IsPopupOpen = true;
        }
        private void CloseFash_Click(object sender, RoutedEventArgs e)
        {
            Fash.IsOpen = false; // Close the popup
            IsPopupOpen = false;
        }

    }
}
