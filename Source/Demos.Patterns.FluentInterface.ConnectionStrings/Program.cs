using Demos.Patterns.FluentInterface.ConnectionStrings;
using System;

var connectionStringBuilder = new ConnectionStringBuilder();
connectionStringBuilder.SetServerName("MSSQLSERVER");
connectionStringBuilder.SetDatabaseName("Library");
connectionStringBuilder.SetUserName("JSmith");
connectionStringBuilder.SetPassword("123qwe");
string connectionString = connectionStringBuilder.Build();
Console.WriteLine(connectionString);