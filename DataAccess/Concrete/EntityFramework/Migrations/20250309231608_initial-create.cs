using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Concrete.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AdminOperationClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOperationClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AdminOperationClaims",
                columns: new[] { "Id", "AdminId", "OperationClaimId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Admins",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "admin@admin.com", "Admin", "Admin", new byte[] { 145, 178, 101, 166, 68, 201, 185, 31, 101, 140, 55, 56, 222, 116, 166, 81, 96, 118, 66, 149, 183, 49, 47, 105, 7, 143, 87, 108, 255, 43, 190, 4, 212, 80, 242, 42, 109, 49, 248, 255, 211, 67, 84, 51, 55, 226, 202, 119, 75, 176, 75, 26, 79, 90, 128, 104, 41, 140, 16, 177, 236, 35, 11, 53 }, new byte[] { 35, 255, 44, 154, 168, 32, 223, 137, 185, 204, 137, 100, 174, 230, 75, 219, 243, 245, 143, 83, 19, 80, 156, 129, 5, 216, 77, 211, 219, 162, 30, 3, 25, 14, 90, 143, 170, 81, 8, 98, 127, 213, 242, 130, 90, 4, 108, 141, 175, 150, 10, 199, 220, 217, 56, 111, 63, 5, 49, 80, 53, 10, 80, 11, 193, 19, 99, 6, 247, 151, 150, 217, 112, 207, 159, 148, 38, 248, 168, 48, 86, 38, 50, 64, 118, 233, 142, 40, 117, 152, 90, 53, 141, 185, 118, 143, 231, 111, 199, 103, 41, 201, 161, 1, 233, 253, 186, 118, 212, 240, 194, 108, 204, 13, 121, 3, 110, 75, 148, 130, 80, 226, 211, 111, 247, 236, 149, 54 } });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul" },
                    { 2, "Kocaeli" },
                    { 3, "Bursa" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "customer" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Ataşehir" },
                    { 2, 1, "Üsküdar" },
                    { 3, 1, "Ümraniye" },
                    { 4, 1, "Beşikteş" },
                    { 5, 1, "Şişli" },
                    { 6, 2, "İzmit" },
                    { 7, 2, "Körfez" },
                    { 8, 2, "Gebze" },
                    { 9, 2, "Derince" },
                    { 10, 2, "Gölcük" },
                    { 11, 3, "Nilüfer" },
                    { 12, 3, "Yıldırım" },
                    { 13, 3, "Osmangazi" },
                    { 14, 3, "Gemlik" },
                    { 15, 3, "Mudanya" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                schema: "dbo",
                table: "Districts",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminOperationClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Admins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerOperationClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Districts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OperationClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "dbo");
        }
    }
}
