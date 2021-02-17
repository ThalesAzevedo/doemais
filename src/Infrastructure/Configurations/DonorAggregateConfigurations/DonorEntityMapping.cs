using DoeMaisApi.src.Domain.Entities.DonorAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DoeMaisApi.src.Infrastructure.Configurations.DonorAggregateConfigurations
{
    public class DonorEntityMapping : IEntityTypeConfiguration<Donor> 
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.ToTable("donor");
            builder.HasKey(Donor => Donor.DonorId);

            builder.Property(Donor => Donor.FirstName)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnName("first_name");

            builder.Property(Donor => Donor.LastName)
            .IsRequired()
            .HasMaxLength(70)
            .HasColumnName("last_name");

            builder.Property(Donor => Donor.BirthDate)
            .IsRequired()
            .HasColumnName("birth_date");

            builder.Property( Donor => Donor.BloodType)
            .IsRequired()
            .HasMaxLength(3)
            .HasColumnName("blood_type");

            builder.Property(Donor  => Donor.Gender)
            .IsRequired()
            .HasMaxLength(1)
            .HasColumnName("gender");

            builder.Property(Donor => Donor.RegistrationId)
            .IsRequired()
            .HasMaxLength(11)
            .HasColumnName("registration_id");

            builder.Property(Donor => Donor.Localization)
            .HasMaxLength(40)
            .HasColumnName("localization");

            builder.Property(Donor => Donor.CreatedAt)
            .IsRequired()
            .HasColumnName("created_at");
        }
    }
}