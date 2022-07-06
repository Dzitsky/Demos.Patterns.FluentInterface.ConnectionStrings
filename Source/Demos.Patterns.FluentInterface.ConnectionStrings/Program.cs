using Demos.Patterns.FluentInterface.ConnectionStrings;
using System;

const string ServerName = "MSSQLSERVER";
const string DatabaseName = "Library";
const string UserName = "JSmith";
const string Password = "123qwe";

string connectionString1 = new ConnectionStringBuilder()
    .SetServerName(ServerName)
    .SetDatabaseName(DatabaseName)
    .SetUserName(UserName)
    .SetPassword(Password)
    .Build();
Console.WriteLine(connectionString1);

string connectionString2 = new ConnectionStringBuilder()
    .SetServerName(ServerName)
    .SetDatabaseName(DatabaseName)
    .SetTrustedConnection()
    .Build();
Console.WriteLine(connectionString2);

string connectionString3 = new FluentConnectionStringBuilder()
    .SetServerName(ServerName)
    .SetDatabaseName(DatabaseName)
    .SetUserName(UserName)
    .SetPassword(Password)
    .Build();
Console.WriteLine(connectionString3);