using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces.Dependency_Injection
{
    public class DatabaseMigrator
    {
        private readonly ILogger _logger;

        public DatabaseMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migrating finished at {0}" + DateTime.Now);
        }
    }
}
