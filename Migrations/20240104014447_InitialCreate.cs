using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_EveryMind.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(70)", maxLength: 70, nullable: false),
                    CodigoProduto = table.Column<string>(type: "VARCHAR(70)", maxLength: 70, nullable: false),
                    DescriçãoProduto = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PrecoProduto = table.Column<string>(type: "VARCHAR(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Codigo",
                table: "Produto",
                column: "CodigoProduto",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
