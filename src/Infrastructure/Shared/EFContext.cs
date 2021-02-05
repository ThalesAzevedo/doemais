using Microsoft.EntityFrameworkCore;
using DoeMaisApi.src.Infrastructure.Configurations.DonorAggregateConfigurations;
using DoeMaisApi.src.Domain.Entities.DonorAggregate;

namespace DoeMaisApi.src.Infrastructure.Shared
{
    public class EFContext : DbContext
    {
        public virtual DbSet<Donor> Donor {get; set;}

        public EFContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donor>(new DonorEntityMapping().Configure);
            
        }
    }
}