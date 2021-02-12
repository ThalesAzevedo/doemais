using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoeMaisApi.src.Infrastructure.Configurations.BloodCenterAggregateConfigurations
{
    public class BloodCenterEntityMapping: IEntityTypeConfiguration<BloodCenter> 
    {
        public void Configure(EntityTypeBuilder<BloodCenter> builder)
        {
            builder.ToTable("blood_center");
            builder.HasKey(BloodCenter => BloodCenter.Id);

            builder.Property(BloodCenter => BloodCenter.Responsible)
            .IsRequired();
            
            builder.Property(BloodCenter => BloodCenter.Address)
            .IsRequired();

            builder.Property(BloodCenter => BloodCenter.PhoneNumber)
            .IsRequired();

        }
    }
}