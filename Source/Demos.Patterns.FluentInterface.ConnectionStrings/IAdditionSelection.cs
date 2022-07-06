namespace Demos.Patterns.FluentInterface.ConnectionStrings;

internal interface IAdditionSelection : IConnectionStringBuilder
{
    IConnectionStringBuilder EnableMars();
}