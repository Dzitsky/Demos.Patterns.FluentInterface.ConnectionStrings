namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IUserSelection
{
    IConnectionStringBuilder AsTrusted();
    IPasswordSelection AsUser(string userName);
}