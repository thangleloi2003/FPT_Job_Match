using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT_JobMatch.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin-role", "42a5563b-4712-4b31-b58c-26255e11178c", "Admin", "ADMIN" },
                    { "employer-role", "122a28f3-4d3a-4db6-a8e5-02f358680008", "Employer", "EMPLOYER" },
                    { "user-role", "3a8f4202-4a4a-4927-b07b-20159a2fa979", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin", 0, "cd73b50e-3ac1-4d3f-9ecc-d499f71e2b22", null, true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFodd41hJL+H/TCWDHmWgnSL3obDW2WrUKilknbXsqmneQVj1NLyElpwX/kwUOKddg==", null, false, "f974d79c-8e95-4a29-990f-570376c87828", false, "admin@gmail.com" },
                    { "employer", 0, "432d960e-2d71-4b67-b6b3-0983d81073f5", null, true, false, null, "EMPLOYER@GMAIL.COM", "EMPLOYER@GMAIL.COM", "AQAAAAEAACcQAAAAEChm5ryxify1NJfHUpHi7qVtulD9x5q0WXSkocKJoCnzrpAlEc6T2W97tbj8+Nr19Q==", null, false, "c9e8b135-8880-414c-97e8-8aa0fd76a00b", false, "employer@gmail.com" },
                    { "user", 0, "23ac1267-9823-40f2-bfd7-948e6b1086b5", null, true, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEIEO+wexEUW3FKl4lFj9wVk5hPl99KJc1sI4dMqM9QUe2eIb80UBupFfoOTuilbA5A==", null, false, "297e571d-df1f-481e-9c77-f4819b0aacb1", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "admin", "admin-role" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "employer", "employer-role" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "user", "user-role" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "admin", "admin-role" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "employer", "employer-role" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "user", "user-role" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin-role");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employer-role");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user-role");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employer");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user");
        }
    }
}
