﻿// <auto-generated />
using GiveChange.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiveChange.Infra.Data.Migrations
{
    [DbContext(typeof(GiveChangeContext))]
    [Migration("20190820174702_AdicionandoCamposNaTabela")]
    partial class AdicionandoCamposNaTabela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GiveChange.Domain.Entities.Troco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Moeda001");

                    b.Property<int>("Moeda005");

                    b.Property<int>("Moeda010");

                    b.Property<int>("Moeda050");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Nota10");

                    b.Property<int>("Nota100");

                    b.Property<int>("Nota20");

                    b.Property<int>("Nota50");

                    b.Property<decimal>("PrecoProduto");

                    b.Property<decimal>("ValorPago");

                    b.Property<decimal>("ValorTroco");

                    b.HasKey("Id");

                    b.ToTable("Trocos");
                });
#pragma warning restore 612, 618
        }
    }
}
