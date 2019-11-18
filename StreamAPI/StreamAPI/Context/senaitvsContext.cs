﻿using Microsoft.EntityFrameworkCore;

namespace StreamAPI.Models
{
    public partial class SenaitvsContext : DbContext
    {
        public SenaitvsContext()
        {
        }

        public SenaitvsContext(DbContextOptions<SenaitvsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Televisoes> Televisoes { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=db4free.net;Database=senaitvs;Uid=senaitvs;Pwd=1234abcd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Instituicao)
                    .HasColumnName("instituicao")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Responsavel)
                    .HasColumnName("responsavel")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Televisoes>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("codigo")
                    .IsUnique();

                entity.HasIndex(e => e.FkIdCliente)
                    .HasName("fk_id_cliente");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.FkIdCliente)
                    .HasColumnName("fk_id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modificado).HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.FkIdClienteNavigation)
                    .WithMany(p => p.Televisoes)
                    .HasForeignKey(d => d.FkIdCliente)
                    .HasConstraintName("fk_id_cliente");
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.HasIndex(e => e.FkIdTelevisao)
                    .HasName("fk_id_televisao");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkIdTelevisao)
                    .HasColumnName("fk_id_televisao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.FkIdTelevisaoNavigation)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.FkIdTelevisao)
                    .HasConstraintName("fk_id_televisao");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}