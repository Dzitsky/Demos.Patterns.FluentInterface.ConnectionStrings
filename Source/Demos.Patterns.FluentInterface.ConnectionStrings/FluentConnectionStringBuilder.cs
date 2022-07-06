using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal sealed class FluentConnectionStringBuilder :
    IServerSelection,
    IDatabaseSelection,
    IUserSelection,
    IPasswordSelection,
    IConnectionStringBuilder,
    IAdditionSelection
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

    public IDatabaseSelection ForServer(string serverName, Action<ServerOptions> optionsCallback)
    {
        var options = new ServerOptions();
        optionsCallback(options);

        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Server={serverName}");

        if (options.Port.HasValue)
        {
            stringBuilder.Append($",{options.Port}");
        }

        return AddSetting(stringBuilder.ToString());
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

    public IAdditionSelection AsTrusted()
    {
        return AddSetting("Trusted_Connection=True");
    }

    public IConnectionStringBuilder EnableMars()
    {
        return AddSetting("MultipleActiveResultSets=True");
    }

    public string Build()
    {
        return string.Join(";", settings);
    }
}