using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspDotNet_MVC.Migrations
{
    public partial class dbcontextt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdDMSP",
                table: "SanPham",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdDH",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DanhMucSanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhuongThuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdTT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDVVC = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonHang_Shipping_IdDVVC",
                        column: x => x.IdDVVC,
                        principalTable: "Shipping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_ThanhToan_IdTT",
                        column: x => x.IdTT,
                        principalTable: "ThanhToan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdDMSP",
                table: "SanPham",
                column: "IdDMSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdDH",
                table: "HoaDon",
                column: "IdDH");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_IdDVVC",
                table: "DonHang",
                column: "IdDVVC");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_IdTT",
                table: "DonHang",
                column: "IdTT");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_DonHang_IdDH",
                table: "HoaDon",
                column: "IdDH",
                principalTable: "DonHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_DanhMucSanPham_IdDMSP",
                table: "SanPham",
                column: "IdDMSP",
                principalTable: "DanhMucSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_DonHang_IdDH",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_DanhMucSanPham_IdDMSP",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "DanhMucSanPham");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_IdDMSP",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_IdDH",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "IdDMSP",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "IdDH",
                table: "HoaDon");
        }
    }
}
