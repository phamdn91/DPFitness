namespace Doug.Models
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

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Diary> Diaries { get; set; }
        public virtual DbSet<Stat> Stats { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<test>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
