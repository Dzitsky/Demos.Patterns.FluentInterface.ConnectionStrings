namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IPasswordSelection
{
    IAdditionSelection WithPassword(string password);
}