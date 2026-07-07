namespace AvailabilityManager.Models;

public class Appointment
{
    public int CalendarWeek { get; set; }
    public int Year { get; set; }
    public string Monday { get; set; } = "";
    public string Tuesday { get; set; } = "";
    public string Wednesday { get; set; } = "";
    public string Thursday { get; set; } = "";
    public string Friday { get; set; } = "";
    public string Saturday { get; set; } = "";
    public string Sunday { get; set; } = "";
}