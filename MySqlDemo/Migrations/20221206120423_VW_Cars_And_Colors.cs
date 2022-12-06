using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySqlDemo.Migrations
{
    public partial class VW_Cars_And_Colors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
                create or replace view VW_Cars_And_Colors as
                select c.Name as Model , cl.ColorName as ModelColor
                from cars c 
                join colors cl on c.ColorId = cl.Id;";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW VW_Cars_And_Colors");
        }
    }
}
