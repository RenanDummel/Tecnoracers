using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bancoapi.Database
{
    public class Context : DbContext
    {
        public virtual DbSet<Equipe> Equipe { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if(!builder.IsConfigured)
            {
                builder.UseMySQL("Server=localhost;Port=3306;User=root;Password=;Database=tecnoracers;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Equipe>().ToTable("equipes");
            builder.Entity<Equipe>(entity => {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();
            });
        }
    }
}