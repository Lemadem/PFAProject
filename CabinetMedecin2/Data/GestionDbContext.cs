using CabinetMedecin2.Controllers;
using CabinetMedecin2.Models;
using Microsoft.EntityFrameworkCore;

namespace CabinetMedecin.Data
{
    public class GestionDbContext : DbContext
    {
        public GestionDbContext(DbContextOptions<GestionDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabinetMedical>().HasKey(c => c.id_cabinet);
            modelBuilder.Entity<Patient>().HasKey(p => p.id_patient);
            modelBuilder.Entity<RendezVous>().HasKey(r => r.id_rendezvous);
            modelBuilder.Entity<ExamenMedical>().HasKey(e => e.id_examen);
            modelBuilder.Entity<Procedure>().HasKey(p => p.id_proceure);
            modelBuilder.Entity<DossierPatient>().HasKey(d => d.id_dossier);
            modelBuilder.Entity<Facture>().HasKey(f => f.id_facture);
            modelBuilder.Entity<Paiement>().HasKey(p => p.id_paiement);
            modelBuilder.Entity<PersonnelMedical>().HasKey(p => p.id_personnelmedical);
            modelBuilder.Entity<Medecin>().HasKey(p => p.MedecinId);
            modelBuilder.Entity<Assistante>().HasKey(p => p.AssistantId);
            modelBuilder.Entity<User>().HasKey(c => c.Id);

            modelBuilder.Entity<ServiceMedical>().HasKey(p => p.id_service);


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
               .HasDiscriminator<string>("Role")
               .HasValue<Patient>("patient")
               .HasValue<Medecin>("medecin")
               .HasValue<Assistante>("assistant");


        }

       
        
        public DbSet<User> Users { get; set; }
        public DbSet<CabinetMedical> CabinetsMedicaux { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<ExamenMedical> ExamensMedicaux { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<DossierPatient> DossiersPatients { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<ServiceMedical> ServiceMedical { get; set; }
        public DbSet<PersonnelMedical> PersonnelMedical { get; set; }
        public DbSet<Medecin> Medecin { get; set; }
        public DbSet<Assistante> Assistante { get; set; }
    }
}
