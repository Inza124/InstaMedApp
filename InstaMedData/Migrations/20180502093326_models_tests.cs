using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class models_tests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BetaHCGTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstrogenTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GlukozaTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrzywaTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MoczTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Morf5TestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MorfTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OGTTTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgesteronTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResultType",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SzpikTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestosteronTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "USGPiersiTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "USGSercaTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "USGSzyiTestId",
                table: "Results",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BetaHCGs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BetaHCGResult = table.Column<decimal>(nullable: false),
                    DocName = table.Column<string>(nullable: true),
                    isBeta = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetaHCGs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estrogens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    EstrogenResult = table.Column<decimal>(nullable: false),
                    isEstrogen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estrogens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Glukozas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    GlukozaResult = table.Column<decimal>(nullable: false),
                    isGlukoza = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glukozas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Krzywas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    FirstGlu = table.Column<decimal>(nullable: false),
                    SecondGlu = table.Column<decimal>(nullable: false),
                    ThirdGlu = table.Column<decimal>(nullable: false),
                    isKrzywa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Krzywas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moczs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bakterie = table.Column<string>(nullable: true),
                    KrwB = table.Column<decimal>(nullable: false),
                    KrwCz = table.Column<decimal>(nullable: false),
                    Nablonki = table.Column<decimal>(nullable: false),
                    Sluz = table.Column<string>(nullable: true),
                    isMocz = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moczs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Morves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HBResult = table.Column<decimal>(nullable: false),
                    HTResult = table.Column<decimal>(nullable: false),
                    MCHCResult = table.Column<decimal>(nullable: false),
                    MCHResult = table.Column<decimal>(nullable: false),
                    MCVResult = table.Column<decimal>(nullable: false),
                    Plt = table.Column<decimal>(nullable: false),
                    RBCResult = table.Column<decimal>(nullable: false),
                    WBCResult = table.Column<decimal>(nullable: false),
                    isMorf = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Morves5",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HBResult = table.Column<decimal>(nullable: false),
                    HTResult = table.Column<decimal>(nullable: false),
                    Limfocyty = table.Column<decimal>(nullable: false),
                    MCHCResult = table.Column<decimal>(nullable: false),
                    MCHResult = table.Column<decimal>(nullable: false),
                    MCVResult = table.Column<decimal>(nullable: false),
                    Monocyty = table.Column<decimal>(nullable: false),
                    Neutrofile = table.Column<decimal>(nullable: false),
                    Plt = table.Column<decimal>(nullable: false),
                    RBCResult = table.Column<decimal>(nullable: false),
                    WBCResult = table.Column<decimal>(nullable: false),
                    isMorf5 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morves5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OGTTs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    FirstGlu = table.Column<decimal>(nullable: false),
                    SecondGlu = table.Column<decimal>(nullable: false),
                    ThirdGlu = table.Column<decimal>(nullable: false),
                    isOGTT = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OGTTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Progesterons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    ProgesteronResult = table.Column<decimal>(nullable: false),
                    isProgesteron = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progesterons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Szpiks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    Erytroblasty = table.Column<decimal>(nullable: false),
                    Erytropoeza = table.Column<decimal>(nullable: false),
                    Proerytroblasty = table.Column<decimal>(nullable: false),
                    isSzpik = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szpiks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testosteron",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocName = table.Column<string>(nullable: true),
                    TestosteronAll = table.Column<decimal>(nullable: false),
                    TestosteronFree = table.Column<decimal>(nullable: false),
                    isTestosteron = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testosteron", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USGPiersis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    isUSGPiersi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USGPiersis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USGSercas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    isUSGSerca = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USGSercas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USGSzyis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    isUSGSzyi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USGSzyis", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_BetaHCGTestId",
                table: "Results",
                column: "BetaHCGTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_EstrogenTestId",
                table: "Results",
                column: "EstrogenTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_GlukozaTestId",
                table: "Results",
                column: "GlukozaTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_KrzywaTestId",
                table: "Results",
                column: "KrzywaTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_MoczTestId",
                table: "Results",
                column: "MoczTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_Morf5TestId",
                table: "Results",
                column: "Morf5TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_MorfTestId",
                table: "Results",
                column: "MorfTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_OGTTTestId",
                table: "Results",
                column: "OGTTTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ProgesteronTestId",
                table: "Results",
                column: "ProgesteronTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_SzpikTestId",
                table: "Results",
                column: "SzpikTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_TestosteronTestId",
                table: "Results",
                column: "TestosteronTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_USGPiersiTestId",
                table: "Results",
                column: "USGPiersiTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_USGSercaTestId",
                table: "Results",
                column: "USGSercaTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_USGSzyiTestId",
                table: "Results",
                column: "USGSzyiTestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_BetaHCGs_BetaHCGTestId",
                table: "Results",
                column: "BetaHCGTestId",
                principalTable: "BetaHCGs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Estrogens_EstrogenTestId",
                table: "Results",
                column: "EstrogenTestId",
                principalTable: "Estrogens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Glukozas_GlukozaTestId",
                table: "Results",
                column: "GlukozaTestId",
                principalTable: "Glukozas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Krzywas_KrzywaTestId",
                table: "Results",
                column: "KrzywaTestId",
                principalTable: "Krzywas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Moczs_MoczTestId",
                table: "Results",
                column: "MoczTestId",
                principalTable: "Moczs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Morves5_Morf5TestId",
                table: "Results",
                column: "Morf5TestId",
                principalTable: "Morves5",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Morves_MorfTestId",
                table: "Results",
                column: "MorfTestId",
                principalTable: "Morves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_OGTTs_OGTTTestId",
                table: "Results",
                column: "OGTTTestId",
                principalTable: "OGTTs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Progesterons_ProgesteronTestId",
                table: "Results",
                column: "ProgesteronTestId",
                principalTable: "Progesterons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Szpiks_SzpikTestId",
                table: "Results",
                column: "SzpikTestId",
                principalTable: "Szpiks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Testosteron_TestosteronTestId",
                table: "Results",
                column: "TestosteronTestId",
                principalTable: "Testosteron",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_USGPiersis_USGPiersiTestId",
                table: "Results",
                column: "USGPiersiTestId",
                principalTable: "USGPiersis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_USGSercas_USGSercaTestId",
                table: "Results",
                column: "USGSercaTestId",
                principalTable: "USGSercas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_USGSzyis_USGSzyiTestId",
                table: "Results",
                column: "USGSzyiTestId",
                principalTable: "USGSzyis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_BetaHCGs_BetaHCGTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Estrogens_EstrogenTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Glukozas_GlukozaTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Krzywas_KrzywaTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Moczs_MoczTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Morves5_Morf5TestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Morves_MorfTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_OGTTs_OGTTTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Progesterons_ProgesteronTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Szpiks_SzpikTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Testosteron_TestosteronTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_USGPiersis_USGPiersiTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_USGSercas_USGSercaTestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_USGSzyis_USGSzyiTestId",
                table: "Results");

            migrationBuilder.DropTable(
                name: "BetaHCGs");

            migrationBuilder.DropTable(
                name: "Estrogens");

            migrationBuilder.DropTable(
                name: "Glukozas");

            migrationBuilder.DropTable(
                name: "Krzywas");

            migrationBuilder.DropTable(
                name: "Moczs");

            migrationBuilder.DropTable(
                name: "Morves");

            migrationBuilder.DropTable(
                name: "Morves5");

            migrationBuilder.DropTable(
                name: "OGTTs");

            migrationBuilder.DropTable(
                name: "Progesterons");

            migrationBuilder.DropTable(
                name: "Szpiks");

            migrationBuilder.DropTable(
                name: "Testosteron");

            migrationBuilder.DropTable(
                name: "USGPiersis");

            migrationBuilder.DropTable(
                name: "USGSercas");

            migrationBuilder.DropTable(
                name: "USGSzyis");

            migrationBuilder.DropIndex(
                name: "IX_Results_BetaHCGTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_EstrogenTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_GlukozaTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_KrzywaTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_MoczTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_Morf5TestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_MorfTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_OGTTTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_ProgesteronTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_SzpikTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_TestosteronTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_USGPiersiTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_USGSercaTestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_USGSzyiTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "BetaHCGTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "EstrogenTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "GlukozaTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "KrzywaTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "MoczTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Morf5TestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "MorfTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "OGTTTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "ProgesteronTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "ResultType",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "SzpikTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "TestosteronTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "USGPiersiTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "USGSercaTestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "USGSzyiTestId",
                table: "Results");
        }
    }
}
