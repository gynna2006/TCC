using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuNascimento.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaId = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b7109a8-6bd2-4236-8e73-09b6c0ae2d5d", "f409ebe6-8408-4b39-85bf-b6d8921b2de3", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5fc620ec-9d99-4569-8426-9a9f13672761", 0, "2493f2d0-8c77-4855-8137-c439478f22b2", "admin@lunascimento.com.br", true, false, null, "ADMIN@LUNASCIMENTO.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEJcA6jlD2himHg08S7T27Y2XF+a+fr9tXL7PvsQhPJOt09UypX+fdFZTJ1XNHbx2ow==", null, false, "805fb54d-12ba-4d6b-8816-34a61e783670", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "Aromatizador de Ambiente" },
                    { (byte)2, "Aromatizador de Carro" },
                    { (byte)3, "Sabonetes" },
                    { (byte)4, "Home Spray" },
                    { (byte)5, "Água de Lençol" },
                    { (byte)6, "Sachê" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9b7109a8-6bd2-4236-8e73-09b6c0ae2d5d", "5fc620ec-9d99-4569-8426-9a9f13672761" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Descricao", "Foto", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/10.png", "Frasco Quadrado Color", 85.00m },
                    { 2, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/4.png", "Frasco Quadrado Gelo", 65.00m },
                    { 3, (byte)2, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração. Consultar disponibilidade via whatsapp. Este produto contém 10ML.", "/images/produtos/5.png", "Aromatizador para Carros", 15.00m },
                    { 4, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/16.png", "Frasco Estrela Marrom", 85.00m },
                    { 5, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 50ML.", "/images/produtos/15.png", "Frasco Champanhe", 30.00m },
                    { 6, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/6.png", "Frasco Color Redondo", 85.00m },
                    { 7, (byte)3, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/3.png", "Sabonete Color Redondo (INDISPONÍVEL)", 0m },
                    { 8, (byte)6, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor. Consultar disponibilidade via whatsapp.", "/images/produtos/1.png", "Sachê Perfumado", 7.00m },
                    { 9, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML.", "/images/produtos/14.png", "Garrafa Cinturinha", 30.00m },
                    { 10, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/21.png", "Aromatizador Bola", 48.00m },
                    { 11, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/12.png", "Aromatizador Meia Lua", 65.00m },
                    { 12, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML.", "/images/produtos/19.png", "Aromatizador Quadrado Âmbar", 85.00m },
                    { 13, (byte)4, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML.", "/images/produtos/2.png", "Home Spray", 0.00m },
                    { 14, (byte)5, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML.", "/images/produtos/9.png", "Água de Lençol", 30.00m },
                    { 15, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/7.png", "Vidro Estampa Cesta", 85.00m },
                    { 16, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/8.png", "Vidro Degradê", 95.00m },
                    { 17, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/11.png", "Vidro Quadrado Gelo", 65.00m },
                    { 18, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/13.png", "Vidro Âmbar Retangular", 95.00m },
                    { 19, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/18.png", "Vidro Tribal", 85.00m },
                    { 20, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 300ML.", "/images/produtos/17.png", "Vidro Lampião", 95.00m },
                    { 21, (byte)1, "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.", "/images/produtos/20.png", "Vidro Bola", 79.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
