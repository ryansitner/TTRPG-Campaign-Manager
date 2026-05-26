using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Data
{
    public partial class CampaignDbContext : DbContext
    {
        public DbSet<Models.BaseCreature> BaseCreatures { get; set; } = null!;
        public DbSet<Models.Npc> Npcs { get; set; } = null!;
        public DbSet<Models.Enemy> Enemies { get; set; } = null!;
        public DbSet<Models.CreatureSpell> CreatureSpells { get; set; } = null!;
        public DbSet<Models.Item> Items { get; set; } = null!;
        public DbSet<Models.Map> Maps { get; set; } = null!;
        public DbSet<Models.Town> Towns { get; set; } = null!;
        public DbSet<Models.POI> POIs { get; set; } = null!;

        public CampaignDbContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Find a safe, permanent folder on the user's computer (Local AppData)
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string dbPath = Path.Combine(folder, "CampaignData_v3.db");

            // Tell EF Core to use that specific path
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
