using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HakkimizdaT",
                columns: table => new
                {
                    HakkimizdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimizdaDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaGorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HakkimizdaDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkimizdaT", x => x.HakkimizdaID);
                });

            migrationBuilder.CreateTable(
                name: "IndexHakkimizdaT",
                columns: table => new
                {
                    IndexHakkimizdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndexHakkimizdaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndexHakkimizdaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexHakkimizdaT", x => x.IndexHakkimizdaID);
                });

            migrationBuilder.CreateTable(
                name: "MusteriT",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriT", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "OdaT",
                columns: table => new
                {
                    OdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelID = table.Column<int>(type: "int", nullable: false),
                    OdaKapasite = table.Column<int>(type: "int", nullable: false),
                    OdaDurum = table.Column<bool>(type: "bit", nullable: false),
                    GunlukFiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaT", x => x.OdaID);
                });

            migrationBuilder.CreateTable(
                name: "OtelT",
                columns: table => new
                {
                    OtelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtelBolge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtelAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtelOdaSayisi = table.Column<int>(type: "int", nullable: false),
                    OtelDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtelT", x => x.OtelID);
                });

            migrationBuilder.CreateTable(
                name: "PopulerOtellerT",
                columns: table => new
                {
                    OtelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bolge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sayi = table.Column<int>(type: "int", nullable: false),
                    Gorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulerOtellerT", x => x.OtelID);
                });

            migrationBuilder.CreateTable(
                name: "RezervasyonT",
                columns: table => new
                {
                    RezervasyonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    GidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tutar = table.Column<int>(type: "int", nullable: false),
                    SecilenOtelOtelID = table.Column<int>(type: "int", nullable: false),
                    SecilenOdaOdaID = table.Column<int>(type: "int", nullable: false),
                    RezervasyonDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervasyonT", x => x.RezervasyonID);
                    table.ForeignKey(
                        name: "FK_RezervasyonT_MusteriT_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "MusteriT",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervasyonT_OdaT_SecilenOdaOdaID",
                        column: x => x.SecilenOdaOdaID,
                        principalTable: "OdaT",
                        principalColumn: "OdaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervasyonT_OtelT_SecilenOtelOtelID",
                        column: x => x.SecilenOtelOtelID,
                        principalTable: "OtelT",
                        principalColumn: "OtelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonT_MusteriID",
                table: "RezervasyonT",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonT_SecilenOdaOdaID",
                table: "RezervasyonT",
                column: "SecilenOdaOdaID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonT_SecilenOtelOtelID",
                table: "RezervasyonT",
                column: "SecilenOtelOtelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HakkimizdaT");

            migrationBuilder.DropTable(
                name: "IndexHakkimizdaT");

            migrationBuilder.DropTable(
                name: "PopulerOtellerT");

            migrationBuilder.DropTable(
                name: "RezervasyonT");

            migrationBuilder.DropTable(
                name: "MusteriT");

            migrationBuilder.DropTable(
                name: "OdaT");

            migrationBuilder.DropTable(
                name: "OtelT");
        }
    }
}
