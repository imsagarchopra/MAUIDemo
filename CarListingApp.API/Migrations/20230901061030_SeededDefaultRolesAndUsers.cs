using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarListingApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42358d3e-3c22-45e1-be81-6caa7ba865ef", "6079aeb9-886b-4cc3-954e-607ad92d78f7", "User", "USER" },
                    { "d1b5952a-2162-46c7-b29e-1a2a68922c14", "c5d99cfe-e1e8-4c77-bf1c-39e651cb012d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4631bd-f907-4409-b416-ba356312e659", 0, "cbb56f23-9d0c-42e2-96f7-fbab9cd26d77", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFLJPC/U5Wn0U2pk2y9j78bdfKF0dgjq4w76u+tgEm//z/FZg9LYXHr6a55Getjoug==", null, false, "477e01d1-5f1d-45f0-a1f3-b61c54ba80bb", false, "user@localhost.com" },
                    { "408aa945-3d84-4421-8342-7269ec64d949", 0, "b8bae754-9f7b-46fa-b755-0a028d6c38e8", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP/YcHBYDJuNCF5xVkxahTgQ8eLffE37Qr9zMtI5L0MmfVsjalvkw6Z0VazECr579Q==", null, false, "71f72502-a18c-4170-ad63-c4f0cfd64a21", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42358d3e-3c22-45e1-be81-6caa7ba865ef", "3f4631bd-f907-4409-b416-ba356312e659" },
                    { "d1b5952a-2162-46c7-b29e-1a2a68922c14", "408aa945-3d84-4421-8342-7269ec64d949" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42358d3e-3c22-45e1-be81-6caa7ba865ef", "3f4631bd-f907-4409-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1b5952a-2162-46c7-b29e-1a2a68922c14", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949");
        }
    }
}
