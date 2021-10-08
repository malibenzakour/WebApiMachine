using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApiMachine.Models;

#nullable disable

namespace WebApiMachine.Context
{
    public partial class ArticleContext : DbContext
    {
        public ArticleContext()
        {
        }

        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }

        public virtual DbSet<Historique> Historiques { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("article");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cl).HasColumnName("cl");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code_postal");

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.Prix)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prix");

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.Property(e => e.TypeArticle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("typeArticle");

                entity.Property(e => e.UrlImage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urlImage");
            });
            modelBuilder.Entity<Historique>(entity =>
            {
                entity.HasKey(e => e.IdArticle);
                entity.ToTable("historique");

                entity.Property(e => e.DateAchat)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAchat");

                entity.Property(e => e.IdArticle).HasColumnName("id_Article");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
