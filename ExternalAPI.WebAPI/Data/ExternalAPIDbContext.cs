using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using ExternalAPI.WebAPI.Models;

namespace ExternalAPI.WebAPI.Data
{
    public class ExternalAPIDbContext : DbContext
    {
        public ExternalAPIDbContext(DbContextOptions<ExternalAPIDbContext> options) : base(options) {}

        public DbSet<DataModel> DataModels { get; set; }
    }
}
