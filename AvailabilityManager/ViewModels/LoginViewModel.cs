using System.Reflection.Metadata;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;

namespace AvailabilityManager.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private ILogger _logger;
        

        public LoginViewModel(ILogger logger) 
        {
            _logger = logger;
        }
        
        public void ShowLogin(bool login, MainWindow window,  MainViewModel mainViewModel)
        {
            var loginPage = new LoginPage(_logger, this, mainViewModel);
            var mainPage = new MainPage(_logger, mainViewModel);
            if (!login)
                window.frame1.Content = loginPage;

            else
                window.frame1.Content = mainPage;
        }
    }
}
