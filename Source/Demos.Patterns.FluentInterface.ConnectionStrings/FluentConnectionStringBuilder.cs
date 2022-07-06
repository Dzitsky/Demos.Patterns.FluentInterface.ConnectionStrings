using System.Collections.Generic;

namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class FluentConnectionStringBuilder
{
    private readonly ICollection<string> settings = new List<string>();

    private FluentConnectionStringBuilder AddSetting(string setting)
    {
        settings.Add(setting);

        return this;
    }

    public FluentConnectionStringBuilder SetServerName(string serverName)
    {
        return AddSetting($"Server={serverName}");
    }

    public FluentConnectionStringBuilder SetDatabaseName(string databaseName)
    {
        return AddSetting($"Database={databaseName}");
    }

    public FluentConnectionStringBuilder SetUserName(string userName)
    {
        return AddSetting($"User Id={userName}");
    }

    public FluentConnectionStringBuilder SetPassword(string password)
    {
        return AddSetting($"Password={password}");
    }

    public FluentConnectionStringBuilder SetTrustedConnection()
    {
        return AddSetting("Trusted_Connection=True");
    }

    public string Build()
    {
        return string.Join(";", settings);
    }
}