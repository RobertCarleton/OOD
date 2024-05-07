using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CocktailApp
{
    public partial class RecipesPage : Page
    {
        public RecipesPage()
        {
            //InitializeComponent();
        }

        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the RecipesPage
            NavigationService?.Navigate(new RecipesPage());
        }

    }
}
