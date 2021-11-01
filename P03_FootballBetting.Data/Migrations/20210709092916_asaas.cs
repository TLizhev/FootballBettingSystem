using Microsoft.EntityFrameworkCore.Migrations;

namespace P03_FootballBetting.Data.Migrations
{
    public partial class asaas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Games",
                type: "varchar(7)",
                unicode: false,
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(7)",
                oldUnicode: false,
                oldMaxLength: 7,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Games",
                type: "varchar(7)",
                unicode: false,
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(7)",
                oldUnicode: false,
                oldMaxLength: 7);
        }
    }
}
