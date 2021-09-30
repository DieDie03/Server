using Microsoft.EntityFrameworkCore;
using MakerHub.DAL.Configurations;
using MakerHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace MakerHub.DAL
{
    public class MakerHubDBContext : DbContext
    {
        public DbSet<Aggrometre> Humidity { get; set; }
        public DbSet<Sound> Intensity { get; set; }
        public DbSet<Light> Green { get; set; }
        public DbSet<Light> Blue { get; set; }
        public DbSet<Light> Red { get; set; }
        public DbSet<Temperature> Degrees { get; set; }
        public DbSet<Temperature> Farenheit { get; set; }
        private readonly string DbPath;

        public MakerHubDBContext()
        {
            //    var folder = Environment.SpecialFolder.DesktopDirectory;
            //    var path = Environment.GetFolderPath(folder);
            DbPath = $"MakerHUB.db";
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=K-PC;initial catalog=MovieDB;integrated security=true");
            //optionsBuilder.UseSqlServer("server=;initial catalog=;uid=sa;pwd=test1234");
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new AggroConfig());
            mb.ApplyConfiguration(new LightConfig());
            mb.ApplyConfiguration(new SoundConfig());
            mb.ApplyConfiguration(new TempConfig());
        }
    }
}
