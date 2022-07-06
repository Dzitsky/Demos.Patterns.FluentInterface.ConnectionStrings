namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IUserSelection
{
    IPasswordSelection AsUser(string userName);
}