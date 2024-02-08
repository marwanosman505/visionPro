using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;
using VisionProApp.Models;
namespace VisionProApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
            public DbSet<Client> Clients { get; set; }
            public DbSet<Site> Sites { get; set; }
            public DbSet<Building> Buildings { get; set; }
            public DbSet<Room> Rooms { get; set; }
            public DbSet<Asset> Assets { get; set; }

    }
}
