using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdeasForMeals.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
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
                    { new Guid("85fceaf1-a50b-4a7f-a3b1-715eda1e58cb"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3943), null, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3943), "carbohydrate" },
                    { new Guid("a6c69613-7937-45de-88a2-64f7e6fa280a"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3962), null, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3962), "vegetable" },
                    { new Guid("a7bc694d-efd4-497d-a675-a608bdcc0c37"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3964), null, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3964), "fruit" },
                    { new Guid("affaf49a-c470-4c9f-9ec3-425789454dc6"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3945), null, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3945), "protein" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Alias", "CreatedAt", "ModifiedAt" },
                values: new object[] { new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), "Admin#0000", new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3906), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "FoodGroupId", "FromInitialSeed", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("25e91772-a804-4777-8796-25be7866706d"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3991), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("a6c69613-7937-45de-88a2-64f7e6fa280a"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3992), "tomato" },
                    { new Guid("5beaed40-dd43-4557-bcc6-b8bd41aba4bb"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4001), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("a6c69613-7937-45de-88a2-64f7e6fa280a"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4001), "carrot" },
                    { new Guid("75c26c32-2136-4f65-9ead-21a5f9ce7222"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4007), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("affaf49a-c470-4c9f-9ec3-425789454dc6"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4008), "parmesan cheese" },
                    { new Guid("b134f778-a221-4778-b5d2-13a2619eb4a3"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3994), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("85fceaf1-a50b-4a7f-a3b1-715eda1e58cb"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3995), "pasta" },
                    { new Guid("b61c22c3-934f-435e-afed-821384f98228"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3996), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("a6c69613-7937-45de-88a2-64f7e6fa280a"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3997), "onion" },
                    { new Guid("c2e81b21-73fa-4cbc-8d21-95f8b2c6d29d"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3999), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("a6c69613-7937-45de-88a2-64f7e6fa280a"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(3999), "courgette" },
                    { new Guid("ed537fc9-9810-42b1-bb75-7c5c6b14da0b"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4003), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), null, new Guid("a6c69613-7937-45de-88a2-64f7e6fa280a"), true, new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4003), "red pepper" }
                });

            migrationBuilder.InsertData(
                table: "UserFoods",
                columns: new[] { "FoodId", "UserId", "CreatedAt", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("25e91772-a804-4777-8796-25be7866706d"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4012), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4012) },
                    { new Guid("5beaed40-dd43-4557-bcc6-b8bd41aba4bb"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4017), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4017) },
                    { new Guid("75c26c32-2136-4f65-9ead-21a5f9ce7222"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4021), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4021) },
                    { new Guid("b134f778-a221-4778-b5d2-13a2619eb4a3"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4014), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4014) },
                    { new Guid("b61c22c3-934f-435e-afed-821384f98228"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4015), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4015) },
                    { new Guid("c2e81b21-73fa-4cbc-8d21-95f8b2c6d29d"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4016), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4016) },
                    { new Guid("ed537fc9-9810-42b1-bb75-7c5c6b14da0b"), new Guid("8d81cace-eab8-4c04-b294-d62be4666777"), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4020), new DateTime(2024, 11, 9, 4, 56, 12, 679, DateTimeKind.Utc).AddTicks(4020) }
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
