using CsvHelper.Configuration;
using CsvHelper;

public class MyStringListConverter : CsvHelper.TypeConversion.StringConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (!string.IsNullOrEmpty(text))
        {
            var cleanedText = text.Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "").Replace("'", "");
            var teamsList = cleanedText.Split(',').Select(s => s.Trim()).ToList();
            return teamsList;
        }
        return base.ConvertFromString(text, row, memberMapData);
    }
}


public record CSPlayerStats(
    string nick,
    string country,
    string stats_link,
    [CsvHelper.Configuration.Attributes.TypeConverter(typeof(MyStringListConverter))]
    List<string> teams,
    int maps_played,
    int rounds_played,
    int kd_difference,
    double kd_ratio,
    double rating,
    int total_kills,
    double headshot_percentage,
    int total_deaths,
    double grenade_damage_per_round,
    double kills_per_round,
    double assists_per_round,
    double deaths_per_round,
    double teammate_saved_per_round,
    double saved_by_teammate_per_round,
    double kast,
    double impact

);

//public record CSPlayerStats(
//    string nick,
//    string country,
//    string stats_link,
//    List<string> teams,//////////
//    int maps_played,
//    int rounds_played,
//    int kd_difference,
//    double kd_ratio,
//    double rating,
//    int total_kills,
//    double headshot_percentage,
//    int total_deaths,
//    double grenade_damage_per_round,
//    double kills_per_round,
//    double assists_per_round,
//    double deaths_per_round,
//    double teammate_saved_per_round,
//    double saved_by_teammate_per_round,
//    double kast,
//    double impact
//);
