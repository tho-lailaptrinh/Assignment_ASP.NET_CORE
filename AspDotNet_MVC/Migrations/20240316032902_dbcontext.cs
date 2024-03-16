using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspDotNet_MVC.Migrations
{
    public partial class dbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGH = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_IdGH",
                        column: x => x.IdGH,
                        principalTable: "GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHD",
                        column: x => x.IdHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdUser",
                table: "GioHang",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdGH",
                table: "GioHangChiTiet",
                column: "IdGH");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdSP",
                table: "GioHangChiTiet",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdUser",
                table: "HoaDon",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHD",
                table: "HoaDonChiTiet",
                column: "IdHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdSP",
                table: "HoaDonChiTiet",
                column: "IdSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
