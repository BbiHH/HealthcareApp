namespace HApp.Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<EMR> EMR { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Session> Session { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EMR>()
                .Property(e => e.Ehistory)
                .IsUnicode(false);

            modelBuilder.Entity<EMR>()
                .HasMany(e => e.Patient)
                .WithOptional(e => e.EMR)
                .HasForeignKey(e => e.EID);
        }
    }
}
