﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GameEventLog.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Situation", "Effort", "Success", "Result" },//removed PK column from these three statements so it doesn't bomb if someone saves an event before using 2nd migration
                values: new object[] {"We arrived at the dungeon entrance.",
                    "I tried to open the door.",
                    false,
                    "The door seemed to be held shut."
                    }
                );
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Effort", "Success", "Result" },
                values: new object[] {"We told the door to open.",
                    true,
                    "After some loud mechanical noises the door swung open."
                    }
                );
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Situation", "Effort", "Success", "Result" },
                values: new object[] {"We walked inside and a bat flew at my face.",
                    "I swing my weapon at the bat.",
                    true,
                    "Bat went splat!"
                    }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Events",
            //    keyColumn: "EventId",
            //    keyValue: 1
            //    );
            //migrationBuilder.DeleteData(
            //    table: "Events",
            //    keyColumn: "EventId",
            //    keyValue: 2
            //    );
            //migrationBuilder.DeleteData(
            //    table: "Events",
            //    keyColumn: "EventId",
            //    keyValue: 3
            //    );
            migrationBuilder.Sql("DELETE FROM Events", true);
        }
    }
}
