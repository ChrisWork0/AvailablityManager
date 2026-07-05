using System.Windows;
using System.Windows.Controls;

namespace AvailabilityManager
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            var mw = new MainWindow();
            var mainPage = new MainPage();
            mw.frame1.Content = mainPage;
        }
    }
}
