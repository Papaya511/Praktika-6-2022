using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfApp16
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Departaments> Departaments { get; set; }
        public virtual DbSet<History_work> History_work { get; set; }
        public virtual DbSet<Number_units_posts> Number_units_posts { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Staffing_table> Staffing_table { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departaments>()
                .Property(e => e.departament_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.name_post)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Posts>()
                .Property(e => e.short_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Staffing_table>()
                .Property(e => e.salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Workers>()
                .Property(e => e.name_worker)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Workers>()
                .Property(e => e.surname_worker)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Workers>()
                .Property(e => e.patronymic)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Workers>()
                .Property(e => e.family_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Workers>()
                .Property(e => e.gender)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
