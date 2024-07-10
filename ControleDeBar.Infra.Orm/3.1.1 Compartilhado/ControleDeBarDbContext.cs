using Microsoft.EntityFrameworkCore;
using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.Dominio._2._7_ModuloProduto;
using ControleDeBar.Dominio._2._3_ModuloConta;
using ControleDeBar.Dominio._2._5_ModuloMesa;

namespace ControleDeBar.Infra.Orm._3._1._1_Compartilhado
{
    public class ControleDeBarDbContext : DbContext
    {
        public DbSet<Garcom> Garcons { get; internal set; }
        public DbSet<Produto> Produtos { get; internal set; }
        public DbSet<Pedido> Pedidos { get; internal set; }
        public DbSet<Mesa> Mesas { get; internal set; }
        public DbSet<Conta> Contas { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
               "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ControleDeBarOrm;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garcom>(garcomBuilder =>
            {
                garcomBuilder.ToTable("TBGarcom");

                garcomBuilder.Property(g => g.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                garcomBuilder.Property(g => g.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(p => p.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                produtoBuilder.Property(p => p.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                produtoBuilder.Property(p => p.Preco)
                    .IsRequired()
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Pedido>(pedidoBuilder =>
            {
                pedidoBuilder.ToTable("TBPedido");

                pedidoBuilder.Property(p => p.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                pedidoBuilder.Property(p => p.Valor)
                    .IsRequired()
                    .HasColumnType("decimal(18, 0)");

                pedidoBuilder.Property(p => p.Quantidade)
                    .IsRequired()
                    .HasColumnType("decimal(18, 0)");

                pedidoBuilder.HasOne(p => p.Garcom)
                    .WithMany()
                    .IsRequired()
                    .HasForeignKey("Garcom_Id")
                    .HasConstraintName("FK_TBPedido_TBGarcom");

                pedidoBuilder.HasOne(p => p.Produto)
                    .WithMany()
                    .IsRequired()
                    .HasForeignKey("Produto_Id")
                    .HasConstraintName("FK_TBPedido_TBProduto")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(m => m.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                mesaBuilder.Property(m => m.Numero)
                    .IsRequired()
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Conta>(contaBuilder =>
            {
                contaBuilder.ToTable("TBConta");

                contaBuilder.Property(c => c.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                contaBuilder.Property(m => m.ValorTotal)
                    .IsRequired()
                    .HasColumnType("decimal(18, 0)");

                contaBuilder.Property(c => c.EmAberto).IsRequired();

                contaBuilder.Property(c => c.Data).IsRequired();

                contaBuilder.HasMany(c => c.Pedidos)
                    .WithMany()
                    .UsingEntity(x => x.ToTable("TBConta_TBPedido"));

                contaBuilder.HasOne(p => p.Mesa)
                    .WithMany()
                    .IsRequired()
                    .HasForeignKey("Mesa_Id")
                    .HasConstraintName("FK_TBConta_TBMesa")
                    .OnDelete(DeleteBehavior.Restrict);

                contaBuilder.HasOne(p => p.Garcom)
                    .WithMany()
                    .IsRequired()
                    .HasForeignKey("Garcom_Id")
                    .HasConstraintName("FK_TBConta_TBGarcom")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
