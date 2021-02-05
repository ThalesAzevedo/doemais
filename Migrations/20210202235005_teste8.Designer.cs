﻿// <auto-generated />
using DoeMaisApi.src.Infrastructure.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoeMaisApi.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210202235005_teste8")]
    partial class teste8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DoeMaisApi.src.Domain.Entities.DonorAggregate.Donor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodType")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrationId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("donor");
                });
#pragma warning restore 612, 618
        }
    }
}
