using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace AvailabilityManager.Services;

public class LoginService
{
    private readonly string _connectionString;
    private ILogger _logger;
    
    
    public LoginService(string connectionString, ILogger logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    private SqliteConnection ConnectToDatabase()
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        return connection;
    }
    
    public string CheckLogin()
    {
        string name = "";
        using SqliteConnection connection = ConnectToDatabase();
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = """
                              SELECT * FROM User WHERE LoggedIn = 1
                              """;
        using var reader = command.ExecuteReader();
        while (reader.Read())
            name =  reader.GetString(reader.GetOrdinal("Name"));
        
        return name;
    }
}