using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using hltv.Core.context;
using hltv.Core.entities;
using Microsoft.EntityFrameworkCore;



namespace hltv.Repositories
{
    public class PlayerRepository
    {
        private hltvContext ctx;

        public PlayerRepository(hltvContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Player> GetAll() => ctx.Player.ToList();

        public Player Get(int id) => ctx.Player.Find(id);

        public Player GetById(int playerId) => ctx.Player.FirstOrDefault(player => player.PlayerId == playerId);

        public int Add(Player player)
        {
            var obj = ctx.Player.Add(player);
            ctx.SaveChanges();
            return obj.Entity.PlayerId;
        }

        public void Update(int id, Player updatedPlayer)
        {
            try
            {
                var player = ctx.Player.Find(id);

                if (player != null)
                {
                    ctx.Entry(player).CurrentValues.SetValues(updatedPlayer);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {

                Console.WriteLine($"Concurrency Exception: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database Update Exception: {ex.Message}");
                throw;
            }
        }

        public void Delete(int id)
        {
            var player = ctx.Player.Find(id);

            if (player != null)
            {
                ctx.Player.Remove(player);
                ctx.SaveChanges();
            }
        }
        public void Save()
        {
            ctx.SaveChanges();
        }

    }
}
