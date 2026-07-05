using Microsoft.Extensions.Logging;

namespace AvailabilityManager.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private ILogger _logger;

        public MainViewModel(ILogger logger) 
        {
            _logger = logger;
        }

        // If LoggedIn in Database is false, do this
        public void ShowLogin(bool login, MainWindow window)
        {
            var loginPage = new LoginPage();
            var mainPage = new MainPage();
            if (!login)
                window.frame1.Content = loginPage;

            else
                window.frame1.Content = mainPage;
        }
    }
}
