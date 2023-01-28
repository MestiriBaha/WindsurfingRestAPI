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
            var configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionBuilder.UseSqlServer(connectionString);
            //optionBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=WindsurfDB;Integrated Security=true");
            base.OnConfiguring(optionBuilder);
        }
        //public Windsurfdatabase(DbContextOptions<Windsurfdatabase> options) : base(options)
        //{

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       //many to many configuration 
            modelBuilder.ApplyConfiguration(new SpotsConfiguration());
            //database seeding while creation , we can avoid this method anyway ! let's try to be professionals :p 
           // modelBuilder.Entity<Spot>().HasData(new Spot("ELGOUNA", "EGYPT", "most popular luxurious windsurfing spot "), new Spot("Mahdia beach" , "Tunisia","My Hometown Windsurfing spot"));
           // modelBuilder.Entity<Windsurfer>().HasData(new Windsurfer("baha mestiri", "23", "Tunisian") { ID = 0 }, new Windsurfer("Adem Zarbout", "20", "Tunisian") { ID=1}) ; 

        }
    }
    }

