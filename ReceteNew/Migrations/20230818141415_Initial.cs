using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceteNew.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doktorlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tckn = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    pinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    olusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktorlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ilaclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    olusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilaclar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    olusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    olusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receteler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    receteTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EreceteNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    olusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receteler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receteler_Doktorlar_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktorlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receteİlaclari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilacId = table.Column<int>(type: "int", nullable: false),
                    receteId = table.Column<int>(type: "int", nullable: false),
                    useTypeId = table.Column<int>(type: "int", nullable: false),
                    periyot = table.Column<int>(type: "int", nullable: false),
                    doz = table.Column<int>(type: "int", nullable: false),
                    adet = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    olusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receteİlaclari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receteİlaclari_Receteler_receteId",
                        column: x => x.receteId,
                        principalTable: "Receteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receteİlaclari_UseType_useTypeId",
                        column: x => x.useTypeId,
                        principalTable: "UseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receteİlaclari_ilaclar_ilacId",
                        column: x => x.ilacId,
                        principalTable: "ilaclar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tanirecete",
                columns: table => new
                {
                    RecetelerId = table.Column<int>(type: "int", nullable: false),
                    TanilarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanirecete", x => new { x.RecetelerId, x.TanilarId });
                    table.ForeignKey(
                        name: "FK_Tanirecete_Receteler_RecetelerId",
                        column: x => x.RecetelerId,
                        principalTable: "Receteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tanirecete_Tanilar_TanilarId",
                        column: x => x.TanilarId,
                        principalTable: "Tanilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receteİlaclari_ilacId",
                table: "Receteİlaclari",
                column: "ilacId");

            migrationBuilder.CreateIndex(
                name: "IX_Receteİlaclari_receteId",
                table: "Receteİlaclari",
                column: "receteId");

            migrationBuilder.CreateIndex(
                name: "IX_Receteİlaclari_useTypeId",
                table: "Receteİlaclari",
                column: "useTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receteler_DoktorId",
                table: "Receteler",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tanirecete_TanilarId",
                table: "Tanirecete",
                column: "TanilarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receteİlaclari");

            migrationBuilder.DropTable(
                name: "Tanirecete");

            migrationBuilder.DropTable(
                name: "UseType");

            migrationBuilder.DropTable(
                name: "ilaclar");

            migrationBuilder.DropTable(
                name: "Receteler");

            migrationBuilder.DropTable(
                name: "Tanilar");

            migrationBuilder.DropTable(
                name: "Doktorlar");
        }
    }
}
