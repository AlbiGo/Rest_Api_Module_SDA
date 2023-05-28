using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class innitialMigration_100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorite",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFshirjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPerditesimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorite", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lexuesit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFunditeLogimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFshirjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPerditesimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lexuesit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Librat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titull = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    Autori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataRegjistrimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFshirjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPerditesimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Librat_Kategorite_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategorite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiberLexues",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LexuesID = table.Column<int>(type: "int", nullable: false),
                    LiberID = table.Column<int>(type: "int", nullable: false),
                    EshteAktiv = table.Column<bool>(type: "bit", nullable: false),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFshirjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPerditesimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiberLexues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LiberLexues_Lexuesit_LexuesID",
                        column: x => x.LexuesID,
                        principalTable: "Lexuesit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LiberLexues_Librat_LiberID",
                        column: x => x.LiberID,
                        principalTable: "Librat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LiberLexues_LexuesID",
                table: "LiberLexues",
                column: "LexuesID");

            migrationBuilder.CreateIndex(
                name: "IX_LiberLexues_LiberID",
                table: "LiberLexues",
                column: "LiberID");

            migrationBuilder.CreateIndex(
                name: "IX_Librat_KategoriID",
                table: "Librat",
                column: "KategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiberLexues");

            migrationBuilder.DropTable(
                name: "Lexuesit");

            migrationBuilder.DropTable(
                name: "Librat");

            migrationBuilder.DropTable(
                name: "Kategorite");
        }
    }
}
