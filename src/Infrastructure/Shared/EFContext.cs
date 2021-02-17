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
        public virtual DbSet<Donor> Donors {get; set;}
        public virtual DbSet<Donation> Donations {get; set;}
        public virtual DbSet<BloodCenter> BloodCenters {get; set;}

        public EFContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Donor>(new DonorEntityMapping());
            modelBuilder.ApplyConfiguration<BloodCenter>(new BloodCenterEntityMapping());
            modelBuilder.ApplyConfiguration<Donation>(new DonationEntityMapping());
        }
    }
}