﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeComandas.BancoDeDados;

#nullable disable

namespace SistemaDeComandas.Migrations
{
    [DbContext(typeof(ComandaContexto))]
    partial class ComandaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("SistemaDeComandas.Modelos.CardapioItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("PossuiPreparo")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("NUMERIC");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CardapioItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroMesa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoComanda")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Comandas");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.ComandaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardapioItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComandaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardapioItemId");

                    b.ToTable("ComandaItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroMesa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoMesa")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.PedidoCozinha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComandaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PedidoCozinhas");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.PedidoCozinhaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComandaItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PedidoCozinhaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComandaItemId");

                    b.HasIndex("PedidoCozinhaId");

                    b.ToTable("PedidoCozinhaItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.ComandaItem", b =>
                {
                    b.HasOne("SistemaDeComandas.Modelos.CardapioItem", "CardapioItem")
                        .WithMany()
                        .HasForeignKey("CardapioItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeComandas.Modelos.Comanda", "Comanda")
                        .WithMany("ComandaItems")
                        .HasForeignKey("CardapioItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardapioItem");

                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.PedidoCozinhaItem", b =>
                {
                    b.HasOne("SistemaDeComandas.Modelos.ComandaItem", "ComandaItem")
                        .WithMany()
                        .HasForeignKey("ComandaItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeComandas.Modelos.PedidoCozinha", "PedidoCozinha")
                        .WithMany("PedidoCozinhaItems")
                        .HasForeignKey("PedidoCozinhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComandaItem");

                    b.Navigation("PedidoCozinha");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Comanda", b =>
                {
                    b.Navigation("ComandaItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.PedidoCozinha", b =>
                {
                    b.Navigation("PedidoCozinhaItems");
                });
#pragma warning restore 612, 618
        }
    }
}
