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

namespace WPF.App3.Pages
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUpScreen : UserControl
    {
        const string UserLogin = "admin";
        const string UserPassword = "admin";
        public SignUpScreen()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                NavigatorObject.Switch(new HomeScreen());
        }

        private void Button_Click_login(object sender, RoutedEventArgs e)
        {
            if(tbLogin.Text == UserLogin && tbPassword.Password == UserPassword)
            {
                NavigatorObject.Switch(new HomeScreen());
                MessageBox.Show("You are logged in");
            }
            else if(tbLogin.Text == "" || tbPassword.Password == "")
                MessageBox.Show("Please enter login and password");
            else
                NavigatorObject.Switch(new ErrorScreen());
        }
    }
}
