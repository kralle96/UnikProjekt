﻿// <auto-generated />
using System;
using infrastructure.Lejemaal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace infrastructure.Migrations
{
    [DbContext(typeof(LejemaalContext))]
    partial class LejemaalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Model.Ejendom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BoligAdministrationsSelskab")
                        .HasColumnType("int");

                    b.Property<string>("OmrådeNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ejendom");
                });

            modelBuilder.Entity("Domain.Model.Inventar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("InventarType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inventar");
                });

            modelBuilder.Entity("Domain.Model.Lejemaal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EjendomId")
                        .HasColumnType("int");

                    b.Property<string>("Energimaerke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Husdyr")
                        .HasColumnType("bit");

                    b.Property<int?>("PostNrId")
                        .HasColumnType("int");

                    b.Property<bool?>("Ryger")
                        .HasColumnType("bit");

                    b.Property<int?>("SelskabId")
                        .HasColumnType("int");

                    b.Property<int>("Stoerrelse")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UdlejningsinfoId")
                        .HasColumnType("int");

                    b.Property<int>("Vaerelser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EjendomId");

                    b.HasIndex("PostNrId");

                    b.HasIndex("SelskabId");

                    b.HasIndex("UdlejningsinfoId");

                    b.ToTable("Lejemaal");
                });

            modelBuilder.Entity("Domain.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostNr")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Domain.Model.Selskab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Selskab");
                });

            modelBuilder.Entity("Domain.Model.StatistikLejeperiodeLejersAlder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AlderFra")
                        .HasColumnType("int");

                    b.Property<int>("AlderTil")
                        .HasColumnType("int");

                    b.Property<int>("BoligAdminSelskab")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatoSoegt")
                        .HasColumnType("datetime2");

                    b.Property<int>("LejeperiodeGennemsnit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StatistikLejeperiodeLejersAlder");
                });

            modelBuilder.Entity("Domain.Model.Udlejningsinfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Depositum")
                        .HasColumnType("float");

                    b.Property<bool>("Internet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LedigFra")
                        .HasColumnType("datetime2");

                    b.Property<double>("MaanedligEl")
                        .HasColumnType("float");

                    b.Property<double>("MaanedligLeje")
                        .HasColumnType("float");

                    b.Property<double>("MaanedligVand")
                        .HasColumnType("float");

                    b.Property<double>("MaanedligVarme")
                        .HasColumnType("float");

                    b.Property<DateTime>("OvertagelseFra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Udlejningsinfo");
                });

            modelBuilder.Entity("InventarLejemaal", b =>
                {
                    b.Property<int>("InventarILejemaalId")
                        .HasColumnType("int");

                    b.Property<int>("InventarILejemaalId1")
                        .HasColumnType("int");

                    b.HasKey("InventarILejemaalId", "InventarILejemaalId1");

                    b.HasIndex("InventarILejemaalId1");

                    b.ToTable("InventarLejemaal");
                });

            modelBuilder.Entity("Domain.Model.Lejemaal", b =>
                {
                    b.HasOne("Domain.Model.Ejendom", "Ejendom")
                        .WithMany("Lejemaal")
                        .HasForeignKey("EjendomId");

                    b.HasOne("Domain.Model.Post", "PostNr")
                        .WithMany("Lejemaal")
                        .HasForeignKey("PostNrId");

                    b.HasOne("Domain.Model.Selskab", "Selskab")
                        .WithMany("Lejemaal")
                        .HasForeignKey("SelskabId");

                    b.HasOne("Domain.Model.Udlejningsinfo", "Udlejningsinfo")
                        .WithMany()
                        .HasForeignKey("UdlejningsinfoId");

                    b.Navigation("Ejendom");

                    b.Navigation("PostNr");

                    b.Navigation("Selskab");

                    b.Navigation("Udlejningsinfo");
                });

            modelBuilder.Entity("InventarLejemaal", b =>
                {
                    b.HasOne("Domain.Model.Inventar", null)
                        .WithMany()
                        .HasForeignKey("InventarILejemaalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Model.Lejemaal", null)
                        .WithMany()
                        .HasForeignKey("InventarILejemaalId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Model.Ejendom", b =>
                {
                    b.Navigation("Lejemaal");
                });

            modelBuilder.Entity("Domain.Model.Post", b =>
                {
                    b.Navigation("Lejemaal");
                });

            modelBuilder.Entity("Domain.Model.Selskab", b =>
                {
                    b.Navigation("Lejemaal");
                });
#pragma warning restore 612, 618
        }
    }
}
