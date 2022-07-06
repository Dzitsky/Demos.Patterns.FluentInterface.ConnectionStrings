using System.Collections.Generic;

namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class ConnectionStringBuilder
{
    private readonly ICollection<string> settings = new List<string>();

    private ConnectionStringBuilder AddSetting(string setting)
    {
        settings.Add(setting);

        return this;
    }

    public ConnectionStringBuilder SetServerName(string serverName)
    {
        return AddSetting($"Server={serverName}");
    }

    public ConnectionStringBuilder SetDatabaseName(string databaseName)
    {
        return AddSetting($"Database={databaseName}");
    }

    public ConnectionStringBuilder SetUserName(string userName)
    {
        return AddSetting($"User Id={userName}");
    }

    public ConnectionStringBuilder SetPassword(string password)
    {
        return AddSetting($"Password={password}");
    }

    public ConnectionStringBuilder SetTrustedConnection()
    {
        return AddSetting("Trusted_Connection=True");
    }

    public string Build()
    {
        return string.Join(";", settings);
    }
}