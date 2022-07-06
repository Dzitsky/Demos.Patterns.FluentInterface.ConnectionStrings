namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IPasswordSelection
{
    IConnectionStringBuilder WithPassword(string password);
}