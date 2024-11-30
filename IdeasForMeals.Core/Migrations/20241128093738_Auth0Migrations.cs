using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdeasForMeals.Core.Migrations
{
    /// <inheritdoc />
    public partial class Auth0Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Alias",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("05e455d5-07c4-45ca-b8f9-7e4ec486432e"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("08b469b0-94cd-4a51-9009-88f09c1134c3"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0d4f8fab-2760-40da-8c3f-26157405e9ed"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("106133e7-147e-4114-86e4-03cd469143a4"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("12e4302d-c9cc-4be1-af8a-22b618d2fd26"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("154a3bba-27a3-43a1-97ee-2f0ae1ce720e"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("1983be0a-a325-467f-858b-0043ba91ce2a"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("253c1301-5a11-40b2-9bf9-2b2fda318158"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2745603c-8621-4670-a8bc-d66fa794c007"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("27f9401f-58ca-4ab4-be5f-811ccd010733"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2969dc1c-e08c-47a9-84b3-e2461f776d1c"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2cc97f8b-4ebe-48c1-ae94-189c7670a74d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("307c11e8-fb5e-44c3-8477-01a368d7c2a6"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3345cec1-b8fd-4e34-ab4c-daaca02534c1"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("353ebf63-4a76-4786-bb3f-05116d616410"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("363f1c8d-09c9-407e-9858-3c44268a16d2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("36703682-0e47-4a00-b286-3c4d29520e40"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("36e201d7-f576-4c92-ad84-e4b6d060caf2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("383d1569-338a-45e5-991b-7c72afc9e2e2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3d5d0522-4fd9-4814-8632-6d9b490f7b7d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("41fb98af-529c-4d13-8fee-58b6e3367176"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("42ef7c71-de0e-4700-8fe0-d39c3ba47a7e"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("47a0dead-a61f-453f-afc1-1709883c9c42"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("489a5fcd-b6ac-4030-88ec-4d3a9a607970"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("5013264a-0117-42e5-9b57-fddc3fa8c9a1"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("5142ce13-4f3f-45ff-9ada-ecc9adf95f53"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("522a7860-6362-49a0-b28f-27aaa2498126"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("52402050-dd51-49bc-ac52-432c4a704087"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("530ea87c-62d0-49d4-a0b8-dcd04bd23e78"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("57d754ca-8ed2-455b-b010-ec0fe9aa5f8a"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("668822b3-f9ee-4fdc-8122-62641746f29f"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("69e76b8b-2202-4261-9dd2-e4c4d16b15df"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6d345e8a-cc7b-4afb-ba6e-648b167edd84"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6d44738f-cd18-45e7-af35-35877dd766a2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("714e1df8-8be8-4017-9786-d0f8d69d2057"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("747ac374-9c71-4d97-8b4b-8759e6898f38"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("7cdc30fc-6596-425e-a1a3-f4edda9bccb7"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("7db5ad0a-854c-47d9-ac2b-d4befb959d54"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("81a682c6-a98b-473d-a780-ffbe06d61fd6"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("820b5ad4-b6fc-497c-ad2a-b986f635524d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("837a783a-e2eb-4920-aba0-7b5ce8a1763b"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("84502f61-4123-4c6a-8a15-474f63565f40"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("8485ca52-09e1-488a-bb37-cf3649b167b2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("885c4a5d-8614-40a9-a523-3b674618fec9"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("8fa1a971-5d68-48cb-b769-f2b1bf468e33"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("94ce74a8-bb5a-4970-8132-05bbc51dfbf7"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("9cce5e81-f571-4c28-ae3e-4e5995fdd7e0"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("9fe94dca-9fb1-40e5-ad03-626bddc475c1"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a6254d59-593e-4f5b-8f51-bb5d9f6f3a79"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a6fd581a-6e07-44a1-91b2-28adb3d4e726"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a7592bfc-50fb-4a8a-bbc7-0167479de524"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a7808601-1916-4a7f-a949-41f580f3da79"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("aa47704c-d294-4535-a9a6-5a0706f516bd"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("abc68a40-3781-4878-93d8-70933452cb29"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("aca9fbdd-0d4e-4683-b5a2-de2c1c619f5f"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("aeae96ba-5591-43e6-927d-e187d2064929"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b1834d96-049d-4615-9753-6f01dd3eeb52"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b22ad4a7-40e1-433b-a7d2-2fa8b8c926d2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ba7434b4-3c14-40ea-8631-2895254ad01b"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("bd2dd871-4302-4fc8-9325-071dbd9171a3"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c3238af2-ae27-4f74-9b86-b069ec30dc08"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c7db65a1-6d7f-4c5f-8885-614416539a4b"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("cc68ca7e-30b1-41e7-8020-48a04705d25d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d2d38880-e1e9-40fe-9c9f-56f1b3607e22"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d45d1760-24a6-4cd7-a47e-e3eb0df7f3bb"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d66355d6-a59e-45ed-b7ed-28eceaf6c300"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d672c5cd-5bcd-4efe-8a79-d99481d68eb0"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("dbc0f7a5-e60f-4835-88a2-ca08f943fe27"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("df96ffe2-5c90-4aba-b0df-910050b9a54f"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("dfaf423b-72b4-4f14-841a-a0b70a0b4164"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e03d1cf5-2dfe-4beb-bbe9-3591aeeacd20"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e4ef6482-4011-495e-bcd9-62077f232468"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e91d1782-4a29-4a02-97b4-4b1fae8168b6"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f2e29b33-689f-402b-a57f-fc3b5d85d755"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f8b668d9-d4cc-471e-946c-4ca09df73055"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ff815635-ddca-4c92-9f1e-943445d445af"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3") });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("05e455d5-07c4-45ca-b8f9-7e4ec486432e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("08b469b0-94cd-4a51-9009-88f09c1134c3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0d4f8fab-2760-40da-8c3f-26157405e9ed"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("106133e7-147e-4114-86e4-03cd469143a4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("12e4302d-c9cc-4be1-af8a-22b618d2fd26"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("154a3bba-27a3-43a1-97ee-2f0ae1ce720e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("1983be0a-a325-467f-858b-0043ba91ce2a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("253c1301-5a11-40b2-9bf9-2b2fda318158"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2745603c-8621-4670-a8bc-d66fa794c007"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("27f9401f-58ca-4ab4-be5f-811ccd010733"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2969dc1c-e08c-47a9-84b3-e2461f776d1c"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2cc97f8b-4ebe-48c1-ae94-189c7670a74d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("307c11e8-fb5e-44c3-8477-01a368d7c2a6"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3345cec1-b8fd-4e34-ab4c-daaca02534c1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("353ebf63-4a76-4786-bb3f-05116d616410"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("363f1c8d-09c9-407e-9858-3c44268a16d2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("36703682-0e47-4a00-b286-3c4d29520e40"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("36e201d7-f576-4c92-ad84-e4b6d060caf2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("383d1569-338a-45e5-991b-7c72afc9e2e2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3d5d0522-4fd9-4814-8632-6d9b490f7b7d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("41fb98af-529c-4d13-8fee-58b6e3367176"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("42ef7c71-de0e-4700-8fe0-d39c3ba47a7e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("47a0dead-a61f-453f-afc1-1709883c9c42"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("489a5fcd-b6ac-4030-88ec-4d3a9a607970"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5013264a-0117-42e5-9b57-fddc3fa8c9a1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5142ce13-4f3f-45ff-9ada-ecc9adf95f53"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("522a7860-6362-49a0-b28f-27aaa2498126"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("52402050-dd51-49bc-ac52-432c4a704087"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("530ea87c-62d0-49d4-a0b8-dcd04bd23e78"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("57d754ca-8ed2-455b-b010-ec0fe9aa5f8a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("668822b3-f9ee-4fdc-8122-62641746f29f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("69e76b8b-2202-4261-9dd2-e4c4d16b15df"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6d345e8a-cc7b-4afb-ba6e-648b167edd84"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6d44738f-cd18-45e7-af35-35877dd766a2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("714e1df8-8be8-4017-9786-d0f8d69d2057"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("747ac374-9c71-4d97-8b4b-8759e6898f38"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("7cdc30fc-6596-425e-a1a3-f4edda9bccb7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("7db5ad0a-854c-47d9-ac2b-d4befb959d54"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("81a682c6-a98b-473d-a780-ffbe06d61fd6"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("820b5ad4-b6fc-497c-ad2a-b986f635524d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("837a783a-e2eb-4920-aba0-7b5ce8a1763b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("84502f61-4123-4c6a-8a15-474f63565f40"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("8485ca52-09e1-488a-bb37-cf3649b167b2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("885c4a5d-8614-40a9-a523-3b674618fec9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("8fa1a971-5d68-48cb-b769-f2b1bf468e33"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("94ce74a8-bb5a-4970-8132-05bbc51dfbf7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9cce5e81-f571-4c28-ae3e-4e5995fdd7e0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9fe94dca-9fb1-40e5-ad03-626bddc475c1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a6254d59-593e-4f5b-8f51-bb5d9f6f3a79"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a6fd581a-6e07-44a1-91b2-28adb3d4e726"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a7592bfc-50fb-4a8a-bbc7-0167479de524"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a7808601-1916-4a7f-a949-41f580f3da79"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("aa47704c-d294-4535-a9a6-5a0706f516bd"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("abc68a40-3781-4878-93d8-70933452cb29"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("aca9fbdd-0d4e-4683-b5a2-de2c1c619f5f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("aeae96ba-5591-43e6-927d-e187d2064929"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b1834d96-049d-4615-9753-6f01dd3eeb52"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b22ad4a7-40e1-433b-a7d2-2fa8b8c926d2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ba7434b4-3c14-40ea-8631-2895254ad01b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("bd2dd871-4302-4fc8-9325-071dbd9171a3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c3238af2-ae27-4f74-9b86-b069ec30dc08"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c7db65a1-6d7f-4c5f-8885-614416539a4b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("cc68ca7e-30b1-41e7-8020-48a04705d25d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d2d38880-e1e9-40fe-9c9f-56f1b3607e22"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d45d1760-24a6-4cd7-a47e-e3eb0df7f3bb"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d66355d6-a59e-45ed-b7ed-28eceaf6c300"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d672c5cd-5bcd-4efe-8a79-d99481d68eb0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("dbc0f7a5-e60f-4835-88a2-ca08f943fe27"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("df96ffe2-5c90-4aba-b0df-910050b9a54f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("dfaf423b-72b4-4f14-841a-a0b70a0b4164"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e03d1cf5-2dfe-4beb-bbe9-3591aeeacd20"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e4ef6482-4011-495e-bcd9-62077f232468"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e91d1782-4a29-4a02-97b4-4b1fae8168b6"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f2e29b33-689f-402b-a57f-fc3b5d85d755"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f8b668d9-d4cc-471e-946c-4ca09df73055"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ff815635-ddca-4c92-9f1e-943445d445af"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"));

            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "IdAuth0",
                table: "Users",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "FoodGroups",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2211), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2211), "fruit" },
                    { new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2209), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2210), "vegetable" },
                    { new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2205), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2206), "carbohydrate" },
                    { new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2208), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2208), "protein" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "IdAuth0", "ModifiedAt" },
                values: new object[] { new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2167), "auth0|admin", new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "FoodGroupId", "FromInitialSeed", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("03133477-bc82-4253-b6ee-e3dcc17c17de"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2417), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2417), "tofu" },
                    { new Guid("0bb07691-6e4b-4b10-ad68-73b09cd420a8"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2413), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2413), "edam cheese" },
                    { new Guid("0bbe23b3-1b2c-41a7-875d-0d5304da8e93"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2282), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2282), "brussels sprout" },
                    { new Guid("14dbaa31-f2ab-4ff7-9486-98041542123f"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2251), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2251), "lentil" },
                    { new Guid("19e83373-5e53-42da-8573-a3a4a00e191d"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2255), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2256), "corn" },
                    { new Guid("1c5bcf3f-7447-440f-9f0c-71ce056840cb"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2329), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2329), "leek" },
                    { new Guid("20a4b9d6-3964-4e17-8c54-a50243b0116b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2294), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2294), "cauliflower" },
                    { new Guid("23e6345e-fbf3-485d-9a37-da820724afaf"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2288), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2288), "kale" },
                    { new Guid("24ba5169-189f-45de-a3e2-c90a4a3f4264"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2444), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2445), "rump steak" },
                    { new Guid("27241ec1-961c-4e69-8f7f-2818d369adb2"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2415), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2415), "gruyere cheese" },
                    { new Guid("2a93dbcb-71a3-41ca-ae34-db60ba9ea571"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2423), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2424), "falafel" },
                    { new Guid("2d2d5f33-30aa-416c-b172-e71a14a26902"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2438), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2438), "chicken breast" },
                    { new Guid("2f0d9b6b-6853-49b6-97e8-a30c22007a3a"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2290), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2290), "white cabbage" },
                    { new Guid("2f7d2717-dac1-476b-be93-f3992eb708c0"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2367), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2367), "apple" },
                    { new Guid("312ee54a-a740-47bb-b471-ddde967d8471"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2262), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2262), "tomato" },
                    { new Guid("32812b77-a609-404b-b840-96750306f250"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2343), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2344), "turnip" },
                    { new Guid("3300814d-121c-4f6f-9f24-83a3893c81d7"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2392), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2392), "plum" },
                    { new Guid("33e0fa42-2e1a-40f2-b54d-1e371336f3ff"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2350), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2350), "asparagus" },
                    { new Guid("3a34c2f6-4571-4686-aa78-3ff4fad7d00b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2279), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2280), "endive" },
                    { new Guid("3c0925fe-f3a2-48cb-96c3-93bc32a03257"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2400), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2401), "greek yoghurt" },
                    { new Guid("3c4add16-8280-4bc4-b890-1f39eaf5f965"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2356), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2356), "chard" },
                    { new Guid("3dabfc3e-1d66-4290-ac33-a82cb17cb84b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2381), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2381), "raspberry" },
                    { new Guid("3ea66729-49ab-4071-b0da-2b5c56f85ca6"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2225), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2226), "potato" },
                    { new Guid("3fa22622-d6d1-4ba8-b0e2-dfe3d3a4245f"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2436), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2436), "cashew nut" },
                    { new Guid("443210a9-00a5-467d-b042-7244b244d246"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2341), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2342), "white celery" },
                    { new Guid("464a63cf-a15f-4b78-bbcc-1731ab9b3155"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2260), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2260), "tortilla" },
                    { new Guid("4e300ea6-00d8-4a2a-affd-08028f7b51f8"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2339), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2339), "celery stalk" },
                    { new Guid("4e40705f-abbd-4c29-8561-034557e39656"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2296), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2297), "chinese cabbage" },
                    { new Guid("4e49281d-9a97-4fc9-a529-ca9aef376a65"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2373), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2373), "orange" },
                    { new Guid("51a80e6d-aea6-4893-b67b-31a525be5704"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2275), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2275), "button mushroom" },
                    { new Guid("549a58ad-b5d3-4638-a819-f2f6e85ad2f9"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2407), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2407), "mozzarella" },
                    { new Guid("5951ab56-be2a-4c39-a505-f346b87c93b1"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2421), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2422), "seitan" },
                    { new Guid("59a7f9ca-ac13-49e9-a183-33dacc43138d"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2249), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2249), "sweet potato" },
                    { new Guid("5b75ca91-fe60-4efc-a956-1b2af7b2fbf5"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2292), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2292), "red cabbage" },
                    { new Guid("64376786-d6ef-4fda-ada2-fb377ed1a51d"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2369), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2369), "banana" },
                    { new Guid("68bcd55f-6684-45bc-bb3d-d88250dd4b7a"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2360), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2361), "pea" },
                    { new Guid("6d93d2dc-eb1f-4171-87d0-5995978376cd"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2277), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2277), "oyster mushroom" },
                    { new Guid("6e064c1c-361e-4fba-9653-0e68ad4708ef"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2284), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2284), "green cabbage" },
                    { new Guid("6eb0b6d1-d9dd-4e5d-9544-2f9d8d5ac1a0"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2440), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2440), "pork tenderloin" },
                    { new Guid("6f398c4e-831f-44f5-82ae-f71b41d28ffc"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2257), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2258), "pita bread" },
                    { new Guid("6fee0312-1e82-4974-8ce7-8ace0f895e98"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2434), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2434), "chickpea" },
                    { new Guid("70acc349-ee51-4c9b-8221-8b9128364c1b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2264), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2264), "onion" },
                    { new Guid("76bbb1ac-23f4-4453-9b5b-3972f3c53b06"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2379), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2379), "strawberry" },
                    { new Guid("825f0e7b-7cfb-4ee0-8bc9-708e4fbc63a4"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2442), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2442), "salmon fillet" },
                    { new Guid("86971c95-96b0-49d0-926f-bcd00ab16897"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2411), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2411), "gouda cheese" },
                    { new Guid("8c878de8-16ab-4562-bf5d-060cc2777645"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2335), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2335), "beetroot" },
                    { new Guid("8dbf0c42-d6d5-4861-be9a-bc2dd2fb6a15"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2469), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2470), "minced turkey" },
                    { new Guid("934633ae-5b57-42a6-9861-e008c9537cdb"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2337), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2337), "celeriac" },
                    { new Guid("9580d1e4-ddaf-49a3-94b8-db7ea95ce40f"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2394), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2394), "apricot" },
                    { new Guid("99d1dbbc-d8c8-4c60-a608-945e3bf4f5ba"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2383), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2383), "fig" },
                    { new Guid("a3eb921f-20b7-440d-b760-11717f1c40d0"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2271), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2271), "carrot" },
                    { new Guid("aef811d1-a4cb-495d-b4e2-eef96b65e2b4"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2268), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2269), "courgette" },
                    { new Guid("b0e18418-3b4b-48ae-bdce-22a423cbc00a"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2432), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2432), "black bean" },
                    { new Guid("b10b3724-9575-42a6-a034-a24593663736"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2388), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2388), "melon" },
                    { new Guid("b183772c-ba9f-49b0-bf36-e2f114fbc26b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2385), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2386), "peach" },
                    { new Guid("b4ae6205-2252-4447-831a-4f7e74636ef0"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2223), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2223), "wholegrain rice" },
                    { new Guid("b5202660-c0fb-4033-a37f-2b4e784703ef"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2362), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2363), "eggplant" },
                    { new Guid("bf1d1d3a-44cf-47ca-9b02-46da9f3d75cb"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2348), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2348), "jerusalem artichoke" },
                    { new Guid("bf88f66c-e064-41cc-abef-1708cab8eea4"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2377), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2377), "pear" },
                    { new Guid("c36bd6e1-c276-4961-9434-567988ef4cad"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2429), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2430), "tempeh" },
                    { new Guid("cb01490a-9aa6-4d0b-8803-5e1e49651a09"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2358), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2358), "broccoli" },
                    { new Guid("d02684bb-701f-49f9-8527-c298a83ee326"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2221), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2221), "wholegrain pasta" },
                    { new Guid("d1544a97-45ce-43de-9ba6-1d96ff504c57"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2426), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2426), "quorn" },
                    { new Guid("d1be2f64-73b2-4b88-9b32-040e2dfebe9e"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2253), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2253), "quinoa" },
                    { new Guid("d3b7b4f6-0823-4581-b8c6-b93d478a3ed3"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2398), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2399), "egg" },
                    { new Guid("e04da8a4-3a18-46f9-a950-deccc4f0386b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2331), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2331), "radish" },
                    { new Guid("e10a927b-0001-4f92-84cc-2dedf2eee342"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2375), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2375), "mandarin orange" },
                    { new Guid("e5be86b1-aaa4-4545-b409-eeeff69fe172"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2365), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2365), "cucumber" },
                    { new Guid("ebeb808d-91ff-406f-8e7a-f182cdaadc37"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2405), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2405), "pecorino" },
                    { new Guid("ecbfff9d-9c95-42b4-8959-cb725f06bd60"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2354), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2354), "spinach" },
                    { new Guid("f035a8e2-02e5-4bab-9714-65ad1ef4caf4"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2396), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2397), "grape" },
                    { new Guid("f1ec37e2-64e5-4b1a-b7b2-4e05bb34d527"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2346), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2346), "butternut squash" },
                    { new Guid("f2e35bef-d96e-4cda-8842-bc1add69cd9b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2273), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2273), "bell pepper" },
                    { new Guid("f4683513-9073-4f9b-9646-2ee93b8bd61b"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2419), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2419), "soya protein" },
                    { new Guid("fd6d95f2-b1ec-4d77-90fb-b449457de870"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2403), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2403), "cottage cheese" },
                    { new Guid("ff2118af-5ebf-4f7d-8721-281d65a3fd5a"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2326), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), null, new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2327), "parsnip" }
                });

            migrationBuilder.InsertData(
                table: "UserFoods",
                columns: new[] { "FoodId", "UserId", "CreatedAt", "IsCurrentDiet", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("03133477-bc82-4253-b6ee-e3dcc17c17de"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2537), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2537) },
                    { new Guid("0bb07691-6e4b-4b10-ad68-73b09cd420a8"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2535), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2536) },
                    { new Guid("0bbe23b3-1b2c-41a7-875d-0d5304da8e93"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2499), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2500) },
                    { new Guid("14dbaa31-f2ab-4ff7-9486-98041542123f"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2485), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2486) },
                    { new Guid("19e83373-5e53-42da-8573-a3a4a00e191d"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2489), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2489) },
                    { new Guid("1c5bcf3f-7447-440f-9f0c-71ce056840cb"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2506), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2506) },
                    { new Guid("20a4b9d6-3964-4e17-8c54-a50243b0116b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2503), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2504) },
                    { new Guid("23e6345e-fbf3-485d-9a37-da820724afaf"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2501), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2501) },
                    { new Guid("24ba5169-189f-45de-a3e2-c90a4a3f4264"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2576), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2576) },
                    { new Guid("27241ec1-961c-4e69-8f7f-2818d369adb2"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2536), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2537) },
                    { new Guid("2a93dbcb-71a3-41ca-ae34-db60ba9ea571"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2541), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2541) },
                    { new Guid("2d2d5f33-30aa-416c-b172-e71a14a26902"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2574), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2574) },
                    { new Guid("2f0d9b6b-6853-49b6-97e8-a30c22007a3a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2502), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2502) },
                    { new Guid("2f7d2717-dac1-476b-be93-f3992eb708c0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2520), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2520) },
                    { new Guid("312ee54a-a740-47bb-b471-ddde967d8471"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2492), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2492) },
                    { new Guid("32812b77-a609-404b-b840-96750306f250"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2511), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2511) },
                    { new Guid("3300814d-121c-4f6f-9f24-83a3893c81d7"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2528), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2528) },
                    { new Guid("33e0fa42-2e1a-40f2-b54d-1e371336f3ff"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2514), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2515) },
                    { new Guid("3a34c2f6-4571-4686-aa78-3ff4fad7d00b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2498), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2498) },
                    { new Guid("3c0925fe-f3a2-48cb-96c3-93bc32a03257"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2531), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2532) },
                    { new Guid("3c4add16-8280-4bc4-b890-1f39eaf5f965"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2516), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2516) },
                    { new Guid("3dabfc3e-1d66-4290-ac33-a82cb17cb84b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2525), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2525) },
                    { new Guid("3ea66729-49ab-4071-b0da-2b5c56f85ca6"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2484), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2484) },
                    { new Guid("3fa22622-d6d1-4ba8-b0e2-dfe3d3a4245f"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2573), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2573) },
                    { new Guid("443210a9-00a5-467d-b042-7244b244d246"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2510), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2510) },
                    { new Guid("464a63cf-a15f-4b78-bbcc-1731ab9b3155"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2490), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2491) },
                    { new Guid("4e300ea6-00d8-4a2a-affd-08028f7b51f8"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2509), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2509) },
                    { new Guid("4e40705f-abbd-4c29-8561-034557e39656"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2504), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2504) },
                    { new Guid("4e49281d-9a97-4fc9-a529-ca9aef376a65"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2522), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2522) },
                    { new Guid("51a80e6d-aea6-4893-b67b-31a525be5704"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2496), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2496) },
                    { new Guid("549a58ad-b5d3-4638-a819-f2f6e85ad2f9"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2534), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2534) },
                    { new Guid("5951ab56-be2a-4c39-a505-f346b87c93b1"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2539), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2539) },
                    { new Guid("59a7f9ca-ac13-49e9-a183-33dacc43138d"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2485), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2485) },
                    { new Guid("5b75ca91-fe60-4efc-a956-1b2af7b2fbf5"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2503), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2503) },
                    { new Guid("64376786-d6ef-4fda-ada2-fb377ed1a51d"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2521), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2521) },
                    { new Guid("68bcd55f-6684-45bc-bb3d-d88250dd4b7a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2517), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2518) },
                    { new Guid("6d93d2dc-eb1f-4171-87d0-5995978376cd"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2497), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2497) },
                    { new Guid("6e064c1c-361e-4fba-9653-0e68ad4708ef"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2500), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2500) },
                    { new Guid("6eb0b6d1-d9dd-4e5d-9544-2f9d8d5ac1a0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2574), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2575) },
                    { new Guid("6f398c4e-831f-44f5-82ae-f71b41d28ffc"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2489), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2490) },
                    { new Guid("6fee0312-1e82-4974-8ce7-8ace0f895e98"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2572), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2572) },
                    { new Guid("70acc349-ee51-4c9b-8221-8b9128364c1b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2493), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2493) },
                    { new Guid("76bbb1ac-23f4-4453-9b5b-3972f3c53b06"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2524), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2524) },
                    { new Guid("825f0e7b-7cfb-4ee0-8bc9-708e4fbc63a4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2575), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2576) },
                    { new Guid("86971c95-96b0-49d0-926f-bcd00ab16897"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2535), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2535) },
                    { new Guid("8c878de8-16ab-4562-bf5d-060cc2777645"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2507), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2508) },
                    { new Guid("8dbf0c42-d6d5-4861-be9a-bc2dd2fb6a15"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2577), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2577) },
                    { new Guid("934633ae-5b57-42a6-9861-e008c9537cdb"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2508), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2509) },
                    { new Guid("9580d1e4-ddaf-49a3-94b8-db7ea95ce40f"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2529), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2529) },
                    { new Guid("99d1dbbc-d8c8-4c60-a608-945e3bf4f5ba"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2526), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2526) },
                    { new Guid("a3eb921f-20b7-440d-b760-11717f1c40d0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2494), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2495) },
                    { new Guid("aef811d1-a4cb-495d-b4e2-eef96b65e2b4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2493), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2494) },
                    { new Guid("b0e18418-3b4b-48ae-bdce-22a423cbc00a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2571), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2571) },
                    { new Guid("b10b3724-9575-42a6-a034-a24593663736"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2527), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2528) },
                    { new Guid("b183772c-ba9f-49b0-bf36-e2f114fbc26b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2526), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2527) },
                    { new Guid("b4ae6205-2252-4447-831a-4f7e74636ef0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2483), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2483) },
                    { new Guid("b5202660-c0fb-4033-a37f-2b4e784703ef"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2518), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2519) },
                    { new Guid("bf1d1d3a-44cf-47ca-9b02-46da9f3d75cb"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2513), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2514) },
                    { new Guid("bf88f66c-e064-41cc-abef-1708cab8eea4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2523), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2524) },
                    { new Guid("c36bd6e1-c276-4961-9434-567988ef4cad"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2570), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2570) },
                    { new Guid("cb01490a-9aa6-4d0b-8803-5e1e49651a09"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2517), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2517) },
                    { new Guid("d02684bb-701f-49f9-8527-c298a83ee326"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2478), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2479) },
                    { new Guid("d1544a97-45ce-43de-9ba6-1d96ff504c57"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2541), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2542) },
                    { new Guid("d1be2f64-73b2-4b88-9b32-040e2dfebe9e"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2488), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2488) },
                    { new Guid("d3b7b4f6-0823-4581-b8c6-b93d478a3ed3"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2531), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2531) },
                    { new Guid("e04da8a4-3a18-46f9-a950-deccc4f0386b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2507), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2507) },
                    { new Guid("e10a927b-0001-4f92-84cc-2dedf2eee342"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2522), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2523) },
                    { new Guid("e5be86b1-aaa4-4545-b409-eeeff69fe172"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2519), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2519) },
                    { new Guid("ebeb808d-91ff-406f-8e7a-f182cdaadc37"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2533), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2533) },
                    { new Guid("ecbfff9d-9c95-42b4-8959-cb725f06bd60"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2515), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2515) },
                    { new Guid("f035a8e2-02e5-4bab-9714-65ad1ef4caf4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2530), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2530) },
                    { new Guid("f1ec37e2-64e5-4b1a-b7b2-4e05bb34d527"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2512), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2512) },
                    { new Guid("f2e35bef-d96e-4cda-8842-bc1add69cd9b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2495), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2495) },
                    { new Guid("f4683513-9073-4f9b-9646-2ee93b8bd61b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2538), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2538) },
                    { new Guid("fd6d95f2-b1ec-4d77-90fb-b449457de870"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2532), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2532) },
                    { new Guid("ff2118af-5ebf-4f7d-8721-281d65a3fd5a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"), new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2505), true, new DateTime(2024, 11, 28, 9, 37, 37, 997, DateTimeKind.Utc).AddTicks(2505) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdAuth0",
                table: "Users",
                column: "IdAuth0",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_IdAuth0",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("03133477-bc82-4253-b6ee-e3dcc17c17de"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0bb07691-6e4b-4b10-ad68-73b09cd420a8"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0bbe23b3-1b2c-41a7-875d-0d5304da8e93"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("14dbaa31-f2ab-4ff7-9486-98041542123f"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("19e83373-5e53-42da-8573-a3a4a00e191d"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("1c5bcf3f-7447-440f-9f0c-71ce056840cb"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("20a4b9d6-3964-4e17-8c54-a50243b0116b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("23e6345e-fbf3-485d-9a37-da820724afaf"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("24ba5169-189f-45de-a3e2-c90a4a3f4264"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("27241ec1-961c-4e69-8f7f-2818d369adb2"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2a93dbcb-71a3-41ca-ae34-db60ba9ea571"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2d2d5f33-30aa-416c-b172-e71a14a26902"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2f0d9b6b-6853-49b6-97e8-a30c22007a3a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2f7d2717-dac1-476b-be93-f3992eb708c0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("312ee54a-a740-47bb-b471-ddde967d8471"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("32812b77-a609-404b-b840-96750306f250"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3300814d-121c-4f6f-9f24-83a3893c81d7"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("33e0fa42-2e1a-40f2-b54d-1e371336f3ff"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3a34c2f6-4571-4686-aa78-3ff4fad7d00b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3c0925fe-f3a2-48cb-96c3-93bc32a03257"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3c4add16-8280-4bc4-b890-1f39eaf5f965"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3dabfc3e-1d66-4290-ac33-a82cb17cb84b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3ea66729-49ab-4071-b0da-2b5c56f85ca6"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3fa22622-d6d1-4ba8-b0e2-dfe3d3a4245f"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("443210a9-00a5-467d-b042-7244b244d246"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("464a63cf-a15f-4b78-bbcc-1731ab9b3155"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("4e300ea6-00d8-4a2a-affd-08028f7b51f8"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("4e40705f-abbd-4c29-8561-034557e39656"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("4e49281d-9a97-4fc9-a529-ca9aef376a65"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("51a80e6d-aea6-4893-b67b-31a525be5704"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("549a58ad-b5d3-4638-a819-f2f6e85ad2f9"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("5951ab56-be2a-4c39-a505-f346b87c93b1"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("59a7f9ca-ac13-49e9-a183-33dacc43138d"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("5b75ca91-fe60-4efc-a956-1b2af7b2fbf5"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("64376786-d6ef-4fda-ada2-fb377ed1a51d"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("68bcd55f-6684-45bc-bb3d-d88250dd4b7a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6d93d2dc-eb1f-4171-87d0-5995978376cd"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6e064c1c-361e-4fba-9653-0e68ad4708ef"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6eb0b6d1-d9dd-4e5d-9544-2f9d8d5ac1a0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6f398c4e-831f-44f5-82ae-f71b41d28ffc"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6fee0312-1e82-4974-8ce7-8ace0f895e98"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("70acc349-ee51-4c9b-8221-8b9128364c1b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("76bbb1ac-23f4-4453-9b5b-3972f3c53b06"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("825f0e7b-7cfb-4ee0-8bc9-708e4fbc63a4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("86971c95-96b0-49d0-926f-bcd00ab16897"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("8c878de8-16ab-4562-bf5d-060cc2777645"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("8dbf0c42-d6d5-4861-be9a-bc2dd2fb6a15"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("934633ae-5b57-42a6-9861-e008c9537cdb"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("9580d1e4-ddaf-49a3-94b8-db7ea95ce40f"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("99d1dbbc-d8c8-4c60-a608-945e3bf4f5ba"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a3eb921f-20b7-440d-b760-11717f1c40d0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("aef811d1-a4cb-495d-b4e2-eef96b65e2b4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b0e18418-3b4b-48ae-bdce-22a423cbc00a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b10b3724-9575-42a6-a034-a24593663736"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b183772c-ba9f-49b0-bf36-e2f114fbc26b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b4ae6205-2252-4447-831a-4f7e74636ef0"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b5202660-c0fb-4033-a37f-2b4e784703ef"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("bf1d1d3a-44cf-47ca-9b02-46da9f3d75cb"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("bf88f66c-e064-41cc-abef-1708cab8eea4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c36bd6e1-c276-4961-9434-567988ef4cad"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("cb01490a-9aa6-4d0b-8803-5e1e49651a09"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d02684bb-701f-49f9-8527-c298a83ee326"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d1544a97-45ce-43de-9ba6-1d96ff504c57"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d1be2f64-73b2-4b88-9b32-040e2dfebe9e"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d3b7b4f6-0823-4581-b8c6-b93d478a3ed3"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e04da8a4-3a18-46f9-a950-deccc4f0386b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e10a927b-0001-4f92-84cc-2dedf2eee342"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e5be86b1-aaa4-4545-b409-eeeff69fe172"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ebeb808d-91ff-406f-8e7a-f182cdaadc37"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ecbfff9d-9c95-42b4-8959-cb725f06bd60"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f035a8e2-02e5-4bab-9714-65ad1ef4caf4"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f1ec37e2-64e5-4b1a-b7b2-4e05bb34d527"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f2e35bef-d96e-4cda-8842-bc1add69cd9b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f4683513-9073-4f9b-9646-2ee93b8bd61b"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("fd6d95f2-b1ec-4d77-90fb-b449457de870"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ff2118af-5ebf-4f7d-8721-281d65a3fd5a"), new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530") });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("03133477-bc82-4253-b6ee-e3dcc17c17de"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0bb07691-6e4b-4b10-ad68-73b09cd420a8"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0bbe23b3-1b2c-41a7-875d-0d5304da8e93"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("14dbaa31-f2ab-4ff7-9486-98041542123f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("19e83373-5e53-42da-8573-a3a4a00e191d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("1c5bcf3f-7447-440f-9f0c-71ce056840cb"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("20a4b9d6-3964-4e17-8c54-a50243b0116b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("23e6345e-fbf3-485d-9a37-da820724afaf"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("24ba5169-189f-45de-a3e2-c90a4a3f4264"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("27241ec1-961c-4e69-8f7f-2818d369adb2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2a93dbcb-71a3-41ca-ae34-db60ba9ea571"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2d2d5f33-30aa-416c-b172-e71a14a26902"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2f0d9b6b-6853-49b6-97e8-a30c22007a3a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2f7d2717-dac1-476b-be93-f3992eb708c0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("312ee54a-a740-47bb-b471-ddde967d8471"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("32812b77-a609-404b-b840-96750306f250"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3300814d-121c-4f6f-9f24-83a3893c81d7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("33e0fa42-2e1a-40f2-b54d-1e371336f3ff"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3a34c2f6-4571-4686-aa78-3ff4fad7d00b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3c0925fe-f3a2-48cb-96c3-93bc32a03257"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3c4add16-8280-4bc4-b890-1f39eaf5f965"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3dabfc3e-1d66-4290-ac33-a82cb17cb84b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3ea66729-49ab-4071-b0da-2b5c56f85ca6"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3fa22622-d6d1-4ba8-b0e2-dfe3d3a4245f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("443210a9-00a5-467d-b042-7244b244d246"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("464a63cf-a15f-4b78-bbcc-1731ab9b3155"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("4e300ea6-00d8-4a2a-affd-08028f7b51f8"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("4e40705f-abbd-4c29-8561-034557e39656"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("4e49281d-9a97-4fc9-a529-ca9aef376a65"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("51a80e6d-aea6-4893-b67b-31a525be5704"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("549a58ad-b5d3-4638-a819-f2f6e85ad2f9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5951ab56-be2a-4c39-a505-f346b87c93b1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("59a7f9ca-ac13-49e9-a183-33dacc43138d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5b75ca91-fe60-4efc-a956-1b2af7b2fbf5"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("64376786-d6ef-4fda-ada2-fb377ed1a51d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("68bcd55f-6684-45bc-bb3d-d88250dd4b7a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6d93d2dc-eb1f-4171-87d0-5995978376cd"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6e064c1c-361e-4fba-9653-0e68ad4708ef"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6eb0b6d1-d9dd-4e5d-9544-2f9d8d5ac1a0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6f398c4e-831f-44f5-82ae-f71b41d28ffc"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6fee0312-1e82-4974-8ce7-8ace0f895e98"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("70acc349-ee51-4c9b-8221-8b9128364c1b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("76bbb1ac-23f4-4453-9b5b-3972f3c53b06"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("825f0e7b-7cfb-4ee0-8bc9-708e4fbc63a4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("86971c95-96b0-49d0-926f-bcd00ab16897"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("8c878de8-16ab-4562-bf5d-060cc2777645"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("8dbf0c42-d6d5-4861-be9a-bc2dd2fb6a15"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("934633ae-5b57-42a6-9861-e008c9537cdb"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9580d1e4-ddaf-49a3-94b8-db7ea95ce40f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("99d1dbbc-d8c8-4c60-a608-945e3bf4f5ba"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a3eb921f-20b7-440d-b760-11717f1c40d0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("aef811d1-a4cb-495d-b4e2-eef96b65e2b4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b0e18418-3b4b-48ae-bdce-22a423cbc00a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b10b3724-9575-42a6-a034-a24593663736"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b183772c-ba9f-49b0-bf36-e2f114fbc26b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b4ae6205-2252-4447-831a-4f7e74636ef0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b5202660-c0fb-4033-a37f-2b4e784703ef"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("bf1d1d3a-44cf-47ca-9b02-46da9f3d75cb"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("bf88f66c-e064-41cc-abef-1708cab8eea4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c36bd6e1-c276-4961-9434-567988ef4cad"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("cb01490a-9aa6-4d0b-8803-5e1e49651a09"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d02684bb-701f-49f9-8527-c298a83ee326"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d1544a97-45ce-43de-9ba6-1d96ff504c57"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d1be2f64-73b2-4b88-9b32-040e2dfebe9e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d3b7b4f6-0823-4581-b8c6-b93d478a3ed3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e04da8a4-3a18-46f9-a950-deccc4f0386b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e10a927b-0001-4f92-84cc-2dedf2eee342"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e5be86b1-aaa4-4545-b409-eeeff69fe172"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ebeb808d-91ff-406f-8e7a-f182cdaadc37"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ecbfff9d-9c95-42b4-8959-cb725f06bd60"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f035a8e2-02e5-4bab-9714-65ad1ef4caf4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f1ec37e2-64e5-4b1a-b7b2-4e05bb34d527"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f2e35bef-d96e-4cda-8842-bc1add69cd9b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f4683513-9073-4f9b-9646-2ee93b8bd61b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("fd6d95f2-b1ec-4d77-90fb-b449457de870"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ff2118af-5ebf-4f7d-8721-281d65a3fd5a"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("226c103f-b1b8-477c-aabc-e3a7476c7034"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("58758b87-e98c-43c8-b2ac-4e18aab0e1ca"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("84ea5a60-408d-43c1-9c7a-93f3443fbeea"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("f3eb18b2-e286-4f21-ba64-726d966eedf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a36b5a-f61f-462b-a9bb-7f8ca9757530"));

            migrationBuilder.DropColumn(
                name: "IdAuth0",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "FoodGroups",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9594), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9594), "fruit" },
                    { new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9592), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9593), "vegetable" },
                    { new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9589), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9589), "carbohydrate" },
                    { new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9591), "protein" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Alias", "CreatedAt", "ModifiedAt" },
                values: new object[] { new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), "Admin#0000", new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9547), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "FoodGroupId", "FromInitialSeed", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("05e455d5-07c4-45ca-b8f9-7e4ec486432e"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9708), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9709), "broccoli" },
                    { new Guid("08b469b0-94cd-4a51-9009-88f09c1134c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9784), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9785), "orange" },
                    { new Guid("0d4f8fab-2760-40da-8c3f-26157405e9ed"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9797), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9797), "peach" },
                    { new Guid("106133e7-147e-4114-86e4-03cd469143a4"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9805), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9806), "apricot" },
                    { new Guid("12e4302d-c9cc-4be1-af8a-22b618d2fd26"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9795), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9795), "fig" },
                    { new Guid("154a3bba-27a3-43a1-97ee-2f0ae1ce720e"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9660), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9661), "brussels sprout" },
                    { new Guid("1983be0a-a325-467f-858b-0043ba91ce2a"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9809), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9810), "egg" },
                    { new Guid("253c1301-5a11-40b2-9bf9-2b2fda318158"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9842), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9842), "tempeh" },
                    { new Guid("2745603c-8621-4670-a8bc-d66fa794c007"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9663), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9663), "green cabbage" },
                    { new Guid("27f9401f-58ca-4ab4-be5f-811ccd010733"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9860), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9860), "minced turkey" },
                    { new Guid("2969dc1c-e08c-47a9-84b3-e2461f776d1c"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9778), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9779), "apple" },
                    { new Guid("2cc97f8b-4ebe-48c1-ae94-189c7670a74d"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9833), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9834), "seitan" },
                    { new Guid("307c11e8-fb5e-44c3-8477-01a368d7c2a6"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9647), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9648), "courgette" },
                    { new Guid("3345cec1-b8fd-4e34-ab4c-daaca02534c1"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9627), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9628), "sweet potato" },
                    { new Guid("353ebf63-4a76-4786-bb3f-05116d616410"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9807), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9808), "grape" },
                    { new Guid("363f1c8d-09c9-407e-9858-3c44268a16d2"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9803), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9803), "plum" },
                    { new Guid("36703682-0e47-4a00-b286-3c4d29520e40"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9638), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9639), "tortilla" },
                    { new Guid("36e201d7-f576-4c92-ad84-e4b6d060caf2"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9698), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9699), "jerusalem artichoke" },
                    { new Guid("383d1569-338a-45e5-991b-7c72afc9e2e2"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9677), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9677), "parsnip" },
                    { new Guid("3d5d0522-4fd9-4814-8632-6d9b490f7b7d"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9685), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9686), "beetroot" },
                    { new Guid("41fb98af-529c-4d13-8fee-58b6e3367176"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9610), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9610), "potato" },
                    { new Guid("42ef7c71-de0e-4700-8fe0-d39c3ba47a7e"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9652), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9652), "bell pepper" },
                    { new Guid("47a0dead-a61f-453f-afc1-1709883c9c42"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9682), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9682), "radish" },
                    { new Guid("489a5fcd-b6ac-4030-88ec-4d3a9a607970"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9696), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9696), "butternut squash" },
                    { new Guid("5013264a-0117-42e5-9b57-fddc3fa8c9a1"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9854), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9855), "salmon fillet" },
                    { new Guid("5142ce13-4f3f-45ff-9ada-ecc9adf95f53"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9791), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9791), "strawberry" },
                    { new Guid("522a7860-6362-49a0-b28f-27aaa2498126"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9848), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9848), "cashew nut" },
                    { new Guid("52402050-dd51-49bc-ac52-432c4a704087"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9666), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9667), "kale" },
                    { new Guid("530ea87c-62d0-49d4-a0b8-dcd04bd23e78"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9818), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9818), "mozzarella" },
                    { new Guid("57d754ca-8ed2-455b-b010-ec0fe9aa5f8a"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9604), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9604), "wholegrain pasta" },
                    { new Guid("668822b3-f9ee-4fdc-8122-62641746f29f"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9704), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9705), "spinach" },
                    { new Guid("69e76b8b-2202-4261-9dd2-e4c4d16b15df"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9694), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9694), "turnip" },
                    { new Guid("6d345e8a-cc7b-4afb-ba6e-648b167edd84"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9856), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9857), "rump steak" },
                    { new Guid("6d44738f-cd18-45e7-af35-35877dd766a2"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9673), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9673), "cauliflower" },
                    { new Guid("714e1df8-8be8-4017-9786-d0f8d69d2057"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9824), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9824), "edam cheese" },
                    { new Guid("747ac374-9c71-4d97-8b4b-8759e6898f38"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9634), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9634), "corn" },
                    { new Guid("7cdc30fc-6596-425e-a1a3-f4edda9bccb7"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9607), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9608), "wholegrain rice" },
                    { new Guid("7db5ad0a-854c-47d9-ac2b-d4befb959d54"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9711), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9711), "pea" },
                    { new Guid("81a682c6-a98b-473d-a780-ffbe06d61fd6"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9836), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9836), "falafel" },
                    { new Guid("820b5ad4-b6fc-497c-ad2a-b986f635524d"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9706), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9707), "chard" },
                    { new Guid("837a783a-e2eb-4920-aba0-7b5ce8a1763b"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9658), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9659), "endive" },
                    { new Guid("84502f61-4123-4c6a-8a15-474f63565f40"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9671), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9671), "red cabbage" },
                    { new Guid("8485ca52-09e1-488a-bb37-cf3649b167b2"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9781), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9781), "banana" },
                    { new Guid("885c4a5d-8614-40a9-a523-3b674618fec9"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9713), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9713), "eggplant" },
                    { new Guid("8fa1a971-5d68-48cb-b769-f2b1bf468e33"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9786), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9787), "mandarin orange" },
                    { new Guid("94ce74a8-bb5a-4970-8132-05bbc51dfbf7"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9687), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9688), "celeriac" },
                    { new Guid("9cce5e81-f571-4c28-ae3e-4e5995fdd7e0"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9822), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9822), "gouda cheese" },
                    { new Guid("9fe94dca-9fb1-40e5-ad03-626bddc475c1"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9679), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9680), "leek" },
                    { new Guid("a6254d59-593e-4f5b-8f51-bb5d9f6f3a79"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9675), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9675), "chinese cabbage" },
                    { new Guid("a6fd581a-6e07-44a1-91b2-28adb3d4e726"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9793), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9793), "raspberry" },
                    { new Guid("a7592bfc-50fb-4a8a-bbc7-0167479de524"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9654), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9654), "button mushroom" },
                    { new Guid("a7808601-1916-4a7f-a949-41f580f3da79"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9829), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9830), "tofu" },
                    { new Guid("aa47704c-d294-4535-a9a6-5a0706f516bd"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9641), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9641), "tomato" },
                    { new Guid("abc68a40-3781-4878-93d8-70933452cb29"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9844), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9844), "black bean" },
                    { new Guid("aca9fbdd-0d4e-4683-b5a2-de2c1c619f5f"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9838), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9838), "quorn" },
                    { new Guid("aeae96ba-5591-43e6-927d-e187d2064929"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9831), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9832), "soya protein" },
                    { new Guid("b1834d96-049d-4615-9753-6f01dd3eeb52"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9789), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9789), "pear" },
                    { new Guid("b22ad4a7-40e1-433b-a7d2-2fa8b8c926d2"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9812), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9812), "greek yoghurt" },
                    { new Guid("ba7434b4-3c14-40ea-8631-2895254ad01b"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9799), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("2f0c65fb-aedf-4b3a-a587-a04cb7595550"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9800), "melon" },
                    { new Guid("bd2dd871-4302-4fc8-9325-071dbd9171a3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9852), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9852), "pork tenderloin" },
                    { new Guid("c3238af2-ae27-4f74-9b86-b069ec30dc08"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9814), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9814), "cottage cheese" },
                    { new Guid("c7db65a1-6d7f-4c5f-8885-614416539a4b"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9668), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9669), "white cabbage" },
                    { new Guid("cc68ca7e-30b1-41e7-8020-48a04705d25d"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9692), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9692), "white celery" },
                    { new Guid("d2d38880-e1e9-40fe-9c9f-56f1b3607e22"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9850), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9850), "chicken breast" },
                    { new Guid("d45d1760-24a6-4cd7-a47e-e3eb0df7f3bb"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9816), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9816), "pecorino" },
                    { new Guid("d66355d6-a59e-45ed-b7ed-28eceaf6c300"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9827), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9827), "gruyere cheese" },
                    { new Guid("d672c5cd-5bcd-4efe-8a79-d99481d68eb0"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9650), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9650), "carrot" },
                    { new Guid("dbc0f7a5-e60f-4835-88a2-ca08f943fe27"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9643), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9643), "onion" },
                    { new Guid("df96ffe2-5c90-4aba-b0df-910050b9a54f"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9846), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("a5679c60-1649-4419-91e5-171fcdcc0c1b"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9846), "chickpea" },
                    { new Guid("dfaf423b-72b4-4f14-841a-a0b70a0b4164"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9776), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9776), "cucumber" },
                    { new Guid("e03d1cf5-2dfe-4beb-bbe9-3591aeeacd20"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9656), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9656), "oyster mushroom" },
                    { new Guid("e4ef6482-4011-495e-bcd9-62077f232468"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9690), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9690), "celery stalk" },
                    { new Guid("e91d1782-4a29-4a02-97b4-4b1fae8168b6"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9632), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9632), "quinoa" },
                    { new Guid("f2e29b33-689f-402b-a57f-fc3b5d85d755"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9700), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("707a1b64-5400-45d6-885b-08b7dbbfca63"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9701), "asparagus" },
                    { new Guid("f8b668d9-d4cc-471e-946c-4ca09df73055"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9636), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9636), "pita bread" },
                    { new Guid("ff815635-ddca-4c92-9f1e-943445d445af"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9630), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), null, new Guid("86f54c23-73d2-4a04-af70-e8f7eb660dd4"), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9630), "lentil" }
                });

            migrationBuilder.InsertData(
                table: "UserFoods",
                columns: new[] { "FoodId", "UserId", "CreatedAt", "IsCurrentDiet", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("05e455d5-07c4-45ca-b8f9-7e4ec486432e"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9944), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9944) },
                    { new Guid("08b469b0-94cd-4a51-9009-88f09c1134c3"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9949), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9949) },
                    { new Guid("0d4f8fab-2760-40da-8c3f-26157405e9ed"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9954), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9954) },
                    { new Guid("106133e7-147e-4114-86e4-03cd469143a4"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9956), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9956) },
                    { new Guid("12e4302d-c9cc-4be1-af8a-22b618d2fd26"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9953), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9953) },
                    { new Guid("154a3bba-27a3-43a1-97ee-2f0ae1ce720e"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9885), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("1983be0a-a325-467f-858b-0043ba91ce2a"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9958), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9958) },
                    { new Guid("253c1301-5a11-40b2-9bf9-2b2fda318158"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9970), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9970) },
                    { new Guid("2745603c-8621-4670-a8bc-d66fa794c007"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9886), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9886) },
                    { new Guid("27f9401f-58ca-4ab4-be5f-811ccd010733"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9976), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9977) },
                    { new Guid("2969dc1c-e08c-47a9-84b3-e2461f776d1c"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9947), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9947) },
                    { new Guid("2cc97f8b-4ebe-48c1-ae94-189c7670a74d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9966), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9966) },
                    { new Guid("307c11e8-fb5e-44c3-8477-01a368d7c2a6"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9879), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9879) },
                    { new Guid("3345cec1-b8fd-4e34-ab4c-daaca02534c1"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9870), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9870) },
                    { new Guid("353ebf63-4a76-4786-bb3f-05116d616410"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9957), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9957) },
                    { new Guid("363f1c8d-09c9-407e-9858-3c44268a16d2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9955), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9956) },
                    { new Guid("36703682-0e47-4a00-b286-3c4d29520e40"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9876), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9876) },
                    { new Guid("36e201d7-f576-4c92-ad84-e4b6d060caf2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9940), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9941) },
                    { new Guid("383d1569-338a-45e5-991b-7c72afc9e2e2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9932), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9932) },
                    { new Guid("3d5d0522-4fd9-4814-8632-6d9b490f7b7d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9934), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9935) },
                    { new Guid("41fb98af-529c-4d13-8fee-58b6e3367176"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9869), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9869) },
                    { new Guid("42ef7c71-de0e-4700-8fe0-d39c3ba47a7e"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9881), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9881) },
                    { new Guid("47a0dead-a61f-453f-afc1-1709883c9c42"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9933), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9934) },
                    { new Guid("489a5fcd-b6ac-4030-88ec-4d3a9a607970"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9938), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9939) },
                    { new Guid("5013264a-0117-42e5-9b57-fddc3fa8c9a1"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9975), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9975) },
                    { new Guid("5142ce13-4f3f-45ff-9ada-ecc9adf95f53"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9951), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9951) },
                    { new Guid("522a7860-6362-49a0-b28f-27aaa2498126"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9972), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9972) },
                    { new Guid("52402050-dd51-49bc-ac52-432c4a704087"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9886), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9887) },
                    { new Guid("530ea87c-62d0-49d4-a0b8-dcd04bd23e78"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9961), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9961) },
                    { new Guid("57d754ca-8ed2-455b-b010-ec0fe9aa5f8a"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9865), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9865) },
                    { new Guid("668822b3-f9ee-4fdc-8122-62641746f29f"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9942), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9942) },
                    { new Guid("69e76b8b-2202-4261-9dd2-e4c4d16b15df"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9938), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9938) },
                    { new Guid("6d345e8a-cc7b-4afb-ba6e-648b167edd84"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9975), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9976) },
                    { new Guid("6d44738f-cd18-45e7-af35-35877dd766a2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9930), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9930) },
                    { new Guid("714e1df8-8be8-4017-9786-d0f8d69d2057"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9963), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9963) },
                    { new Guid("747ac374-9c71-4d97-8b4b-8759e6898f38"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9874), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9874) },
                    { new Guid("7cdc30fc-6596-425e-a1a3-f4edda9bccb7"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9868), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9868) },
                    { new Guid("7db5ad0a-854c-47d9-ac2b-d4befb959d54"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9944), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9945) },
                    { new Guid("81a682c6-a98b-473d-a780-ffbe06d61fd6"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9968), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9968) },
                    { new Guid("820b5ad4-b6fc-497c-ad2a-b986f635524d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9943), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9943) },
                    { new Guid("837a783a-e2eb-4920-aba0-7b5ce8a1763b"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9883), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9883) },
                    { new Guid("84502f61-4123-4c6a-8a15-474f63565f40"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9929), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9929) },
                    { new Guid("8485ca52-09e1-488a-bb37-cf3649b167b2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9948), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9948) },
                    { new Guid("885c4a5d-8614-40a9-a523-3b674618fec9"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9945), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9946) },
                    { new Guid("8fa1a971-5d68-48cb-b769-f2b1bf468e33"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9949), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9950) },
                    { new Guid("94ce74a8-bb5a-4970-8132-05bbc51dfbf7"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9935), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9935) },
                    { new Guid("9cce5e81-f571-4c28-ae3e-4e5995fdd7e0"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9962), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9962) },
                    { new Guid("9fe94dca-9fb1-40e5-ad03-626bddc475c1"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9933), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9933) },
                    { new Guid("a6254d59-593e-4f5b-8f51-bb5d9f6f3a79"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9931), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9931) },
                    { new Guid("a6fd581a-6e07-44a1-91b2-28adb3d4e726"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9952), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9952) },
                    { new Guid("a7592bfc-50fb-4a8a-bbc7-0167479de524"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9881), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9882) },
                    { new Guid("a7808601-1916-4a7f-a949-41f580f3da79"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9964), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9965) },
                    { new Guid("aa47704c-d294-4535-a9a6-5a0706f516bd"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9877), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9878) },
                    { new Guid("abc68a40-3781-4878-93d8-70933452cb29"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9970), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9971) },
                    { new Guid("aca9fbdd-0d4e-4683-b5a2-de2c1c619f5f"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9969), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9969) },
                    { new Guid("aeae96ba-5591-43e6-927d-e187d2064929"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9965), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9966) },
                    { new Guid("b1834d96-049d-4615-9753-6f01dd3eeb52"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9950), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9951) },
                    { new Guid("b22ad4a7-40e1-433b-a7d2-2fa8b8c926d2"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9959), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9959) },
                    { new Guid("ba7434b4-3c14-40ea-8631-2895254ad01b"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9954), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9955) },
                    { new Guid("bd2dd871-4302-4fc8-9325-071dbd9171a3"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9974), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9974) },
                    { new Guid("c3238af2-ae27-4f74-9b86-b069ec30dc08"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9959), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9960) },
                    { new Guid("c7db65a1-6d7f-4c5f-8885-614416539a4b"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9887), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9888) },
                    { new Guid("cc68ca7e-30b1-41e7-8020-48a04705d25d"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9937), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9937) },
                    { new Guid("d2d38880-e1e9-40fe-9c9f-56f1b3607e22"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9973), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9973) },
                    { new Guid("d45d1760-24a6-4cd7-a47e-e3eb0df7f3bb"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9960), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9961) },
                    { new Guid("d66355d6-a59e-45ed-b7ed-28eceaf6c300"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9964), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9964) },
                    { new Guid("d672c5cd-5bcd-4efe-8a79-d99481d68eb0"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9880), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9880) },
                    { new Guid("dbc0f7a5-e60f-4835-88a2-ca08f943fe27"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9878), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9878) },
                    { new Guid("df96ffe2-5c90-4aba-b0df-910050b9a54f"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9971), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9972) },
                    { new Guid("dfaf423b-72b4-4f14-841a-a0b70a0b4164"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9946), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9946) },
                    { new Guid("e03d1cf5-2dfe-4beb-bbe9-3591aeeacd20"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9882), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9882) },
                    { new Guid("e4ef6482-4011-495e-bcd9-62077f232468"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9936), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9936) },
                    { new Guid("e91d1782-4a29-4a02-97b4-4b1fae8168b6"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9873), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9873) },
                    { new Guid("f2e29b33-689f-402b-a57f-fc3b5d85d755"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9941), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9941) },
                    { new Guid("f8b668d9-d4cc-471e-946c-4ca09df73055"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9875), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9875) },
                    { new Guid("ff815635-ddca-4c92-9f1e-943445d445af"), new Guid("cb58e540-0349-48ac-aa61-130f28a6d9c3"), new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9870), true, new DateTime(2024, 11, 18, 8, 7, 59, 794, DateTimeKind.Utc).AddTicks(9871) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Alias",
                table: "Users",
                column: "Alias",
                unique: true);
        }
    }
}
