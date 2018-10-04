using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Migrations.MtySQL
{
    [Migration(1)]
    public class CompanyTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("1_CompanyTable.sql");
        }

        public override void Down()
        {
        }
    }
}
