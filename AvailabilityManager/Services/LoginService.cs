namespace AvailabilityManager.Services;

public class LoginService
{
    private readonly string _connectionString;
    
    public LoginService(string connectionString)
    {
        _connectionString = connectionString;
    }
}