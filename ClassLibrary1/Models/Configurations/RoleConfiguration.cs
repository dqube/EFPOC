﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary1.Models.Configurations
{
    public partial class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> entity)
        {
            entity.HasMany(d => d.Permissions).WithMany(p => p.Roles)
            .UsingEntity<Dictionary<string, object>>(
                "RolePermission",
                r => r.HasOne<Permission>().WithMany().HasForeignKey("PermissionId"),
                l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
                j =>
                {
                    j.HasKey("RoleId", "PermissionId");
                    j.ToTable("RolePermission");
                    j.HasIndex(new[] { "PermissionId" }, "IX_RolePermission_PermissionId");
                });

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Role> entity);
    }
}
