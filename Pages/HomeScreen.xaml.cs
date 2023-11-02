using System.Windows.Controls;
using static WPF.App3.Navigator.Navigator;
using WPF.App3.Pages;

namespace WPF.App3.Pages
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.Switch(new CountriesScreen());
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.Switch(new SignUpScreen());
        }
    }
}
