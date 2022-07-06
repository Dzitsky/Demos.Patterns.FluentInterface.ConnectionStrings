namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class ConnectionStringBuilder
{
    private string? serverName;
    private string? databaseName;
    private string? userName;
    private string? password;

    public ConnectionStringBuilder SetServerName(string serverName)
    {
        this.serverName = serverName;
        return this;
    }

    public ConnectionStringBuilder SetDatabaseName(string databaseName)
    {
        this.databaseName = databaseName;
        return this;
    }

    public ConnectionStringBuilder SetUserName(string userName)
    {
        this.userName = userName;
        return this;
    }

    public ConnectionStringBuilder SetPassword(string password)
    {
        this.password = password;
        return this;
    }

    public string Build()
    {
        return $"Server={serverName};Database={databaseName};User Id={userName};Password={password}";
    }
}