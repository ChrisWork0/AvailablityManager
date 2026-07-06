using AvailabilityManager.ViewModels;
using System.Windows;

namespace AvailabilityManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel mvm, bool login = false)
        {
            InitializeComponent();
            mvm.ShowLogin(login, this);
        }
    
        

        
    }
}
