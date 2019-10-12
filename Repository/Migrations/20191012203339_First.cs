using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<int>(type: "int(8)", maxLength: 8, nullable: false),
                    Rua = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(60)", maxLength: 80, nullable: false),
                    Numero = table.Column<int>(type: "int(5)", maxLength: 5, nullable: false),
                    Complemento = table.Column<int>(type: "int(5)", maxLength: 5, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Estado = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    Referencia = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Senha = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    Tipo = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensagem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDestinatario = table.Column<long>(type: "bigint(11)", maxLength: 1, nullable: false),
                    IdRemetente = table.Column<long>(type: "bigint(11)", maxLength: 1, nullable: false),
                    CaminhoTxt = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Data = table.Column<DateTime>(type: "date", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consumidor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdLogin = table.Column<long>(nullable: false),
                    IdEndereco = table.Column<long>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Telefone = table.Column<long>(type: "bigint(12)", maxLength: 12, nullable: false),
                    Celular = table.Column<long>(type: "bigint(11)", maxLength: 11, nullable: true),
                    Cpf = table.Column<long>(maxLength: 11, nullable: false),
                    Rg = table.Column<long>(maxLength: 9, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumidor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumidor_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumidor_Login_IdLogin",
                        column: x => x.IdLogin,
                        principalTable: "Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdLogin = table.Column<long>(nullable: false),
                    IdEndereco = table.Column<long>(nullable: false),
                    NomeFantasia = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 60, nullable: true),
                    Telefone = table.Column<int>(type: "int(10)", maxLength: 10, nullable: false),
                    Cnpj = table.Column<long>(maxLength: 14, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresa_Login_IdLogin",
                        column: x => x.IdLogin,
                        principalTable: "Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdLogin = table.Column<long>(nullable: false),
                    IdEndereco = table.Column<long>(nullable: false),
                    IdGrupo = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Telefone = table.Column<long>(type: "bigint(12)", maxLength: 12, nullable: false),
                    Celular = table.Column<long>(type: "bigint(11)", maxLength: 11, nullable: true),
                    Cpf = table.Column<long>(maxLength: 11, nullable: false),
                    Rg = table.Column<long>(maxLength: 9, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestador_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestador_Login_IdLogin",
                        column: x => x.IdLogin,
                        principalTable: "Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPrestadorLider = table.Column<long>(nullable: false),
                    Nome = table.Column<string>(maxLength: 60, nullable: true),
                    Descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupo_Prestador_IdPrestadorLider",
                        column: x => x.IdPrestadorLider,
                        principalTable: "Prestador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPrestador = table.Column<long>(nullable: false),
                    Nivel = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    ValorBase = table.Column<long>(type: "bigint(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habilidade_Prestador_Id",
                        column: x => x.Id,
                        principalTable: "Prestador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumidor_Cpf",
                table: "Consumidor",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consumidor_IdEndereco",
                table: "Consumidor",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Consumidor_IdLogin",
                table: "Consumidor",
                column: "IdLogin");

            migrationBuilder.CreateIndex(
                name: "IX_Consumidor_Rg",
                table: "Consumidor",
                column: "Rg",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Cnpj",
                table: "Empresa",
                column: "Cnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdEndereco",
                table: "Empresa",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdLogin",
                table: "Empresa",
                column: "IdLogin");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_RazaoSocial",
                table: "Empresa",
                column: "RazaoSocial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_IdPrestadorLider",
                table: "Grupo",
                column: "IdPrestadorLider");

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_Nome",
                table: "Grupo",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Login_Email",
                table: "Login",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_Cpf",
                table: "Prestador",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_IdEndereco",
                table: "Prestador",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_IdGrupo",
                table: "Prestador",
                column: "IdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_IdLogin",
                table: "Prestador",
                column: "IdLogin");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_Rg",
                table: "Prestador",
                column: "Rg",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestador_Grupo_IdGrupo",
                table: "Prestador",
                column: "IdGrupo",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestador_Endereco_IdEndereco",
                table: "Prestador");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestador_Login_IdLogin",
                table: "Prestador");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Prestador_IdPrestadorLider",
                table: "Grupo");

            migrationBuilder.DropTable(
                name: "Consumidor");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Mensagem");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Prestador");

            migrationBuilder.DropTable(
                name: "Grupo");
        }
    }
}
