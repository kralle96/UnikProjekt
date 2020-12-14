using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class LejemaalDbSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ejendom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoligAdministrationsSelskab = table.Column<int>(type: "int", nullable: false),
                    OmrådeNavn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejendom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventarType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostNr = table.Column<int>(type: "int", nullable: false),
                    By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Selskab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selskab", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatistikLejeperiodeLejersAlder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoligAdminSelskab = table.Column<int>(type: "int", nullable: false),
                    DatoSoegt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlderFra = table.Column<int>(type: "int", nullable: false),
                    AlderTil = table.Column<int>(type: "int", nullable: false),
                    LejeperiodeGennemsnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatistikLejeperiodeLejersAlder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Udlejningsinfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaanedligLeje = table.Column<double>(type: "float", nullable: false),
                    MaanedligEl = table.Column<double>(type: "float", nullable: false),
                    MaanedligVand = table.Column<double>(type: "float", nullable: false),
                    MaanedligVarme = table.Column<double>(type: "float", nullable: false),
                    Internet = table.Column<bool>(type: "bit", nullable: false),
                    Depositum = table.Column<double>(type: "float", nullable: false),
                    LedigFra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OvertagelseFra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Udlejningsinfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lejemaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaerelser = table.Column<int>(type: "int", nullable: false),
                    Stoerrelse = table.Column<int>(type: "int", nullable: false),
                    Energimaerke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Husdyr = table.Column<bool>(type: "bit", nullable: true),
                    Ryger = table.Column<bool>(type: "bit", nullable: true),
                    UdlejningsinfoId = table.Column<int>(type: "int", nullable: true),
                    PostNrId = table.Column<int>(type: "int", nullable: true),
                    SelskabId = table.Column<int>(type: "int", nullable: true),
                    EjendomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lejemaal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lejemaal_Ejendom_EjendomId",
                        column: x => x.EjendomId,
                        principalTable: "Ejendom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lejemaal_Post_PostNrId",
                        column: x => x.PostNrId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lejemaal_Selskab_SelskabId",
                        column: x => x.SelskabId,
                        principalTable: "Selskab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lejemaal_Udlejningsinfo_UdlejningsinfoId",
                        column: x => x.UdlejningsinfoId,
                        principalTable: "Udlejningsinfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventarLejemaal",
                columns: table => new
                {
                    InventarILejemaalId = table.Column<int>(type: "int", nullable: false),
                    InventarILejemaalId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarLejemaal", x => new { x.InventarILejemaalId, x.InventarILejemaalId1 });
                    table.ForeignKey(
                        name: "FK_InventarLejemaal_Inventar_InventarILejemaalId",
                        column: x => x.InventarILejemaalId,
                        principalTable: "Inventar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventarLejemaal_Lejemaal_InventarILejemaalId1",
                        column: x => x.InventarILejemaalId1,
                        principalTable: "Lejemaal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventarLejemaal_InventarILejemaalId1",
                table: "InventarLejemaal",
                column: "InventarILejemaalId1");

            migrationBuilder.CreateIndex(
                name: "IX_Lejemaal_EjendomId",
                table: "Lejemaal",
                column: "EjendomId");

            migrationBuilder.CreateIndex(
                name: "IX_Lejemaal_PostNrId",
                table: "Lejemaal",
                column: "PostNrId");

            migrationBuilder.CreateIndex(
                name: "IX_Lejemaal_SelskabId",
                table: "Lejemaal",
                column: "SelskabId");

            migrationBuilder.CreateIndex(
                name: "IX_Lejemaal_UdlejningsinfoId",
                table: "Lejemaal",
                column: "UdlejningsinfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventarLejemaal");

            migrationBuilder.DropTable(
                name: "StatistikLejeperiodeLejersAlder");

            migrationBuilder.DropTable(
                name: "Inventar");

            migrationBuilder.DropTable(
                name: "Lejemaal");

            migrationBuilder.DropTable(
                name: "Ejendom");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Selskab");

            migrationBuilder.DropTable(
                name: "Udlejningsinfo");
        }
    }
}
