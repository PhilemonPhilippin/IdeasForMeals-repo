using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdeasForMeals.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitMigrationWithCompleteSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Alias = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    FromInitialSeed = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    FoodGroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_FoodGroups_FoodGroupId",
                        column: x => x.FoodGroupId,
                        principalTable: "FoodGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserFoods",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsCurrentDiet = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoods", x => new { x.UserId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_UserFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodGroups",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6829), null, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6829), "carbohydrate" },
                    { new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6831), null, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6831), "protein" },
                    { new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6850), null, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6851), "fruit" },
                    { new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6833), null, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6833), "vegetable" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Alias", "CreatedAt", "ModifiedAt" },
                values: new object[] { new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), "Admin#0000", new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "FoodGroupId", "FromInitialSeed", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("0446f521-e59c-4694-ac8a-6e9b70fa82e7"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6861), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6862), "wholegrain pasta" },
                    { new Guid("0750766b-2a92-42c4-8d39-69410513f166"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6995), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6995), "pear" },
                    { new Guid("0b07d986-678f-4eb5-846f-d8c71dc6b0dd"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6982), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6983), "eggplant" },
                    { new Guid("0e28a431-e088-46ed-b810-c9e763b46fe9"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7032), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7032), "gruyere cheese" },
                    { new Guid("0f679875-5608-43bd-a908-4ed8cd80a5c9"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6881), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6881), "pita bread" },
                    { new Guid("157f6732-4a4d-4e31-946e-b1fd95382a79"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6896), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6896), "button mushroom" },
                    { new Guid("17ad9cbd-1c03-4de9-ba14-a367af51b5bf"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7019), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7019), "greek yoghurt" },
                    { new Guid("1a17722f-4180-44f5-be7e-5ad7d9451fe1"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7003), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7003), "fig" },
                    { new Guid("1e34e46d-caa6-495b-abd9-2b5c72578091"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7037), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7038), "soya protein" },
                    { new Guid("1fd37e19-1936-4978-b6ca-6e17ebdda47d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6906), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6906), "green cabbage" },
                    { new Guid("262c4240-b98a-4253-bdf0-1109efde8501"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7044), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7044), "quorn" },
                    { new Guid("28845160-e773-4566-942b-ac523e85bc35"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7052), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7052), "cashew nut" },
                    { new Guid("2fe4b290-eb7e-470a-9a96-d14735d5b120"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6869), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6869), "sweet potato" },
                    { new Guid("33414530-b6e9-4ac1-b8de-afa2413f9925"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6873), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6873), "quinoa" },
                    { new Guid("336b60c7-8ac8-4d69-bb56-bb6395d6eab4"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7062), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7062), "rump steak" },
                    { new Guid("3d774d76-77f5-40c1-b50e-7987549fbc52"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6915), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6915), "cauliflower" },
                    { new Guid("445ad34f-03b9-4e3d-ac1c-9312e8bd7701"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6979), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6979), "pea" },
                    { new Guid("46104e6f-6b1e-4f14-a5b9-2a95fb3df358"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6902), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6902), "endive" },
                    { new Guid("491029c3-c8fc-46d1-98f8-2d028fa941f8"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6908), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6909), "kale" },
                    { new Guid("4c3e8350-e084-4251-b3fd-8498333d01e7"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7056), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7056), "chicken breast" },
                    { new Guid("4e60e875-cbe4-488c-9045-8a3a80d397ee"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6883), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6883), "tortilla" },
                    { new Guid("54c5645c-70d5-4e55-a700-1a1f3faef5ef"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6925), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6925), "radish" },
                    { new Guid("5e601378-64bd-4d33-9a24-2e1f3615523c"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6912), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6913), "red cabbage" },
                    { new Guid("6277fc0d-6a38-4b9c-b3bf-176ad12bc25d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6892), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6892), "carrot" },
                    { new Guid("631972dc-6239-4135-99ec-e26d2f2ebefc"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7040), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7040), "seitan" },
                    { new Guid("63bc7048-7d11-4710-a511-93a48e231912"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7060), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7060), "salmon fillet" },
                    { new Guid("655c3e3a-1f7d-4019-89d5-f12f4b90addf"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7064), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7064), "minced turkey" },
                    { new Guid("6b0d308c-671e-42a6-94a4-93a69893c0c7"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7034), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7034), "tofu" },
                    { new Guid("6b4b2f82-be6b-4efe-9352-6fb5765e57b4"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6987), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6987), "apple" },
                    { new Guid("77f79b66-de25-4a46-a8e5-2639076a3ee1"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6885), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6885), "tomato" },
                    { new Guid("79f9889b-6a72-46e2-9c15-62379a789c8d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6918), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6919), "chinese cabbage" },
                    { new Guid("814fdba7-ab82-4f0f-920e-1eb422dd430e"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6972), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6973), "spinach" },
                    { new Guid("84343925-d449-4034-b854-2f565ef0aa4a"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7027), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7028), "gouda cheese" },
                    { new Guid("8e0fc739-5152-45e1-92fd-086d4ca6f096"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6960), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6960), "white celery" },
                    { new Guid("8ffd58d9-2685-4503-a8d4-3aa1924a9556"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6991), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6991), "orange" },
                    { new Guid("94077705-2c15-43e7-8af0-37c4551f4cff"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6900), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6900), "oyster mushroom" },
                    { new Guid("95d9c79b-5915-493c-b29a-b22351b06f93"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7042), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7042), "falafel" },
                    { new Guid("96eada5c-d279-40d7-943e-d87a6c0ddb39"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6871), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6871), "lentil" },
                    { new Guid("9c4a3917-e0c8-46f4-a464-df761b58ea2c"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7015), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7016), "egg" },
                    { new Guid("9d53c45f-3869-470b-9f5b-e40f6bb39cb1"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6966), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6967), "butternut squash" },
                    { new Guid("9e4f8fcf-881a-4a0a-b903-8b542e6f74f1"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6929), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6929), "celeriac" },
                    { new Guid("a0c54704-713a-4823-b2ee-8547ec6efcb9"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7050), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7050), "chickpea" },
                    { new Guid("a2f83ae5-c295-4d7c-b8fe-67b64475725d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6997), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6997), "strawberry" },
                    { new Guid("a76ba9d2-d03f-485e-bf88-697ad1d9b7e8"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7029), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7030), "edam cheese" },
                    { new Guid("a78fa7d0-6a91-4062-994d-5b698045c8e6"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6985), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6985), "cucumber" },
                    { new Guid("a924924f-f128-4bfb-b452-d33f61208acd"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6920), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6921), "parsnip" },
                    { new Guid("a935ca2c-c2cc-44fd-9c86-d546ec8430ce"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6910), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6911), "white cabbage" },
                    { new Guid("ab342674-e625-4742-89ee-fb8a9cc8970d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6968), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6969), "jerusalem artichoke" },
                    { new Guid("b342d3ff-63bc-4a9f-887e-114fa2802291"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6894), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6894), "bell pepper" },
                    { new Guid("ba3ab3e3-9179-430e-9ec7-c7f0837f6d7d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7011), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7011), "apricot" },
                    { new Guid("baf94ae2-b334-443c-af4c-380a91761452"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6975), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6975), "chard" },
                    { new Guid("c00cc576-3f34-4083-9309-67db327f28c2"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6964), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6964), "turnip" },
                    { new Guid("c09d0d15-cfaa-4818-8a58-7f4464085ffc"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6989), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6989), "banana" },
                    { new Guid("c1b0f00f-ec0b-44bb-b06d-6e51e0a35250"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7046), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7046), "tempeh" },
                    { new Guid("c397c006-1451-4969-ad7c-dc6a36abfa43"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7058), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7058), "pork tenderloin" },
                    { new Guid("c3e404e5-db82-4f53-8066-19ab0822c7a7"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7048), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7048), "black bean" },
                    { new Guid("c8a2b7e9-fe0d-4b51-9d9c-f30daeaa942e"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6931), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6931), "celery stalk" },
                    { new Guid("c95038c1-f806-4310-847e-52386f9aec71"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6864), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6865), "wholegrain rice" },
                    { new Guid("cd23d16c-8af0-421e-b983-bbebacc9492e"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7013), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7013), "grape" },
                    { new Guid("d52327ac-0aab-459a-8d86-f6f28040346a"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7005), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7005), "peach" },
                    { new Guid("d65f4ba8-ac54-4cd1-ae78-911a80868dda"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7001), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7001), "raspberry" },
                    { new Guid("d70cc302-5724-4ad1-a04c-869bd80ac38c"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6875), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6875), "corn" },
                    { new Guid("dc568e6e-1ad2-4dd4-8514-6e38b78bc1ef"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7025), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7025), "mozzarella" },
                    { new Guid("df3c19bc-72eb-48d8-9918-146675620d84"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7023), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7023), "pecorino" },
                    { new Guid("e0d44271-2938-4fc6-8b83-23be75faa16f"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6889), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6890), "courgette" },
                    { new Guid("e155f34d-0df0-4144-8b29-d41bf55dc48d"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6977), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6977), "broccoli" },
                    { new Guid("e48b5734-7023-4403-81fa-14b4d340a8c2"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6927), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6927), "beetroot" },
                    { new Guid("e7ecf1e9-ed2f-426f-a31e-e3dad50dab96"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6904), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6904), "brussels sprout" },
                    { new Guid("e8909dbd-8557-4379-b572-1a62ee8e1870"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6970), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6971), "asparagus" },
                    { new Guid("ea3b1b74-d8ce-44fd-84db-40537da29d1a"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6993), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6993), "mandarin orange" },
                    { new Guid("ebce410f-3857-43ab-afa0-02aea28168bb"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6887), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6888), "onion" },
                    { new Guid("ef504c23-e8bf-4ce2-8217-026e1db34791"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7021), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7021), "cottage cheese" },
                    { new Guid("f0eb272c-826d-48c5-b10f-4cfda735f943"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7009), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7009), "plum" },
                    { new Guid("f81631ac-6b3b-4572-a14b-20b42dfb77fd"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6867), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6867), "potato" },
                    { new Guid("fcb4424d-7e8e-4175-8009-b3bf1e25987e"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6922), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(6923), "leek" },
                    { new Guid("fd40c7dc-15b2-41ff-a2a4-61055621a522"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7007), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), null, new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"), true, new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7007), "melon" }
                });

            migrationBuilder.InsertData(
                table: "UserFoods",
                columns: new[] { "FoodId", "UserId", "CreatedAt", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("0446f521-e59c-4694-ac8a-6e9b70fa82e7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7068) },
                    { new Guid("0750766b-2a92-42c4-8d39-69410513f166"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7132), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7132) },
                    { new Guid("0b07d986-678f-4eb5-846f-d8c71dc6b0dd"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7128) },
                    { new Guid("0e28a431-e088-46ed-b810-c9e763b46fe9"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7145), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7145) },
                    { new Guid("0f679875-5608-43bd-a908-4ed8cd80a5c9"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7098), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7099) },
                    { new Guid("157f6732-4a4d-4e31-946e-b1fd95382a79"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7106) },
                    { new Guid("17ad9cbd-1c03-4de9-ba14-a367af51b5bf"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7140), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7141) },
                    { new Guid("1a17722f-4180-44f5-be7e-5ad7d9451fe1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7135) },
                    { new Guid("1e34e46d-caa6-495b-abd9-2b5c72578091"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7147), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7147) },
                    { new Guid("1fd37e19-1936-4978-b6ca-6e17ebdda47d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7110), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7110) },
                    { new Guid("262c4240-b98a-4253-bdf0-1109efde8501"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7150) },
                    { new Guid("28845160-e773-4566-942b-ac523e85bc35"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7153), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7154) },
                    { new Guid("2fe4b290-eb7e-470a-9a96-d14735d5b120"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7073) },
                    { new Guid("33414530-b6e9-4ac1-b8de-afa2413f9925"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7078), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7078) },
                    { new Guid("336b60c7-8ac8-4d69-bb56-bb6395d6eab4"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7156), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7157) },
                    { new Guid("3d774d76-77f5-40c1-b50e-7987549fbc52"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7113), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7113) },
                    { new Guid("445ad34f-03b9-4e3d-ac1c-9312e8bd7701"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7127) },
                    { new Guid("46104e6f-6b1e-4f14-a5b9-2a95fb3df358"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7107), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7107) },
                    { new Guid("491029c3-c8fc-46d1-98f8-2d028fa941f8"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7111), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7111) },
                    { new Guid("4c3e8350-e084-4251-b3fd-8498333d01e7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7154), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7154) },
                    { new Guid("4e60e875-cbe4-488c-9045-8a3a80d397ee"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7099), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7100) },
                    { new Guid("54c5645c-70d5-4e55-a700-1a1f3faef5ef"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7116), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7116) },
                    { new Guid("5e601378-64bd-4d33-9a24-2e1f3615523c"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7112), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7112) },
                    { new Guid("6277fc0d-6a38-4b9c-b3bf-176ad12bc25d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7104), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7104) },
                    { new Guid("631972dc-6239-4135-99ec-e26d2f2ebefc"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7147), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7148) },
                    { new Guid("63bc7048-7d11-4710-a511-93a48e231912"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7156), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7156) },
                    { new Guid("655c3e3a-1f7d-4019-89d5-f12f4b90addf"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7157), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7158) },
                    { new Guid("6b0d308c-671e-42a6-94a4-93a69893c0c7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7146), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7146) },
                    { new Guid("6b4b2f82-be6b-4efe-9352-6fb5765e57b4"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7129) },
                    { new Guid("77f79b66-de25-4a46-a8e5-2639076a3ee1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7101), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7102) },
                    { new Guid("79f9889b-6a72-46e2-9c15-62379a789c8d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7114), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7114) },
                    { new Guid("814fdba7-ab82-4f0f-920e-1eb422dd430e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7124), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7124) },
                    { new Guid("84343925-d449-4034-b854-2f565ef0aa4a"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7144) },
                    { new Guid("8e0fc739-5152-45e1-92fd-086d4ca6f096"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7119), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7120) },
                    { new Guid("8ffd58d9-2685-4503-a8d4-3aa1924a9556"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7131), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7131) },
                    { new Guid("94077705-2c15-43e7-8af0-37c4551f4cff"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7107) },
                    { new Guid("95d9c79b-5915-493c-b29a-b22351b06f93"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7150) },
                    { new Guid("96eada5c-d279-40d7-943e-d87a6c0ddb39"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7074) },
                    { new Guid("9c4a3917-e0c8-46f4-a464-df761b58ea2c"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7139), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7140) },
                    { new Guid("9d53c45f-3869-470b-9f5b-e40f6bb39cb1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7121), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7121) },
                    { new Guid("9e4f8fcf-881a-4a0a-b903-8b542e6f74f1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7118), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7118) },
                    { new Guid("a0c54704-713a-4823-b2ee-8547ec6efcb9"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7153) },
                    { new Guid("a2f83ae5-c295-4d7c-b8fe-67b64475725d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7133) },
                    { new Guid("a76ba9d2-d03f-485e-bf88-697ad1d9b7e8"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7144), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7145) },
                    { new Guid("a78fa7d0-6a91-4062-994d-5b698045c8e6"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7128), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7128) },
                    { new Guid("a924924f-f128-4bfb-b452-d33f61208acd"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7114), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7115) },
                    { new Guid("a935ca2c-c2cc-44fd-9c86-d546ec8430ce"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7111), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7112) },
                    { new Guid("ab342674-e625-4742-89ee-fb8a9cc8970d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7123), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7123) },
                    { new Guid("b342d3ff-63bc-4a9f-887e-114fa2802291"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7105), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7105) },
                    { new Guid("ba3ab3e3-9179-430e-9ec7-c7f0837f6d7d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7138), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7138) },
                    { new Guid("baf94ae2-b334-443c-af4c-380a91761452"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7125), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7125) },
                    { new Guid("c00cc576-3f34-4083-9309-67db327f28c2"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7120), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7120) },
                    { new Guid("c09d0d15-cfaa-4818-8a58-7f4464085ffc"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7130) },
                    { new Guid("c1b0f00f-ec0b-44bb-b06d-6e51e0a35250"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7151), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7151) },
                    { new Guid("c397c006-1451-4969-ad7c-dc6a36abfa43"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7155), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7155) },
                    { new Guid("c3e404e5-db82-4f53-8066-19ab0822c7a7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7152) },
                    { new Guid("c8a2b7e9-fe0d-4b51-9d9c-f30daeaa942e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7118), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7119) },
                    { new Guid("c95038c1-f806-4310-847e-52386f9aec71"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7071), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7071) },
                    { new Guid("cd23d16c-8af0-421e-b983-bbebacc9492e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7139), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7139) },
                    { new Guid("d52327ac-0aab-459a-8d86-f6f28040346a"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7136) },
                    { new Guid("d65f4ba8-ac54-4cd1-ae78-911a80868dda"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7134) },
                    { new Guid("d70cc302-5724-4ad1-a04c-869bd80ac38c"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7079) },
                    { new Guid("dc568e6e-1ad2-4dd4-8514-6e38b78bc1ef"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7143) },
                    { new Guid("df3c19bc-72eb-48d8-9918-146675620d84"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7142), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7142) },
                    { new Guid("e0d44271-2938-4fc6-8b83-23be75faa16f"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7103), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7103) },
                    { new Guid("e155f34d-0df0-4144-8b29-d41bf55dc48d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7126), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7126) },
                    { new Guid("e48b5734-7023-4403-81fa-14b4d340a8c2"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7117), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7117) },
                    { new Guid("e7ecf1e9-ed2f-426f-a31e-e3dad50dab96"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7109), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7109) },
                    { new Guid("e8909dbd-8557-4379-b572-1a62ee8e1870"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7123), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7124) },
                    { new Guid("ea3b1b74-d8ce-44fd-84db-40537da29d1a"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7131), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7132) },
                    { new Guid("ebce410f-3857-43ab-afa0-02aea28168bb"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7102), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7102) },
                    { new Guid("ef504c23-e8bf-4ce2-8217-026e1db34791"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7141), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7141) },
                    { new Guid("f0eb272c-826d-48c5-b10f-4cfda735f943"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7137), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7137) },
                    { new Guid("f81631ac-6b3b-4572-a14b-20b42dfb77fd"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7072), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7072) },
                    { new Guid("fcb4424d-7e8e-4175-8009-b3bf1e25987e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7115), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7116) },
                    { new Guid("fd40c7dc-15b2-41ff-a2a4-61055621a522"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7136), new DateTime(2024, 11, 11, 10, 41, 57, 102, DateTimeKind.Utc).AddTicks(7137) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CreatedBy",
                table: "Foods",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodGroupId",
                table: "Foods",
                column: "FoodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Name",
                table: "Foods",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_FoodId",
                table: "UserFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Alias",
                table: "Users",
                column: "Alias",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "FoodGroups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
