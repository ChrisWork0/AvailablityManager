using AvailabilityManager.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Windows;

namespace AvailabilityManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }


        //TODO: Datenbank-Logik mit Login
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var config = builder.Build();
            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(config);
            services.AddSingleton<MainWindow>(c =>
            {
                var factory = LoggerFactory.Create(b => b.AddConsole(o => o.FormatterName = ConsoleFormatterNames.Simple)
                .AddSimpleConsole(o =>
                {
                    o.ColorBehavior = LoggerColorBehavior.Enabled;
                    o.SingleLine = true;
                    o.TimestampFormat = "[HH:mm:ss] ";
                }));
                ILogger logger = factory.CreateLogger(typeof(MainWindow));

                return new MainWindow(new MainViewModel(logger));
            });

            ServiceProvider = services.BuildServiceProvider();

            var mw = ServiceProvider.GetRequiredService<MainWindow>();
            mw.Show();
        }
    }

}
