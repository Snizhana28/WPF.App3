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
using static WPF.App3.Navigator.Navigator;
using WPF.App3.Models;
using WPF.App3.Pages;

namespace WPF.App3.Pages
{
    /// <summary>
    /// Interaction logic for AboutCountry.xaml
    /// </summary>
    public partial class AboutCountry : UserControl
    {
        public AboutCountry(string img, string name, string description, string population, string capital)
        {
            InitializeComponent();
            CountryImg.Source = new BitmapImage(new Uri(img));
            CountryName.Text = name;
            CountryDescription.Text = description;
            CountryPopulation.Text = population;
            CountryCapital.Text = capital;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new CountriesScreen());
        }
    }
}
