using Microsoft.EntityFrameworkCore;
using WindsurfingRestAPI.Entities; 

namespace WindsurfingRestAPI.DBcontext
{
    public class Windsurfdatabase : DbContext
    {
        public DbSet<Windsurfer> Windsurfers { get; set; }   
        public DbSet<Spot> Spots { get; set;  }
        //we have to be careful when overriding methods in using the right access identifiers " protected in the parent method " , you can't override it to public ;) !! 
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=WindsurfDB;Integrated Security=true");
            base.OnConfiguring(optionBuilder);
        }
        //public Windsurfdatabase(DbContextOptions<Windsurfdatabase> options) : base(options)
        //{

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       //many to many configuration 
            modelBuilder.ApplyConfiguration(new SpotsConfiguration());

        }
    }
    }

