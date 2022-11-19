using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NDDTraining.Infra.Migrations
{
    /// <inheritdoc />
    public partial class ImgUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationDTO");

            migrationBuilder.CreateTable(
                name: "CompletedModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedModule_MODULES_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "MODULES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompletedModule_REGISTRATION_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "REGISTRATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompletedModule_ModuleId",
                table: "CompletedModule",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedModule_RegistrationId",
                table: "CompletedModule",
                column: "RegistrationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedModule");

            migrationBuilder.CreateTable(
                name: "RegistrationDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: true),
                    RegistrationId1 = table.Column<int>(type: "int", nullable: true),
                    RegistrationId2 = table.Column<int>(type: "int", nullable: true),
                    RegistrationId3 = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationDTO_REGISTRATION_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "REGISTRATION",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RegistrationDTO_REGISTRATION_RegistrationId1",
                        column: x => x.RegistrationId1,
                        principalTable: "REGISTRATION",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RegistrationDTO_REGISTRATION_RegistrationId2",
                        column: x => x.RegistrationId2,
                        principalTable: "REGISTRATION",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RegistrationDTO_REGISTRATION_RegistrationId3",
                        column: x => x.RegistrationId3,
                        principalTable: "REGISTRATION",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDTO_RegistrationId",
                table: "RegistrationDTO",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDTO_RegistrationId1",
                table: "RegistrationDTO",
                column: "RegistrationId1");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDTO_RegistrationId2",
                table: "RegistrationDTO",
                column: "RegistrationId2");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDTO_RegistrationId3",
                table: "RegistrationDTO",
                column: "RegistrationId3");
        }
    }
}
