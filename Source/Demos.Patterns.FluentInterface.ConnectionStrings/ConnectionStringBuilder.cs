namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class ConnectionStringBuilder
{
    private string? serverName;
    private string? databaseName;
    private string? userName;
    private string? password;

    public void SetServerName(string serverName)
    {
        this.serverName = serverName;
    }

    public void SetDatabaseName(string databaseName)
    {
        this.databaseName = databaseName;
    }

    public void SetUserName(string userName)
    {
        this.userName = userName;
    }

    public void SetPassword(string password)
    {
        this.password = password;
    }

    public string Build()
    {
        return $"Server={serverName};Database={databaseName};User Id={userName};Password={password}";
    }
}