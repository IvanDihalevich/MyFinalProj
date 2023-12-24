using CsvHelper;
using hltv.Core.context;
using hltv.Core.entities;
using System;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text.Json;

Player player1 = new Player();
var id = player1.PlayerId;
var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "hltv_playerStats-complete.csv");

IEnumerable<CSPlayerStats> records = null;

Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Application initialized!");


using (var reader = new StreamReader(dataPath))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    records = csv.GetRecords<CSPlayerStats>().ToList();
}


Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] hltv data loaded!");

var context = new hltvContext();


foreach (var r in records)
{
    context.Statistics.Add(new Statistics
    {
        KdDifference = r.kd_difference,
        KdRatio = r.kd_ratio,
        Rating = r.rating,
        TotalKills = r.total_kills,
        HeadshotPercentage = r.headshot_percentage,
        TotalDeaths = r.total_deaths,
    });
}
context.SaveChanges();

Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Statistics data saved to database!");

foreach (var r in records)
{
    context.RoundStatistics.Add(new RoundStatistics
    {
        GrenadeDamagePerRound = r.grenade_damage_per_round,
        KillsPerRound = r.kills_per_round,
        AssistsPerRound = r.assists_per_round,
        DeathsPerRound = r.deaths_per_round,
        TeammateSavedPerRound = r.teammate_saved_per_round,
        SavedByTeammatePerRound = r.saved_by_teammate_per_round,
        Kast = r.kast,
        Impact = r.impact,
    });
}
context.SaveChanges();

Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] RoundStatistics data saved to database!");


var teamsToAdd = records
    .SelectMany(r => r.teams)
    .Distinct()
    .Select(teamName => new Team { TeamName = teamName });

context.Team.AddRange(teamsToAdd);


context.SaveChanges();



Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Team data saved to database!");
foreach (var r in records)
{
    var statisticsData = new Statistics
    {
        KdDifference = r.kd_difference,
        KdRatio = r.kd_ratio,
        Rating = r.rating,
        TotalKills = r.total_kills,
        HeadshotPercentage = r.headshot_percentage,
        TotalDeaths = r.total_deaths,
    };

    context.Statistics.Add(statisticsData);

    var roundStatisticsData = new RoundStatistics
    {
        GrenadeDamagePerRound = r.grenade_damage_per_round,
        KillsPerRound = r.kills_per_round,
        AssistsPerRound = r.assists_per_round,
        DeathsPerRound = r.deaths_per_round,
        TeammateSavedPerRound = r.teammate_saved_per_round,
        SavedByTeammatePerRound = r.saved_by_teammate_per_round,
        Kast = r.kast,
        Impact = r.impact,
    };
    context.RoundStatistics.Add(roundStatisticsData);


    var player = new Player
    {

        Nick = r.nick,
        Country = new Country { Name = r.country },
        StatsLink = r.stats_link,
        RoundStatisticsId = roundStatisticsData.RoundStatisticsId,
        StatisticsId = statisticsData.StatisticsId,
        Statistics = statisticsData,
        RoundStatistics = roundStatisticsData,
    };
    
   

    foreach (var teamName in r.teams)
    {
        var team = context.Team.FirstOrDefault(t => t.TeamName == teamName);

        if (team == null)
        {
            team = new Team { TeamName = teamName };
            context.Team.Add(team);
            context.SaveChanges();  
        }

        player.TeamId = team.TeamId; 
    }

    context.Player.Add(player);
}

context.SaveChanges();


Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Player data saved to database!");

foreach (var r in records)
{
    var country = new Country
    {
        Name = r.country,
    };

    context.Country.Add(country);
}

context.SaveChanges();

Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Country data saved to database!");
