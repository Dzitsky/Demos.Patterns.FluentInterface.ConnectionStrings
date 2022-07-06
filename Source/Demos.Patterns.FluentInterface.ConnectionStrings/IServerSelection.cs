namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IServerSelection
{
    IDatabaseSelection ForServer(string serverName);
}