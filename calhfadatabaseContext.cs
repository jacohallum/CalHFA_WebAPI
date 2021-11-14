using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CalHFA.Model
{
    public partial class calhfadatabaseContext : DbContext
    {
        public calhfadatabaseContext()
        {
        }

        public calhfadatabaseContext(DbContextOptions<calhfadatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Loans> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:calhfaloans.database.windows.net,1433;Initial Catalog=calhfadatabase;Persist Security Info=True;User ID=calhfateam;Password=Calhfawebapi1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Loans>(entity =>
            {
                entity.Property(e => e.ComplianceDate).IsUnicode(false);

                entity.Property(e => e.ComplianceLoansInLine).IsUnicode(false);

                entity.Property(e => e.PostClosingDate).IsUnicode(false);

                entity.Property(e => e.PostClosingLoansInLine).IsUnicode(false);

                entity.Property(e => e.PostClosingSuspenseDate).IsUnicode(false);

                entity.Property(e => e.PostClosingSuspenseLoansInLine).IsUnicode(false);

                entity.Property(e => e.SuspenseDate).IsUnicode(false);

                entity.Property(e => e.SuspenseLoansInLine).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
