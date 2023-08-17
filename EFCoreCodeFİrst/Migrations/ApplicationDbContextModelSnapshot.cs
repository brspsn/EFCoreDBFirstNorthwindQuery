﻿// <auto-generated />
using System;
using EFCoreCodeFİrst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreCodeFİrst.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreCodeFİrst.Models.Kitap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktifmi")
                        .HasColumnType("bit");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<int>("kategoriId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("kategoriId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("EFCoreCodeFİrst.Models.YayınEvi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktifmi")
                        .HasColumnType("bit");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("YayınEvleri");
                });

            modelBuilder.Entity("EFCoreCodeFİrst.Models.Yazar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktifmi")
                        .HasColumnType("bit");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ozgecmis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("EFCoreCodeFİrst.Models.kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktifmi")
                        .HasColumnType("bit");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("KitapYayınEvi", b =>
                {
                    b.Property<int>("KitaplarID")
                        .HasColumnType("int");

                    b.Property<int>("YayınEvleriID")
                        .HasColumnType("int");

                    b.HasKey("KitaplarID", "YayınEvleriID");

                    b.HasIndex("YayınEvleriID");

                    b.ToTable("KitapYayınEvi");
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.Property<int>("KitaplarID")
                        .HasColumnType("int");

                    b.Property<int>("YazarlarID")
                        .HasColumnType("int");

                    b.HasKey("KitaplarID", "YazarlarID");

                    b.HasIndex("YazarlarID");

                    b.ToTable("KitapYazar");
                });

            modelBuilder.Entity("YayınEviYazar", b =>
                {
                    b.Property<int>("YayınEvleriID")
                        .HasColumnType("int");

                    b.Property<int>("YazarlarID")
                        .HasColumnType("int");

                    b.HasKey("YayınEvleriID", "YazarlarID");

                    b.HasIndex("YazarlarID");

                    b.ToTable("YayınEviYazar");
                });

            modelBuilder.Entity("EFCoreCodeFİrst.Models.Kitap", b =>
                {
                    b.HasOne("EFCoreCodeFİrst.Models.kategori", "kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("kategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kategori");
                });

            modelBuilder.Entity("KitapYayınEvi", b =>
                {
                    b.HasOne("EFCoreCodeFİrst.Models.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodeFİrst.Models.YayınEvi", null)
                        .WithMany()
                        .HasForeignKey("YayınEvleriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.HasOne("EFCoreCodeFİrst.Models.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodeFİrst.Models.Yazar", null)
                        .WithMany()
                        .HasForeignKey("YazarlarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YayınEviYazar", b =>
                {
                    b.HasOne("EFCoreCodeFİrst.Models.YayınEvi", null)
                        .WithMany()
                        .HasForeignKey("YayınEvleriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreCodeFİrst.Models.Yazar", null)
                        .WithMany()
                        .HasForeignKey("YazarlarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreCodeFİrst.Models.kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
