using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class afasfsdfsdfsdfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icons_Services_ServiceId",
                table: "Icons");

            migrationBuilder.DropIndex(
                name: "IX_Icons_ServiceId",
                table: "Icons");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Icons");

            migrationBuilder.AddColumn<int>(
                name: "IconsId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_IconsId",
                table: "Services",
                column: "IconsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Icons_IconsId",
                table: "Services",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Icons_IconsId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_IconsId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IconsId",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Icons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Icons_ServiceId",
                table: "Icons",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Icons_Services_ServiceId",
                table: "Icons",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
