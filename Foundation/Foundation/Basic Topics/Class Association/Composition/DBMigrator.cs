using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Class_Association.Composition
{
    public class DBMigrator
    {
        private readonly Logger _logger;
        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating bla bla bla...");
        }
    }
}
