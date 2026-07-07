using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Windows;
using System.Windows.Controls;
using AvailabilityManager.ViewModels;

namespace AvailabilityManager
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private ILogger _logger;
        private MainViewModel _mainViewModel;
        
        public LoginPage(ILogger logger, LoginViewModel loginViewModel, MainViewModel mainViewModel)
        {
            InitializeComponent();
            _logger = logger;
            _mainViewModel = mainViewModel;
            DataContext = loginViewModel;
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            var mw = App.ServiceProvider.GetRequiredService<MainWindow>();
            var mainPage = new MainPage(_logger, _mainViewModel);
            mw.frame1.Content = mainPage;
        }
    }
}
