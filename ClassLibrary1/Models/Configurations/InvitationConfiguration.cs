﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary1.Models.Configurations
{
    public partial class InvitationConfiguration : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> entity)
        {
            entity.HasIndex(e => e.GatheringId, "IX_Invitations_GatheringId");

            entity.HasIndex(e => e.MemberId, "IX_Invitations_MemberId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Gathering).WithMany(p => p.Invitations).HasForeignKey(d => d.GatheringId);

            entity.HasOne(d => d.Member).WithMany(p => p.Invitations)
            .HasForeignKey(d => d.MemberId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Invitation> entity);
    }
}
