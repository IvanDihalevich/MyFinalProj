using hltv.Core.context;
using hltv.Core.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Repositories
{
    public class RoundStatisticsRepository
    {
        private hltvContext ctx;

        public RoundStatisticsRepository(hltvContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<RoundStatistics> GetAll()
        {
            return ctx.RoundStatistics.ToList();
        }

        public RoundStatistics Get(int id)
        {
            return ctx.RoundStatistics.FirstOrDefault(rs => rs.RoundStatisticsId == id);
        }

        public RoundStatistics Add(RoundStatistics roundStatistics)
        {
            var obj = ctx.RoundStatistics.Add(roundStatistics);
            ctx.SaveChanges();
            return obj.Entity;
        }

        public void Update(int id, RoundStatistics updatedRoundStatistics)
        {
            var roundStats = ctx.RoundStatistics.FirstOrDefault(rs => rs.RoundStatisticsId == id);

            if (roundStats != null)
            {
                UpdateRoundStatistics(roundStats, updatedRoundStatistics);
                ctx.SaveChanges();
            }
            else
            {

            }
        }

        public void Delete(int id)
        {
            var roundStats = ctx.RoundStatistics.FirstOrDefault(rs => rs.RoundStatisticsId == id);

            if (roundStats != null)
            {
                ctx.RoundStatistics.Remove(roundStats);
                ctx.SaveChanges();
            }
            else
            {

            }
        }

        private void UpdateRoundStatistics(RoundStatistics roundStats, RoundStatistics updatedRoundStatistics)
        {
            roundStats.GrenadeDamagePerRound = updatedRoundStatistics.GrenadeDamagePerRound;
            roundStats.KillsPerRound = updatedRoundStatistics.KillsPerRound;
            roundStats.AssistsPerRound = updatedRoundStatistics.AssistsPerRound;
            roundStats.DeathsPerRound = updatedRoundStatistics.DeathsPerRound;
            roundStats.TeammateSavedPerRound = updatedRoundStatistics.TeammateSavedPerRound;
            roundStats.SavedByTeammatePerRound = updatedRoundStatistics.SavedByTeammatePerRound;
            roundStats.Kast = updatedRoundStatistics.Kast;
            roundStats.Impact = updatedRoundStatistics.Impact;
        }
        public RoundStatistics Get(int id, bool includeRoundStatistics = false)
        {
            var query = ctx.RoundStatistics.AsQueryable();

            if (includeRoundStatistics)
            {
                query = query.Include(rs => rs.Player); 
            }

            return query.FirstOrDefault(rs => rs.RoundStatisticsId == id);
        }

    }
}
