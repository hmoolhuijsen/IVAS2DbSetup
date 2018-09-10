using System;

using Microsoft.EntityFrameworkCore;


namespace IVAS2.DbSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            // To create the database, do the following:
            // Create an empty DB in SQL Server Manager, having the same name as in the connectionstring.
            // In the Package Manager Console, execute:
            // Add-Migration InitialCreate
            // If that is not recognized, execute first:
            // C:\Users\<your account>\.nuget\packages\microsoft.entityframeworkcore.tools\<used version>\tools\init.ps1
            // Then:
            using (var db = new Model.IVAS2Context())
            {
                db.Database.Migrate();
            }

            Proxy.CreateData();
        }
    }
}
