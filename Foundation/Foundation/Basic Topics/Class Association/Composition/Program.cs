using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Class_Association.Composition
{
    class Program
    {
        static void Main(string [] args)
        {
            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
