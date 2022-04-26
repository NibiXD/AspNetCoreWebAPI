using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Registration = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Registration = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Grade = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Workload = table.Column<int>(type: "INTEGER", nullable: false),
                    PreRequisiteId = table.Column<int>(type: "INTEGER", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplines_Disciplines_PreRequisiteId",
                        column: x => x.PreRequisiteId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsDisciplines",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Grade = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsDisciplines", x => new { x.StudentId, x.DisciplineId });
                    table.ForeignKey(
                        name: "FK_StudentsDisciplines_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsDisciplines_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tecnologia da Informação" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Sistemas de Informação" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ciência da Computação" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 1, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marta", "33225555", 1, new DateTime(2022, 4, 8, 18, 32, 54, 766, DateTimeKind.Local).AddTicks(7944), "Kent" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 2, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paula", "3354058", 2, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(39), "Isabela" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 3, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura", "55668899", 3, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(55), "Antonia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 4, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luiza", "6565659", 4, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(63), "Maria" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 5, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucas", "565685415", 5, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(69), "Machado" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 6, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pedro", "456454545", 6, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(79), "Alvares" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Active", "BirthDate", "EndDate", "Name", "PhoneNumber", "Registration", "StartDate", "Surname" },
                values: new object[] { 7, true, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paulo", "9874512", 7, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(85), "José" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Active", "EndDate", "Name", "Phone", "Registration", "StartDate", "Surname" },
                values: new object[] { 1, true, null, "Lauro", null, 1, new DateTime(2022, 4, 8, 18, 32, 54, 756, DateTimeKind.Local).AddTicks(5207), "Oliveira" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Active", "EndDate", "Name", "Phone", "Registration", "StartDate", "Surname" },
                values: new object[] { 2, true, null, "Roberto", null, 2, new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5696), "Soares" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Active", "EndDate", "Name", "Phone", "Registration", "StartDate", "Surname" },
                values: new object[] { 3, true, null, "Ronaldo", null, 3, new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5712), "Marconi" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Active", "EndDate", "Name", "Phone", "Registration", "StartDate", "Surname" },
                values: new object[] { 4, true, null, "Rodrigo", null, 4, new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5715), "Carvalho" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Active", "EndDate", "Name", "Phone", "Registration", "StartDate", "Surname" },
                values: new object[] { 5, true, null, "Alexandre", null, 5, new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5717), "Montanha" });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 1, 1, "Matemática", null, 1, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 2, 3, "Matemática", null, 1, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 3, 3, "Física", null, 2, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 4, 1, "Português", null, 3, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 5, 1, "Inglês", null, 4, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 6, 2, "Inglês", null, 4, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 7, 3, "Inglês", null, 4, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 8, 1, "Programação", null, 5, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 9, 2, "Programação", null, 5, 0 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CourseId", "Name", "PreRequisiteId", "TeacherId", "Workload" },
                values: new object[] { 10, 3, "Programação", null, 5, 0 });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 2, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 4, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 2, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 1, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 7, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 6, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 5, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 4, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 4, 1, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 3, 7, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 5, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 3, 6, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 7, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 6, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 3, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 2, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 2, 1, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 7, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 6, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 4, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 1, 3, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 3, 3, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.InsertData(
                table: "StudentsDisciplines",
                columns: new[] { "DisciplineId", "StudentId", "EndDate", "Grade", "StartDate" },
                values: new object[] { 5, 7, null, null, new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_CourseId",
                table: "Disciplines",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_PreRequisiteId",
                table: "Disciplines",
                column: "PreRequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsDisciplines_DisciplineId",
                table: "StudentsDisciplines",
                column: "DisciplineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "StudentsDisciplines");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
