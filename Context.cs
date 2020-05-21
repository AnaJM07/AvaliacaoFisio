namespace FisioForms
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Adm_Cervical> Adm_Cervical { get; set; }
        public virtual DbSet<Adm_Cotovelo> Adm_Cotovelo { get; set; }
        public virtual DbSet<Adm_Punho> Adm_Punho { get; set; }
        public virtual DbSet<Adm_Tronco> Adm_Tronco { get; set; }
        public virtual DbSet<Joelho> Joelho { get; set; }
        public virtual DbSet<Ombro> Ombro { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Pe> Pe { get; set; }
        public virtual DbSet<Quadril> Quadril { get; set; }
        public virtual DbSet<Tornozelo> Tornozelo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>()
                .Property(e => e.hma)
                .IsUnicode(false);
        }
    }
}
