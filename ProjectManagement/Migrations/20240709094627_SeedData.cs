using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Emplloyees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emplloyees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Emplloyees_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Field", "ImageUrl", "Name" },
                values: new object[] { new Guid("1752e9e5-de76-49f5-b27e-eca83eb6685a"), "Web Uygulama Arayüzü Programlama", "Computer Science", null, "ASP.NET Core Web API Project" });

            migrationBuilder.InsertData(
                table: "Emplloyees",
                columns: new[] { "EmployeeId", "Age", "FirstName", "LastName", "Position", "ProjectId" },
                values: new object[] { new Guid("2fbfe11d-b744-4269-83d7-dd0b5b23e941"), 57, "Şükrü", "Kaya", "Senior Develpoer", new Guid("1752e9e5-de76-49f5-b27e-eca83eb6685a") });

            migrationBuilder.CreateIndex(
                name: "IX_Emplloyees_ProjectId",
                table: "Emplloyees",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emplloyees");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
