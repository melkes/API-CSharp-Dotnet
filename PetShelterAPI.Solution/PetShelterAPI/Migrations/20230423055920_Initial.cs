using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShelterAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Color", "Description", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, 7, "brown", "est. Nunc laoreet lectus quis massa. Mauris vestibulum,", "Matilda", "Female", "Cat" },
                    { 2, 2, "black", "pellentesque massa lobortis ultrices. Vivamus rhoncus. Donec", "Rexie", "Female", "Cat" },
                    { 3, 4, "white", "tincidunt tempus risus. Donec egestas. Duis ac arcu.", "Matilda", "Male", "Dog" },
                    { 4, 4, "white", "enim. Mauris quis turpis vitae purus gravida sagittis. Duis gravida", "Pip", "Female", "Dog" },
                    { 5, 1, "cream", "ultrices posuere cubilia Curae Phasellus ornare.", "Bartholomew", "Male", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
