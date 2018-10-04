using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Migrations.MtySQL
{
    [Migration(2)]
    public class UserTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("2_UserTable.sql");
        }

        public override void Down()
        {
        }
    }
}
