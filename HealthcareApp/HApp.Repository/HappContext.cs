namespace HApp.Repository
{
    using System;
    using HApp.Domain;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HappContext : DbContext
    {
        public HappContext()
            : base(@"Data Source=DESKTOP-TKGEU0K\BBIHH;Initial Catalog=HAppDb;Integrated Security=True")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Code>().ToTable("Code");

            modelBuilder.Entity<Session>().ToTable("Session");
            modelBuilder.Entity<Session>().Property(t => t.DID).HasColumnName("DID");
            modelBuilder.Entity<Session>().Property(t => t.PID).HasColumnName("PID");
            modelBuilder.Entity<Session>().Property(t => t.Date).HasColumnName("Date");
            //医生表的映射
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Doctor>().Property(t => t.ID).HasColumnName("DID");
            modelBuilder.Entity<Doctor>().Property(t => t.Name).HasColumnName("Dname");
            modelBuilder.Entity<Doctor>().Property(t => t.PublicKey).HasColumnName("Dpubkey");
            modelBuilder.Entity<Doctor>().Property(t => t.privateKey).HasColumnName("Dprikey");

            //EMR映射
            modelBuilder.Entity<EMR>().ToTable("EMR");
            modelBuilder.Entity<EMR>().Property(t => t.ID).HasColumnName("EMRID");
            modelBuilder.Entity<EMR>().Property(t => t.Ehistory).HasColumnName("Ehistory");
            modelBuilder.Entity<EMR>().Property(t => t.Ppubkey).HasColumnName("Ppubkey");

            //患者映射
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Patient>().Property(t => t.ID).HasColumnName("PID");
            modelBuilder.Entity<Patient>().Property(t => t.Name).HasColumnName("Pname");
            modelBuilder.Entity<Patient>().Property(t => t.PublicKey).HasColumnName("Ppubkey");
            modelBuilder.Entity<Patient>().Property(t => t.privateKey).HasColumnName("Pprikey");
            modelBuilder.Entity<Patient>().Property(t => t.SessionKey).HasColumnName("SessionKey");
            modelBuilder.Entity<Patient>().Property(t => t.EID).HasColumnName("EID");

            //查询表
            modelBuilder.Entity<Querise>().ToTable("Query");
            modelBuilder.Entity<Querise>().Property(t => t.DID).HasColumnName("DID");
            modelBuilder.Entity<Querise>().Property(t => t.EID).HasColumnName("EID");
            modelBuilder.Entity<Querise>().Property(t => t.SessionKey).HasColumnName("SessionKey");

            //医生一对多个查询

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
