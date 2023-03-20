
using ClassLibrary1.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace ClassLibrary1.Models;

public partial class GatherlyContext : DbContext
{
    public GatherlyContext()
    {
    }

    public GatherlyContext(DbContextOptions<GatherlyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendee> Attendees { get; set; }

    public virtual DbSet<Gathering> Gatherings { get; set; }

    public virtual DbSet<Invitation> Invitations { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<OutboxMessage> OutboxMessages { get; set; }

    public virtual DbSet<OutboxMessageConsumer> OutboxMessageConsumers { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\Sqlexpress;Initial Catalog=Gatherly;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.ApplyConfiguration(new Configurations.AttendeeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.GatheringConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.InvitationConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.MemberConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OutboxMessageConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OutboxMessageConsumerConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RoleConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
