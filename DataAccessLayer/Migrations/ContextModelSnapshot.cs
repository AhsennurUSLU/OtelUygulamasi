﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Hakkimizda", b =>
                {
                    b.Property<int>("HakkimizdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HakkimizdaID"), 1L, 1);

                    b.Property<string>("HakkimizdaDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HakkimizdaDurum")
                        .HasColumnType("bit");

                    b.Property<string>("HakkimizdaGorsel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkimizdaID");

                    b.ToTable("HakkimizdaT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.IndexHakkimizda", b =>
                {
                    b.Property<int>("IndexHakkimizdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndexHakkimizdaID"), 1L, 1);

                    b.Property<string>("IndexHakkimizdaAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexHakkimizdaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IndexHakkimizdaID");

                    b.ToTable("IndexHakkimizdaT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriID"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rol")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriID");

                    b.ToTable("MusteriT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Oda", b =>
                {
                    b.Property<int>("OdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdaID"), 1L, 1);

                    b.Property<int>("GunlukFiyat")
                        .HasColumnType("int");

                    b.Property<bool>("OdaDurum")
                        .HasColumnType("bit");

                    b.Property<int>("OdaKapasite")
                        .HasColumnType("int");

                    b.Property<int>("OtelID")
                        .HasColumnType("int");

                    b.HasKey("OdaID");

                    b.ToTable("OdaT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Otel", b =>
                {
                    b.Property<int>("OtelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelID"), 1L, 1);

                    b.Property<string>("OtelAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtelAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtelBolge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OtelDurum")
                        .HasColumnType("bit");

                    b.Property<int>("OtelOdaSayisi")
                        .HasColumnType("int");

                    b.HasKey("OtelID");

                    b.ToTable("OtelT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PopulerOteller", b =>
                {
                    b.Property<int>("OtelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelID"), 1L, 1);

                    b.Property<string>("Bolge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Gorsel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sayi")
                        .HasColumnType("int");

                    b.HasKey("OtelID");

                    b.ToTable("PopulerOtellerT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervasyonID"), 1L, 1);

                    b.Property<DateTime>("DonusTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GidisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<bool>("RezervasyonDurum")
                        .HasColumnType("bit");

                    b.Property<int>("SecilenOdaOdaID")
                        .HasColumnType("int");

                    b.Property<int>("SecilenOtelOtelID")
                        .HasColumnType("int");

                    b.Property<int>("Tutar")
                        .HasColumnType("int");

                    b.HasKey("RezervasyonID");

                    b.HasIndex("MusteriID");

                    b.HasIndex("SecilenOdaOdaID");

                    b.HasIndex("SecilenOtelOtelID");

                    b.ToTable("RezervasyonT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Rezervasyon", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Musteri", "Musteri")
                        .WithMany("Rezervasyonlar")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Oda", "SecilenOda")
                        .WithMany()
                        .HasForeignKey("SecilenOdaOdaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Otel", "SecilenOtel")
                        .WithMany()
                        .HasForeignKey("SecilenOtelOtelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("SecilenOda");

                    b.Navigation("SecilenOtel");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Musteri", b =>
                {
                    b.Navigation("Rezervasyonlar");
                });
#pragma warning restore 612, 618
        }
    }
}
