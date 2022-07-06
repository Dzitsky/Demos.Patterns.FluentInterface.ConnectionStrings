using System.Text;

namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class ConnectionStringBuilder
{
    private string? serverName;
    private string? databaseName;
    private string? userName;
    private string? password;
    private bool isTrustedConnection;

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

    public ConnectionStringBuilder SetTrustedConnection()
    {
        isTrustedConnection = true;
        return this;
    }

    public string Build()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Server={serverName};Database={databaseName};");

        if (isTrustedConnection)
        {
            stringBuilder.Append("Trusted_Connection=True;");
        }
        else
        {
            stringBuilder.Append($"User Id={userName};Password={password};");
        }


        return stringBuilder.ToString();
    }
}