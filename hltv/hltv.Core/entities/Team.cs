using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Core.entities
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }

        public string TeamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }

        public override string ToString()
        {
            return $"{TeamId}{TeamName};";
        }
    }
}
