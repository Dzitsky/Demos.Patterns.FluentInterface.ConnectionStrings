namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IUserSelection
{
    IAdditionSelection AsTrusted();
    IPasswordSelection AsUser(string userName);
}