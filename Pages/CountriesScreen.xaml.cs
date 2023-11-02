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
using WPF.App3.Pages;
using WPF.App3.Models;
using static WPF.App3.Navigator.Navigator;

namespace WPF.App3.Pages
{
    /// <summary>
    /// Interaction logic for AboutScreen.xaml
    /// </summary>
    public partial class CountriesScreen : UserControl
    {
        List<Country> countries;
        public CountriesScreen()
        {
            InitializeComponent();
            countries = new List<Country>();
            //додаємо країни France, Greece, Spain, Italy, Sri Lanka, Portugal
            countries.Add(new Country("https://assets.puzzlefactory.com/puzzle/407/356/original.jpg", "France", "Today, France is an amazing kaleidoscope of historical and cultural monuments, incredible landscapes, local colour, world-famous cuisine, romantic city views, cosy provincial landscapes and wonderful beaches. Finding and booking a tour to France online is worth it just for the opportunity to get lost in Paris. But besides the capital, there are many more fascinating places in the country.", "67.75 million", "Paris"));
            countries.Add(new Country("https://www.state.gov/wp-content/uploads/2023/07/shutterstock_1168009126v2.jpg", "Greece", "This country is considered the cradle of European civilisation. The culture of Greece is so rich and strong that it has influenced many countries that have conquered it. The architectural monuments are filled with the spirit of events described in the works of ancient poets. There is a unique collection of entertainment here, and it's a real crime to choose just one thing. The country is famous for its beaches, good infrastructure, sunny landscapes, colourful islands, and delicious local cuisine.", "10.64 million", "Athens"));
            countries.Add(new Country("https://www.civitatis.com/blog/wp-content/uploads/2023/07/shutterstock_557625622-scaled.jpg", "Spain", "Spain is undoubtedly one of the main cultural centres of Europe. Every year it is visited by more and more tourists. Some come to stroll along the old winding streets, enjoying the architectural monuments and masterpieces of art by great masters, while others come to soak up the sun on some of the best coasts of the Mediterranean and Atlantic Ocean.", "47.42 million", "Madrid"));
            countries.Add(new Country("https://all.accor.com/magazine/imagerie/kartinka-1-5bfb.jpg", "Italy", "The history of Italy is a real world treasure trove. Today, Italy is one of the most popular countries to visit. People buy tours to this sunny country to get in touch with the great past, enjoy traditional dishes known all over the world, relax on beautiful beaches, admire the cosy landscapes of the province and the majestic views of the Alps. ", "59.11 million", "Rome"));
            countries.Add(new Country("https://service4travel.com.ua/wp-content/uploads/turkey-1.jpg", "Turkey", "Turkey is a country with a diverse and fascinating history. Today, the country is a parliamentary democracy. Arab and European cultures are combined in an amazing way. And this mix is very fascinating to explore.Today, Turkey is one of the most popular tourist destinations. There are leisure options for different tastes. In the cities, you will find fascinating man-made and natural sights, comfortable accommodation and clean beaches with golden sand.", "84.78 million", "Ankara"));
            countries.Add(new Country("https://www.wapititravel.com/blog/wp-content/uploads/2020/02/Madeira_Portugal.jpg", "Portugal", "The history of this country is closely linked to events in the Iberian Peninsula, Europe and the New World. The rich history, architectural monuments, picturesque coastline with beaches for every taste, landscapes with olive groves, plains, mountains, vineyards, wheat fields, views of medieval cities encourage many travellers to find and choose a tour to Portugal online.", "10.33 million", "Lisbon"));
            LVCounties.ItemsSource = countries;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var country = (sender as StackPanel).DataContext as Country;
            NavigatorObject.Switch(new AboutCountry(country.Img, country.Name, country.Description, country.Population, country.Capital));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeScreen());
        }
    }
}
