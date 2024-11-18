using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdeasForMeals.Core.Migrations
{
    /// <inheritdoc />
    public partial class DefaultIsTrueForIsCurrentDietAndFoodGroupDescriptionRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0446f521-e59c-4694-ac8a-6e9b70fa82e7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0750766b-2a92-42c4-8d39-69410513f166"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0b07d986-678f-4eb5-846f-d8c71dc6b0dd"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0e28a431-e088-46ed-b810-c9e763b46fe9"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("0f679875-5608-43bd-a908-4ed8cd80a5c9"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("157f6732-4a4d-4e31-946e-b1fd95382a79"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("17ad9cbd-1c03-4de9-ba14-a367af51b5bf"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("1a17722f-4180-44f5-be7e-5ad7d9451fe1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("1e34e46d-caa6-495b-abd9-2b5c72578091"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("1fd37e19-1936-4978-b6ca-6e17ebdda47d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("262c4240-b98a-4253-bdf0-1109efde8501"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("28845160-e773-4566-942b-ac523e85bc35"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("2fe4b290-eb7e-470a-9a96-d14735d5b120"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("33414530-b6e9-4ac1-b8de-afa2413f9925"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("336b60c7-8ac8-4d69-bb56-bb6395d6eab4"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("3d774d76-77f5-40c1-b50e-7987549fbc52"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("445ad34f-03b9-4e3d-ac1c-9312e8bd7701"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("46104e6f-6b1e-4f14-a5b9-2a95fb3df358"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("491029c3-c8fc-46d1-98f8-2d028fa941f8"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("4c3e8350-e084-4251-b3fd-8498333d01e7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("4e60e875-cbe4-488c-9045-8a3a80d397ee"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("54c5645c-70d5-4e55-a700-1a1f3faef5ef"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("5e601378-64bd-4d33-9a24-2e1f3615523c"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6277fc0d-6a38-4b9c-b3bf-176ad12bc25d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("631972dc-6239-4135-99ec-e26d2f2ebefc"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("63bc7048-7d11-4710-a511-93a48e231912"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("655c3e3a-1f7d-4019-89d5-f12f4b90addf"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6b0d308c-671e-42a6-94a4-93a69893c0c7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("6b4b2f82-be6b-4efe-9352-6fb5765e57b4"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("77f79b66-de25-4a46-a8e5-2639076a3ee1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("79f9889b-6a72-46e2-9c15-62379a789c8d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("814fdba7-ab82-4f0f-920e-1eb422dd430e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("84343925-d449-4034-b854-2f565ef0aa4a"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("8e0fc739-5152-45e1-92fd-086d4ca6f096"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("8ffd58d9-2685-4503-a8d4-3aa1924a9556"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("94077705-2c15-43e7-8af0-37c4551f4cff"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("95d9c79b-5915-493c-b29a-b22351b06f93"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("96eada5c-d279-40d7-943e-d87a6c0ddb39"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("9c4a3917-e0c8-46f4-a464-df761b58ea2c"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("9d53c45f-3869-470b-9f5b-e40f6bb39cb1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("9e4f8fcf-881a-4a0a-b903-8b542e6f74f1"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a0c54704-713a-4823-b2ee-8547ec6efcb9"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a2f83ae5-c295-4d7c-b8fe-67b64475725d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a76ba9d2-d03f-485e-bf88-697ad1d9b7e8"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a78fa7d0-6a91-4062-994d-5b698045c8e6"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a924924f-f128-4bfb-b452-d33f61208acd"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("a935ca2c-c2cc-44fd-9c86-d546ec8430ce"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ab342674-e625-4742-89ee-fb8a9cc8970d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("b342d3ff-63bc-4a9f-887e-114fa2802291"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ba3ab3e3-9179-430e-9ec7-c7f0837f6d7d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("baf94ae2-b334-443c-af4c-380a91761452"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c00cc576-3f34-4083-9309-67db327f28c2"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c09d0d15-cfaa-4818-8a58-7f4464085ffc"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c1b0f00f-ec0b-44bb-b06d-6e51e0a35250"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c397c006-1451-4969-ad7c-dc6a36abfa43"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c3e404e5-db82-4f53-8066-19ab0822c7a7"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c8a2b7e9-fe0d-4b51-9d9c-f30daeaa942e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("c95038c1-f806-4310-847e-52386f9aec71"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("cd23d16c-8af0-421e-b983-bbebacc9492e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d52327ac-0aab-459a-8d86-f6f28040346a"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d65f4ba8-ac54-4cd1-ae78-911a80868dda"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("d70cc302-5724-4ad1-a04c-869bd80ac38c"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("dc568e6e-1ad2-4dd4-8514-6e38b78bc1ef"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("df3c19bc-72eb-48d8-9918-146675620d84"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e0d44271-2938-4fc6-8b83-23be75faa16f"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e155f34d-0df0-4144-8b29-d41bf55dc48d"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e48b5734-7023-4403-81fa-14b4d340a8c2"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e7ecf1e9-ed2f-426f-a31e-e3dad50dab96"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("e8909dbd-8557-4379-b572-1a62ee8e1870"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ea3b1b74-d8ce-44fd-84db-40537da29d1a"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ebce410f-3857-43ab-afa0-02aea28168bb"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("ef504c23-e8bf-4ce2-8217-026e1db34791"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f0eb272c-826d-48c5-b10f-4cfda735f943"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("f81631ac-6b3b-4572-a14b-20b42dfb77fd"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("fcb4424d-7e8e-4175-8009-b3bf1e25987e"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "UserFoods",
                keyColumns: new[] { "FoodId", "UserId" },
                keyValues: new object[] { new Guid("fd40c7dc-15b2-41ff-a2a4-61055621a522"), new Guid("a827159c-58f6-447c-88fe-800dbff80ef5") });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0446f521-e59c-4694-ac8a-6e9b70fa82e7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0750766b-2a92-42c4-8d39-69410513f166"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0b07d986-678f-4eb5-846f-d8c71dc6b0dd"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0e28a431-e088-46ed-b810-c9e763b46fe9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0f679875-5608-43bd-a908-4ed8cd80a5c9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("157f6732-4a4d-4e31-946e-b1fd95382a79"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("17ad9cbd-1c03-4de9-ba14-a367af51b5bf"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("1a17722f-4180-44f5-be7e-5ad7d9451fe1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("1e34e46d-caa6-495b-abd9-2b5c72578091"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("1fd37e19-1936-4978-b6ca-6e17ebdda47d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("262c4240-b98a-4253-bdf0-1109efde8501"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("28845160-e773-4566-942b-ac523e85bc35"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2fe4b290-eb7e-470a-9a96-d14735d5b120"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("33414530-b6e9-4ac1-b8de-afa2413f9925"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("336b60c7-8ac8-4d69-bb56-bb6395d6eab4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3d774d76-77f5-40c1-b50e-7987549fbc52"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("445ad34f-03b9-4e3d-ac1c-9312e8bd7701"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("46104e6f-6b1e-4f14-a5b9-2a95fb3df358"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("491029c3-c8fc-46d1-98f8-2d028fa941f8"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("4c3e8350-e084-4251-b3fd-8498333d01e7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("4e60e875-cbe4-488c-9045-8a3a80d397ee"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("54c5645c-70d5-4e55-a700-1a1f3faef5ef"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5e601378-64bd-4d33-9a24-2e1f3615523c"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6277fc0d-6a38-4b9c-b3bf-176ad12bc25d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("631972dc-6239-4135-99ec-e26d2f2ebefc"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63bc7048-7d11-4710-a511-93a48e231912"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("655c3e3a-1f7d-4019-89d5-f12f4b90addf"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6b0d308c-671e-42a6-94a4-93a69893c0c7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("6b4b2f82-be6b-4efe-9352-6fb5765e57b4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("77f79b66-de25-4a46-a8e5-2639076a3ee1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("79f9889b-6a72-46e2-9c15-62379a789c8d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("814fdba7-ab82-4f0f-920e-1eb422dd430e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("84343925-d449-4034-b854-2f565ef0aa4a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("8e0fc739-5152-45e1-92fd-086d4ca6f096"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("8ffd58d9-2685-4503-a8d4-3aa1924a9556"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("94077705-2c15-43e7-8af0-37c4551f4cff"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("95d9c79b-5915-493c-b29a-b22351b06f93"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("96eada5c-d279-40d7-943e-d87a6c0ddb39"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9c4a3917-e0c8-46f4-a464-df761b58ea2c"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9d53c45f-3869-470b-9f5b-e40f6bb39cb1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9e4f8fcf-881a-4a0a-b903-8b542e6f74f1"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a0c54704-713a-4823-b2ee-8547ec6efcb9"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a2f83ae5-c295-4d7c-b8fe-67b64475725d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a76ba9d2-d03f-485e-bf88-697ad1d9b7e8"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a78fa7d0-6a91-4062-994d-5b698045c8e6"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a924924f-f128-4bfb-b452-d33f61208acd"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a935ca2c-c2cc-44fd-9c86-d546ec8430ce"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ab342674-e625-4742-89ee-fb8a9cc8970d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b342d3ff-63bc-4a9f-887e-114fa2802291"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ba3ab3e3-9179-430e-9ec7-c7f0837f6d7d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("baf94ae2-b334-443c-af4c-380a91761452"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c00cc576-3f34-4083-9309-67db327f28c2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c09d0d15-cfaa-4818-8a58-7f4464085ffc"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c1b0f00f-ec0b-44bb-b06d-6e51e0a35250"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c397c006-1451-4969-ad7c-dc6a36abfa43"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c3e404e5-db82-4f53-8066-19ab0822c7a7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c8a2b7e9-fe0d-4b51-9d9c-f30daeaa942e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c95038c1-f806-4310-847e-52386f9aec71"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("cd23d16c-8af0-421e-b983-bbebacc9492e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d52327ac-0aab-459a-8d86-f6f28040346a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d65f4ba8-ac54-4cd1-ae78-911a80868dda"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("d70cc302-5724-4ad1-a04c-869bd80ac38c"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("dc568e6e-1ad2-4dd4-8514-6e38b78bc1ef"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("df3c19bc-72eb-48d8-9918-146675620d84"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e0d44271-2938-4fc6-8b83-23be75faa16f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e155f34d-0df0-4144-8b29-d41bf55dc48d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e48b5734-7023-4403-81fa-14b4d340a8c2"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e7ecf1e9-ed2f-426f-a31e-e3dad50dab96"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e8909dbd-8557-4379-b572-1a62ee8e1870"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ea3b1b74-d8ce-44fd-84db-40537da29d1a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ebce410f-3857-43ab-afa0-02aea28168bb"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("ef504c23-e8bf-4ce2-8217-026e1db34791"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f0eb272c-826d-48c5-b10f-4cfda735f943"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f81631ac-6b3b-4572-a14b-20b42dfb77fd"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("fcb4424d-7e8e-4175-8009-b3bf1e25987e"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("fd40c7dc-15b2-41ff-a2a4-61055621a522"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("ade52ab4-361b-43ba-ac21-4507ce1f918a"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("f02ec0fc-202e-49bc-9080-c9dc5c843d29"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("f2bdc7a7-2367-41e3-9df3-9bd1e2ccb171"));

            migrationBuilder.DeleteData(
                table: "FoodGroups",
                keyColumn: "Id",
                keyValue: new Guid("f67227cd-08f4-415c-9658-670d9dabb5c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a827159c-58f6-447c-88fe-800dbff80ef5"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FoodGroups");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCurrentDiet",
                table: "UserFoods",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FromInitialSeed",
                table: "Foods",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsCurrentDiet",
                table: "UserFoods",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "FromInitialSeed",
                table: "Foods",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FoodGroups",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

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
        }
    }
}
