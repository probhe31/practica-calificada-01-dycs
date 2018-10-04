using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Migrations.MtySQL
{
    [Migration(3)]
    public class ProjectTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("3_ProjectTable.sql");
        }

        public override void Down()
        {
        }
    }
}
