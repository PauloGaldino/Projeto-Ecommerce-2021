using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AlterNameTableIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "Identity_UsuarioTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "Identity_UsuarioFuncao");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "Identity_UsuarioLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "Identity_UsuarioDeclaracao");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Identity_Funcao");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "Identity_FuncaoDeclaracao");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "Identity_UsuarioFuncao",
                newName: "IX_Identity_UsuarioFuncao_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "Identity_UsuarioLogins",
                newName: "IX_Identity_UsuarioLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "Identity_UsuarioDeclaracao",
                newName: "IX_Identity_UsuarioDeclaracao_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "Identity_FuncaoDeclaracao",
                newName: "IX_Identity_FuncaoDeclaracao_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity_UsuarioTokens",
                table: "Identity_UsuarioTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity_UsuarioFuncao",
                table: "Identity_UsuarioFuncao",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity_UsuarioLogins",
                table: "Identity_UsuarioLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity_UsuarioDeclaracao",
                table: "Identity_UsuarioDeclaracao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity_Funcao",
                table: "Identity_Funcao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity_FuncaoDeclaracao",
                table: "Identity_FuncaoDeclaracao",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Identity_Usuario",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_Usuario", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_FuncaoDeclaracao_Identity_Funcao_RoleId",
                table: "Identity_FuncaoDeclaracao",
                column: "RoleId",
                principalTable: "Identity_Funcao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_UsuarioDeclaracao_AspNetUsers_UserId",
                table: "Identity_UsuarioDeclaracao",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_UsuarioFuncao_AspNetUsers_UserId",
                table: "Identity_UsuarioFuncao",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_UsuarioFuncao_Identity_Funcao_RoleId",
                table: "Identity_UsuarioFuncao",
                column: "RoleId",
                principalTable: "Identity_Funcao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_UsuarioLogins_AspNetUsers_UserId",
                table: "Identity_UsuarioLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_UsuarioTokens_AspNetUsers_UserId",
                table: "Identity_UsuarioTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identity_FuncaoDeclaracao_Identity_Funcao_RoleId",
                table: "Identity_FuncaoDeclaracao");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity_UsuarioDeclaracao_AspNetUsers_UserId",
                table: "Identity_UsuarioDeclaracao");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity_UsuarioFuncao_AspNetUsers_UserId",
                table: "Identity_UsuarioFuncao");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity_UsuarioFuncao_Identity_Funcao_RoleId",
                table: "Identity_UsuarioFuncao");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity_UsuarioLogins_AspNetUsers_UserId",
                table: "Identity_UsuarioLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity_UsuarioTokens_AspNetUsers_UserId",
                table: "Identity_UsuarioTokens");

            migrationBuilder.DropTable(
                name: "Identity_Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity_UsuarioTokens",
                table: "Identity_UsuarioTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity_UsuarioLogins",
                table: "Identity_UsuarioLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity_UsuarioFuncao",
                table: "Identity_UsuarioFuncao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity_UsuarioDeclaracao",
                table: "Identity_UsuarioDeclaracao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity_FuncaoDeclaracao",
                table: "Identity_FuncaoDeclaracao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity_Funcao",
                table: "Identity_Funcao");

            migrationBuilder.RenameTable(
                name: "Identity_UsuarioTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Identity_UsuarioLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "Identity_UsuarioFuncao",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Identity_UsuarioDeclaracao",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Identity_FuncaoDeclaracao",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Identity_Funcao",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_Identity_UsuarioLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Identity_UsuarioFuncao_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Identity_UsuarioDeclaracao_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Identity_FuncaoDeclaracao_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
