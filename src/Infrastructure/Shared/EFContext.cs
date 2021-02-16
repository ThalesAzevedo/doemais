using Microsoft.EntityFrameworkCore;
using DoeMaisApi.src.Infrastructure.Configurations.DonorAggregateConfigurations;
using DoeMaisApi.src.Domain.Entities.DonorAggregate;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate;
using DoeMaisApi.src.Infrastructure.Configurations.BloodCenterAggregateConfigurations;
using DoeMaisApi.src.Domain.Entities.DonationAggregate;
using DoeMaisApi.src.Infrastructure.Configurations.DonationAggregateConfigurations;

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
            modelBuilder.Entity<BloodCenter>(new BloodCenterEntityMapping().Configure);
            modelBuilder.Entity<Donation>(new DonationEntityMapping().Configure);
            
            
            
        }
    }
}