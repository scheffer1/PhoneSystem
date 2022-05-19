using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhoneSystem___LOLDESIGN.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    from = table.Column<int>(type: "int", nullable: false),
                    to = table.Column<int>(type: "int", nullable: false),
                    PricePerMin = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Relation",
                columns: new[] { "id", "PricePerMin", "from", "to" },
                values: new object[,]
                {
                    { 1, 1.8999999999999999, 11, 16 },
                    { 2, 2.8999999999999999, 16, 11 },
                    { 3, 1.7, 11, 17 },
                    { 4, 2.7000000000000002, 17, 11 },
                    { 5, 0.90000000000000002, 11, 18 },
                    { 6, 1.8999999999999999, 18, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relation");
        }
    }
}
