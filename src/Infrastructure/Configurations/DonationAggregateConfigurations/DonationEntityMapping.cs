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
            builder.HasKey(Donation => Donation.DonationId);

            builder.Property(Donation => Donation.CreatedAt);
            // .IsRequired();
            
            builder.Property(Donation => Donation.DonorId)
            .IsRequired();
            
            builder.Property(Donation => Donation.BloodcenterId)
            .IsRequired();
            
            builder.Property(Donation => Donation.Status)
            .IsRequired();

            builder.Property(Donation => Donation.Schedule)
            .IsRequired();
        }
    }
}
