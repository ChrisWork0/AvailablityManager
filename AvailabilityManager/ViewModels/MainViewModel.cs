using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;

namespace AvailabilityManager.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private ILogger _logger;
    
    public MainViewModel(ILogger logger, string name)
    {
        _logger = logger;
        WelcomeMessage = $"Welcome {name}!";
        CurrentWeek = SetCurrentWeek();
    }

    [ObservableProperty] private string _mask = "Verfügbarkeiten";
    
    [ObservableProperty]
    private string _welcomeMessage;

    [ObservableProperty] 
    private string _currentWeek;

    [ObservableProperty] private string _monday;
    [ObservableProperty] private string _tuesday;
    [ObservableProperty] private string _wednesday;
    [ObservableProperty] private string _thursday;
    [ObservableProperty] private string _friday;
    [ObservableProperty] private string _saturday;
    [ObservableProperty] private string _sunday;
    
    private string SetCurrentWeek()
    {
        DateTime now = DateTime.Now;
        int cw = ISOWeek.GetWeekOfYear(now);
        int year = ISOWeek.GetYear(now);
        if (now.DayOfWeek == DayOfWeek.Sunday)
            cw++;

        DateTime from = ISOWeek.ToDateTime(year, cw, DayOfWeek.Monday);
        DateTime to = ISOWeek.ToDateTime(year, cw, DayOfWeek.Sunday);
        
        SetDates(from, to);

        return $"KW {cw} ({from:dd.MM.yy} - {to:dd.MM.yy})";
    }

    private void SetDates(DateTime from, DateTime to)
    {
        List<DateTime> dates = new List<DateTime>();
        for (var i = from;  i <= to; i = i.AddDays(1))
            dates.Add(i);
        
        Monday = $"{dates[0]:dd.MM.}  Montag:";
        Tuesday = $"{dates[1]:dd.MM.}  Dienstag:";
        Wednesday = $"{dates[2]:dd.MM.}  Mittwoch:";
        Thursday = $"{dates[3]:dd.MM.}  Donnerstag:";
        Friday = $"{dates[4]:dd.MM.}  Freitag:";
        Saturday = $"{dates[5]:dd.MM.}  Samstag:";
        Sunday = $"{dates[6]:dd.MM.}  Sonntag:";
    }
}