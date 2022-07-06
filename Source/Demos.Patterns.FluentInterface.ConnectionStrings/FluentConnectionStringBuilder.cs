using System.Collections.Generic;

namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class FluentConnectionStringBuilder :
    IServerSelection,
    IDatabaseSelection,
    IUserSelection,
    IPasswordSelection,
    IConnectionStringBuilder
{
    private readonly ICollection<string> settings = new List<string>();

    private FluentConnectionStringBuilder()
    {
    }

    public static IServerSelection Create()
    {
        return new FluentConnectionStringBuilder();
    }

    private FluentConnectionStringBuilder AddSetting(string setting)
    {
        settings.Add(setting);

        return this;
    }

    public IDatabaseSelection ForServer(string serverName)
    {
        return AddSetting($"Server={serverName}");
    }

    public IUserSelection AndDatabase(string databaseName)
    {
        return AddSetting($"Database={databaseName}");
    }

    public IPasswordSelection AsUser(string userName)
    {
        return AddSetting($"User Id={userName}");
    }

    public IConnectionStringBuilder WithPassword(string password)
    {
        return AddSetting($"Password={password}");
    }

    public IConnectionStringBuilder AsTrusted()
    {
        return AddSetting("Trusted_Connection=True");
    }

    public string Build()
    {
        return string.Join(";", settings);
    }
}