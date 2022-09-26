using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenShop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "William McDonough and Michael Braungart imagine how human society might, at last, begin to rewrite its role in the history of the natural world. In The Upcycle, the best-selling authors offer numerous fascinating scenarios in which humans transcend the role of mere stewards of the planet. Instead, they suggest, why not become co-creators of the simplest invention ever: abundance?", "https://kbimages1-a.akamaihd.net/d7bb4cc8-ee43-4156-9782-e271d2f79e1d/353/569/90/False/the-upcycle.jpg", 10m, "The Upcycle: Beyond Sustainability—Designing for Abundance" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Written by award-winning Canadian architect, Teresa Coady, this book is both a call to action and a plan. It starts by tracing how we ended up with our unsustainable concrete jungles, and then it lays out principles and techniques for how to build a better future.\n\nIts highly readable prose is for anyone who wants be part of, or simply imagine, a more natural and sustainably built environment.", "https://zerowastememoirs.com/wp-content/uploads/2020/10/Screenshot-2020-10-24-at-16.35.34.png.webp", 10m, "Rebuilding Earth: Designing Ecoconscious Habitats for Humans" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Written by William McDonough and Michael Braungart. Did you know that up to 90% of the materials used in traditional manufacturing models ends up as waste? This book challenges the way the traditional “cradle to grave” cycle works and envisions a world where we don’t have to harm the natural environment in order to create new products.", "https://zerowastememoirs.com/wp-content/uploads/2020/10/Screenshot-2020-10-24-at-16.25.09.png.webp", 10m, "Cradle to Cradle: Remaking the Way We Make Things" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
