using DoeMaisApi.src.Domain.Entities.DonationAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DoeMaisApi.src.Infrastructure.Configurations.DonationAggregateConfigurations
{
    public class DonationEntityMapping : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("donations");
            builder.HasKey(Donation => Donation.Id);

            builder.Property(Donation => Donation.CreatedAt);
            // .IsRequired();
            
            builder.Property(Donation => Donation.Donor)
            .IsRequired();
            
            builder.Property(Donation => Donation.Bloodcenter)
            .IsRequired();
            
            builder.Property(Donation => Donation.Status)
            .IsRequired();

            builder.Property(Donation => Donation.Schedule)
            .IsRequired();
        }
    }
}
