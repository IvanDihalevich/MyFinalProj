using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hltv.Core.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "RoundStatistics",
                columns: table => new
                {
                    RoundStatisticsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrenadeDamagePerRound = table.Column<double>(type: "float", nullable: false),
                    KillsPerRound = table.Column<double>(type: "float", nullable: false),
                    AssistsPerRound = table.Column<double>(type: "float", nullable: false),
                    DeathsPerRound = table.Column<double>(type: "float", nullable: false),
                    TeammateSavedPerRound = table.Column<double>(type: "float", nullable: false),
                    SavedByTeammatePerRound = table.Column<double>(type: "float", nullable: false),
                    Kast = table.Column<double>(type: "float", nullable: false),
                    Impact = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundStatistics", x => x.RoundStatisticsId);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    StatisticsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KdDifference = table.Column<double>(type: "float", nullable: false),
                    KdRatio = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    TotalKills = table.Column<int>(type: "int", nullable: false),
                    HeadshotPercentage = table.Column<double>(type: "float", nullable: false),
                    TotalDeaths = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.StatisticsId);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nick = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StatsLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    RoundStatisticsId = table.Column<int>(type: "int", nullable: false),
                    StatisticsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Player_RoundStatistics_RoundStatisticsId",
                        column: x => x.RoundStatisticsId,
                        principalTable: "RoundStatistics",
                        principalColumn: "RoundStatisticsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Player_Statistics_StatisticsId",
                        column: x => x.StatisticsId,
                        principalTable: "Statistics",
                        principalColumn: "StatisticsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_CountryId",
                table: "Player",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_RoundStatisticsId",
                table: "Player",
                column: "RoundStatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_StatisticsId",
                table: "Player",
                column: "StatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "RoundStatistics");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
