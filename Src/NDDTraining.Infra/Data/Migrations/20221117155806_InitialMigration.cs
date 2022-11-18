using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NDDTraining.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TRAININGS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    TITLE = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(400)", maxLength: 400, nullable: false),
                    TEACHER = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    DURATION = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    ACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CATEGORY = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAININGS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    PASSWORD = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    AGE = table.Column<int>(type: "INT", nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    IMAGE = table.Column<string>(type: "VARCHAR", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MODULES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    TITLEMODULE = table.Column<string>(name: "TITLE_MODULE", type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    LINK = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    IMAGE = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    DESCRIPTIONMODULE = table.Column<string>(name: "DESCRIPTION_MODULE", type: "VARCHAR(300)", maxLength: 300, nullable: false),
                    STATUSMODULE = table.Column<string>(name: "STATUS_MODULE", type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODULES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MODULES_TRAININGS_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "TRAININGS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "REGISTRATION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERID = table.Column<int>(name: "USER_ID", type: "INT", nullable: false),
                    TRAININGID = table.Column<int>(name: "TRAINING_ID", type: "INT", nullable: false),
                    STATUS = table.Column<string>(type: "VARCHAR", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGISTRATION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_REGISTRATION_TRAININGS_TRAINING_ID",
                        column: x => x.TRAININGID,
                        principalTable: "TRAININGS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_REGISTRATION_USER_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TRAININGS",
                columns: new[] { "ID", "ACTIVE", "CATEGORY", "DESCRIPTION", "DURATION", "ReleaseDate", "TEACHER", "TITLE", "URL" },
                values: new object[,]
                {
                    { 1, true, "tecnologia", "Architecto eaque consectetur nostrum impedit earum at harum. Reiciendis suscipit soluta, ab, repellat ad, Architecto eaque consectetur nostrum impedit earum at harum. Architecto eaque consectetur nostrum impedit earum at harum., Architecto eaque consectetur nostrum impedit earum at harum.", new TimeSpan(0, 20, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos Silva", "Manutenção de Computadores", "https://certificadocursosonline.com/wp-content/uploads/2018/07/Curso-de-Manutenc%CC%A7a%CC%83o-de-Computadores.jpg" },
                    { 2, true, "idioma", "Neste curso, os alunos irão obter um conhecimento aprofundado sobre os recursos disponíveis sobre Inlges o basico.", new TimeSpan(2, 22, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodrigo Rosa", "Ingles Basico", "https://setcesp.org.br/wp-content/uploads/2019/08/treinamento.jpg" },
                    { 3, true, "educacao", "Neste curso, os alunos irão obter um conhecimento aprofundado sobre os recursos disponíveis.", new TimeSpan(0, 18, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria Eduarda", "Redacao", "https://setcesp.org.br/wp-content/uploads/2019/08/treinamento.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MODULES_TrainingId",
                table: "MODULES",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_REGISTRATION_TRAINING_ID",
                table: "REGISTRATION",
                column: "TRAINING_ID");

            migrationBuilder.CreateIndex(
                name: "IX_REGISTRATION_USER_ID",
                table: "REGISTRATION",
                column: "USER_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MODULES");

            migrationBuilder.DropTable(
                name: "REGISTRATION");

            migrationBuilder.DropTable(
                name: "TRAININGS");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}
