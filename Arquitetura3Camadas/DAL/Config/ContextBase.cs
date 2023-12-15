using Microsoft.EntityFrameworkCore;
using Models.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<MusicViewModel> Music { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicViewModel>();
        }

        //protected override void OnConfiguring
        //          (DbContextOptionsBuilder OptionsBuilder)
        //{
        //    OptionsBuilder.UseSqlServer(@"data source=CTS1B147270\\SQLEXPRESS;
        //    initial catalog = Laser; integrated security = true;
        //    TrustServerCertificate=True;");
        //    base.OnConfiguring(OptionsBuilder);
        //}
    }
}
