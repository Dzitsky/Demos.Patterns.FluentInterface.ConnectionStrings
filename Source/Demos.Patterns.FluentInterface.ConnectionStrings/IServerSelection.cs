using System;

namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IServerSelection
{
    IDatabaseSelection ForServer(string serverName);
    IDatabaseSelection ForServer(string serverName, Action<ServerOptions> optionsCallback);
}