using Demos.Patterns.FluentInterface.ConnectionStrings;
using System;

string connectionString = new ConnectionStringBuilder()
    .SetServerName("MSSQLSERVER")
    .SetDatabaseName("Library")
    .SetUserName("JSmith")
    .SetPassword("123qwe")
    .Build();
Console.WriteLine(connectionString);