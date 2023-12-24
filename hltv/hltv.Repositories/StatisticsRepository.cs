using hltv.Core.context;
using hltv.Core.entities;
using System.Collections.Generic;
using System.Linq;

namespace hltv.Repositories
{
    public class StatisticsRepository
    {
        private hltvContext ctx;

        public StatisticsRepository(hltvContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Statistics> GetAll()
        {
            return ctx.Statistics.ToList();
        }

        public Statistics Get(int id)
        {
            return ctx.Statistics.Find(id);
        }

        public int Add(Statistics statistics)
        {
            var obj = ctx.Statistics.Add(statistics);
            ctx.SaveChanges();
            return obj.Entity.StatisticsId;
        }

        public void Update(int id, Statistics updatedStatistics)
        {
            var stats = ctx.Statistics.Find(id);

            if (stats != null)
            {
                UpdateStatistics(stats, updatedStatistics);
                
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var stats = ctx.Statistics.Find(id);

            if (stats != null)
            {
                ctx.Statistics.Remove(stats);
                ctx.SaveChanges();
            }
        }

        public List<Statistics> GetPlayerStatistics(int playerId)
        {
            return ctx.Statistics.Where(stat => stat.Player.Any(p => p.PlayerId == playerId)).ToList();
        }

        private void UpdateStatistics(Statistics stats, Statistics updatedStatistics)
        {
            stats.KdDifference = updatedStatistics.KdDifference;
            stats.KdRatio = updatedStatistics.KdRatio;
            stats.Rating = updatedStatistics.Rating;
            stats.TotalKills = updatedStatistics.TotalKills;
            stats.HeadshotPercentage = updatedStatistics.HeadshotPercentage;
            stats.TotalDeaths = updatedStatistics.TotalDeaths;
        }
    }
}
