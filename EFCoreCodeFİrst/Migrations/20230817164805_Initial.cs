using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCodeFİrst.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YayınEvleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayınEvleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ozgecmis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kategoriId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YayınEviYazar",
                columns: table => new
                {
                    YayınEvleriID = table.Column<int>(type: "int", nullable: false),
                    YazarlarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayınEviYazar", x => new { x.YayınEvleriID, x.YazarlarID });
                    table.ForeignKey(
                        name: "FK_YayınEviYazar_YayınEvleri_YayınEvleriID",
                        column: x => x.YayınEvleriID,
                        principalTable: "YayınEvleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YayınEviYazar_Yazarlar_YazarlarID",
                        column: x => x.YazarlarID,
                        principalTable: "Yazarlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYayınEvi",
                columns: table => new
                {
                    KitaplarID = table.Column<int>(type: "int", nullable: false),
                    YayınEvleriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYayınEvi", x => new { x.KitaplarID, x.YayınEvleriID });
                    table.ForeignKey(
                        name: "FK_KitapYayınEvi_Kitaplar_KitaplarID",
                        column: x => x.KitaplarID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYayınEvi_YayınEvleri_YayınEvleriID",
                        column: x => x.YayınEvleriID,
                        principalTable: "YayınEvleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    KitaplarID = table.Column<int>(type: "int", nullable: false),
                    YazarlarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => new { x.KitaplarID, x.YazarlarID });
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitaplar_KitaplarID",
                        column: x => x.KitaplarID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazarlar_YazarlarID",
                        column: x => x.YazarlarID,
                        principalTable: "Yazarlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_kategoriId",
                table: "Kitaplar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYayınEvi_YayınEvleriID",
                table: "KitapYayınEvi",
                column: "YayınEvleriID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarlarID",
                table: "KitapYazar",
                column: "YazarlarID");

            migrationBuilder.CreateIndex(
                name: "IX_YayınEviYazar_YazarlarID",
                table: "YayınEviYazar",
                column: "YazarlarID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapYayınEvi");

            migrationBuilder.DropTable(
                name: "KitapYazar");

            migrationBuilder.DropTable(
                name: "YayınEviYazar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "YayınEvleri");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
