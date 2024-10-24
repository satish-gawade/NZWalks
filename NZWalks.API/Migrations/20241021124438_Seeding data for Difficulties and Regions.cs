using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficullties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d4317b2-5240-434a-9418-4ca70061abcc"), "Hard" },
                    { new Guid("85e2bf78-c201-413c-af46-72ae1be9bcd4"), "Medium" },
                    { new Guid("965ca9aa-ede5-4d5e-9953-425825fbb26a"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("8a3570ad-92c1-4b8d-a5bc-2cf2a8e030fb"), "CHC", "Christchurch", "https://example.com/images/christchurch.jpg" },
                    { new Guid("b74fcc6d-e2f4-4fd5-a228-15f00b13ee49"), "AKL", "Auckland", "https://example.com/images/auckland.jpg" },
                    { new Guid("d467fea9-cc5c-4855-8fd5-88d9f2d1ff1d"), "NPE", "Napier", "https://example.com/images/napier.jpg" },
                    { new Guid("e678c8a4-5c92-4c98-8d22-36f30fdff920"), "WLG", "Wellington", "https://example.com/images/wellington.jpg" },
                    { new Guid("f3b29cb1-eeb6-4b67-9f57-46cbb68fbbdf"), "HLZ", "Hamilton", "https://example.com/images/hamilton.jpg" },
                    { new Guid("fa4d23ff-e52e-4b64-8e9e-29a2a1e5f993"), "TRG", "Tauranga", "https://example.com/images/tauranga.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficullties",
                keyColumn: "Id",
                keyValue: new Guid("0d4317b2-5240-434a-9418-4ca70061abcc"));

            migrationBuilder.DeleteData(
                table: "Difficullties",
                keyColumn: "Id",
                keyValue: new Guid("85e2bf78-c201-413c-af46-72ae1be9bcd4"));

            migrationBuilder.DeleteData(
                table: "Difficullties",
                keyColumn: "Id",
                keyValue: new Guid("965ca9aa-ede5-4d5e-9953-425825fbb26a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8a3570ad-92c1-4b8d-a5bc-2cf2a8e030fb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b74fcc6d-e2f4-4fd5-a228-15f00b13ee49"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d467fea9-cc5c-4855-8fd5-88d9f2d1ff1d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e678c8a4-5c92-4c98-8d22-36f30fdff920"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f3b29cb1-eeb6-4b67-9f57-46cbb68fbbdf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fa4d23ff-e52e-4b64-8e9e-29a2a1e5f993"));
        }
    }
}
