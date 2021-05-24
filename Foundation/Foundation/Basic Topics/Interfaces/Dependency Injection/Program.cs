using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces.Dependency_Injection
{
    class Program
    {
        static void NonMain(string[] args)
        {
            var dbMigrator = new DatabaseMigrator(new FileLogger("C://Project//log.txt"));
            dbMigrator.Migrate();
        }
    }
}
