using FluentApiLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentApiLab.Data.Configurations
{
    public class CustomerConfiguration
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(e => e.CustomerId);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.Email)
                .HasMaxLength(80);

            builder.Property(e => e.Phone)
                .IsRequired();

            builder.Property(e => e.SKU)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.DateOfBirth)
                .IsRequired();

            builder.Property(e => e.RowVersion)
                .IsRowVersion();

            builder.HasIndex(e => e.SKU)
                .IsUnique();

            builder.HasOne(e => e.Category)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
