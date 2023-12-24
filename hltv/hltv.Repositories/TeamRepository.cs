using hltv.Core.context;
using hltv.Core.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Repositories
{
    public class TeamRepository
    {
        private hltvContext ctx;

        public TeamRepository(hltvContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Team> GetAll()
        {

            return ctx.Team.AsQueryable();

        }

        public Team Get(int id)
        {
            return ctx.Team.Find(id);
        }

        public int Add(Team team)
        {
            var obj = ctx.Team.Add(team);
            ctx.SaveChanges();
            return obj.Entity.TeamId;
        }

        public void Update(int id, Team updatedTeam)
        {
            var team = ctx.Team.Find(id);

            if (team != null)
            {
                team.TeamName = updatedTeam.TeamName;

                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var team = ctx.Team.Find(id);

            if (team != null)
            {
                ctx.Team.Remove(team);
                ctx.SaveChanges();
            }
        }

        public Team GetById(int id)
        {
            return Get(id);
        }

        public IEnumerable<Player> GetPlayersForTeam(int teamId)
        {

            return ctx.Team.Where(t => t.TeamId == teamId).SelectMany(t => t.Players).ToList();
        }


    }
}
