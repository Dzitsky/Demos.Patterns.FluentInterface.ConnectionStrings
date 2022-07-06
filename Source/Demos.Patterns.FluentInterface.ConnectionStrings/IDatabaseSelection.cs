namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IDatabaseSelection
{
    IUserSelection AndDatabase(string databaseName);
}