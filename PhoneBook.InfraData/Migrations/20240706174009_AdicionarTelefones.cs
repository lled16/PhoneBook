using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneBook.InfraData.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTelefones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Contatos_Id",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "Phones",
                table: "Telefones");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Telefones",
                newName: "ContactId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contatos",
                newName: "ContactId");

            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "Telefones",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Telefones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ContactId",
                table: "Telefones",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Contatos_ContactId",
                table: "Telefones",
                column: "ContactId",
                principalTable: "Contatos",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Contatos_ContactId",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_ContactId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Telefones");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Telefones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contatos",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Phones",
                table: "Telefones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contatos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Contatos_Id",
                table: "Telefones",
                column: "Id",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
