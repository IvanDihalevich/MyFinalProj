using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Core.entities
{
    public class RoundStatistics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoundStatisticsId { get; set; }
        public double GrenadeDamagePerRound { get; set; }
        public double KillsPerRound { get; set; }
        public double AssistsPerRound { get; set; }
        public double DeathsPerRound { get; set; }
        public double TeammateSavedPerRound { get; set; }
        public double SavedByTeammatePerRound { get; set; }
        public double Kast { get; set; }
        public double Impact { get; set; }
        public virtual ICollection<Player> Player { get; set; }


        public override string ToString()
        {
            return $"{RoundStatisticsId})GrenadeDamagePerRound: {GrenadeDamagePerRound};KillsPerRound: {KillsPerRound};AssistsPerRound: {AssistsPerRound};" +
                $"DeathsPerRound: {DeathsPerRound};TeammateSavedPerRound: {TeammateSavedPerRound};" +
                $"SavedByTeammatePerRound:{SavedByTeammatePerRound};Kast{Kast};Impact:{Impact};";
        }
    }
}
