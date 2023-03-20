﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary1.Models.Configurations
{
    public partial class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> entity)
        {
            entity.HasIndex(e => e.Email, "IX_Members_Email").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedOnUtc).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.HasMany(d => d.Roles).WithMany(p => p.Members)
            .UsingEntity<Dictionary<string, object>>(
                "MemberRole",
                r => r.HasOne<Role>().WithMany().HasForeignKey("RolesId"),
                l => l.HasOne<Member>().WithMany().HasForeignKey("MembersId"),
                j =>
                {
                    j.HasKey("MembersId", "RolesId");
                    j.ToTable("MemberRole");
                    j.HasIndex(new[] { "RolesId" }, "IX_MemberRole_RolesId");
                });

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Member> entity);
    }
}