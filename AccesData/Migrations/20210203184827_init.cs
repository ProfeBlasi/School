using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccesData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "varchar(45)", nullable: true),
                    Turn = table.Column<string>(type: "varchar(45)", nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Assistance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stdent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastNameName = table.Column<string>(type: "varchar(45)", nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stdent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stdent_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(45)", nullable: true),
                    Trimester = table.Column<string>(type: "varchar(45)", nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    Qualification = table.Column<int>(nullable: false),
                    Recuperative = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluation_Stdent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Stdent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proceedings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Intensity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceedings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proceedings_Stdent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Stdent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SudentRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SudentRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SudentRegistration_Registry_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SudentRegistration_Stdent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Stdent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Proceedings_StudentId",
                table: "Proceedings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Stdent_CourseId",
                table: "Stdent",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SudentRegistration_RegistrationId",
                table: "SudentRegistration",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SudentRegistration_StudentId",
                table: "SudentRegistration",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Proceedings");

            migrationBuilder.DropTable(
                name: "SudentRegistration");

            migrationBuilder.DropTable(
                name: "Registry");

            migrationBuilder.DropTable(
                name: "Stdent");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
