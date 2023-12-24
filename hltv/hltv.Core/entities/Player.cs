using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Core.entities
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }

        public string Nick { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public string StatsLink { get; set; }

        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        [ForeignKey("RoundStatistics")]
        public int RoundStatisticsId { get; set; }
        public virtual RoundStatistics RoundStatistics { get; set; }

        [ForeignKey("Statistics")]
        public int StatisticsId { get; set; }
        public virtual Statistics Statistics { get; set; }

        public override string ToString()
        {
            return $"{PlayerId}) {Nick}; {StatsLink};";
        }

    }
}
