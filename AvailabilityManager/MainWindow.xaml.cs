using System.Windows;

namespace AvailabilityManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
        // If LoggedIn in Database is false, do this
        public void ShowLogin(bool login)
        {
            var loginPage = new LoginPage();
            var mainPage = new MainPage();
            if (!login)
                frame1.Content = loginPage;

            else
                frame1.Content = mainPage;
        }

        
    }
}
