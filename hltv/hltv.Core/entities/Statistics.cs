using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Core.entities
{
    public class Statistics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatisticsId { get; set; }
        public double KdDifference { get; set; }
        public double KdRatio { get; set; }
        public double Rating { get; set; }
        public int TotalKills { get; set; }
        public double HeadshotPercentage { get; set; }
        public int TotalDeaths { get; set; }
        public virtual ICollection<Player> Player { get; set; }

        public override string ToString()
        {
            return $"{StatisticsId})KdDifference: {KdDifference};KdRatio: {KdRatio};Rating: {Rating};TotalKills: {TotalKills};" +
                $"HeadshotPercentage: {HeadshotPercentage};TotalDeaths: {TotalDeaths};";
        }
    }
}
