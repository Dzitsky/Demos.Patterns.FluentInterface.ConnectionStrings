using Demos.Patterns.FluentInterface.ConnectionStrings;
using System;

string connectionString1 = new ConnectionStringBuilder()
    .SetServerName("MSSQLSERVER")
    .SetDatabaseName("Library")
    .SetUserName("JSmith")
    .SetPassword("123qwe")
    .Build();
Console.WriteLine(connectionString1);

string connectionString2 = new ConnectionStringBuilder()
    .SetServerName("MSSQLSERVER")
    .SetDatabaseName("Library")
    .SetTrustedConnection()
    .Build();
Console.WriteLine(connectionString2);