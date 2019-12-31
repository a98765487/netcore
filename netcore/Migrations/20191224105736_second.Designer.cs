﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netcore.Models;

namespace netcore.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20191224105736_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("netcore.Models.Product", b =>
                {
                    b.Property<string>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(20)");

                    b.Property<string>("Cdt")
                        .IsRequired()
                        .HasColumnType("char(14)");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Mdt")
                        .IsRequired()
                        .HasColumnType("char(14)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Price");

                    b.HasKey("SId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
