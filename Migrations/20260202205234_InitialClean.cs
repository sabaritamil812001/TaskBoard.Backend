using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskBoard.Migrations
{
    /// <inheritdoc />
    public partial class InitialClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0928d264-e54a-4607-90a0-bccd02f20a2f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("24812b32-c11b-442b-a108-0e662ea4d109"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2840da54-0edf-429e-ad84-b89fcccaa14d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("31588230-8b91-4d51-9a48-6e7f025a0e4f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("34c5adb2-3cad-41bd-b749-f3e63910fa11"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3bf0cc9d-954a-4895-9592-d5e9786bf6d4"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3e10ee5e-fddf-4c09-b6ab-b23bc10c12a6"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6285a370-22db-479e-b5e2-9fe0d0fd8a5b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6888bcd4-9c27-42b8-bc04-e578149d99f2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6aa411d4-5839-4b71-8978-c2ad61c1b0b1"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("728adcc7-250c-4692-99fa-32f72248d49e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("765d35c0-e891-4904-8b69-92ddf25ecae7"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("78da9c4d-1100-4dcd-b60a-f411870cb470"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7dca82f1-7117-4512-aa62-9f0b7213b97e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("828d2cbe-30f8-448c-97f5-a5269f78d1b2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8d243d07-d499-49f4-81e1-975808b2f543"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("99978588-2bdd-4e57-a901-73071a232125"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ba7f8a37-7e28-494d-8954-c27f7ed39484"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d7003697-005d-4635-87af-9b1f225f5a86"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f9dc9e64-a62e-4345-b488-bdb9f7fab6ec"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Assignee", "CreatedAt", "Description", "DueDate", "Priority", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0928d264-e54a-4607-90a0-bccd02f20a2f"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(668), null, null, 1, 0, "Seed Task 6", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(669) },
                    { new Guid("24812b32-c11b-442b-a108-0e662ea4d109"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(753), null, null, 1, 0, "Seed Task 13", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(753) },
                    { new Guid("2840da54-0edf-429e-ad84-b89fcccaa14d"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(760), null, null, 1, 0, "Seed Task 15", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(760) },
                    { new Guid("31588230-8b91-4d51-9a48-6e7f025a0e4f"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(737), null, null, 1, 0, "Seed Task 10", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(738) },
                    { new Guid("34c5adb2-3cad-41bd-b749-f3e63910fa11"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(749), null, null, 1, 0, "Seed Task 12", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(750) },
                    { new Guid("3bf0cc9d-954a-4895-9592-d5e9786bf6d4"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(779), null, null, 1, 0, "Seed Task 19", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(780) },
                    { new Guid("3e10ee5e-fddf-4c09-b6ab-b23bc10c12a6"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(619), null, null, 1, 0, "Seed Task 2", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(619) },
                    { new Guid("6285a370-22db-479e-b5e2-9fe0d0fd8a5b"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(772), null, null, 1, 0, "Seed Task 18", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(773) },
                    { new Guid("6888bcd4-9c27-42b8-bc04-e578149d99f2"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(640), null, null, 1, 0, "Seed Task 3", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(641) },
                    { new Guid("6aa411d4-5839-4b71-8978-c2ad61c1b0b1"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(763), null, null, 1, 0, "Seed Task 16", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(764) },
                    { new Guid("728adcc7-250c-4692-99fa-32f72248d49e"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(723), null, null, 1, 0, "Seed Task 9", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(723) },
                    { new Guid("765d35c0-e891-4904-8b69-92ddf25ecae7"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(644), null, null, 1, 0, "Seed Task 4", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(644) },
                    { new Guid("78da9c4d-1100-4dcd-b60a-f411870cb470"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(608), null, null, 1, 0, "Seed Task 1", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(610) },
                    { new Guid("7dca82f1-7117-4512-aa62-9f0b7213b97e"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(746), null, null, 1, 0, "Seed Task 11", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(746) },
                    { new Guid("828d2cbe-30f8-448c-97f5-a5269f78d1b2"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(715), null, null, 1, 0, "Seed Task 8", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(716) },
                    { new Guid("8d243d07-d499-49f4-81e1-975808b2f543"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(756), null, null, 1, 0, "Seed Task 14", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(757) },
                    { new Guid("99978588-2bdd-4e57-a901-73071a232125"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(767), null, null, 1, 0, "Seed Task 17", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(767) },
                    { new Guid("ba7f8a37-7e28-494d-8954-c27f7ed39484"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(711), null, null, 1, 0, "Seed Task 7", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(712) },
                    { new Guid("d7003697-005d-4635-87af-9b1f225f5a86"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(647), null, null, 1, 0, "Seed Task 5", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(648) },
                    { new Guid("f9dc9e64-a62e-4345-b488-bdb9f7fab6ec"), null, new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(783), null, null, 1, 0, "Seed Task 20", new DateTime(2026, 2, 2, 19, 23, 3, 691, DateTimeKind.Utc).AddTicks(783) }
                });
        }
    }
}
