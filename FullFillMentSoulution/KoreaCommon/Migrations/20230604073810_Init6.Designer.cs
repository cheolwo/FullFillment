﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using 수협Common.Model;

#nullable disable

namespace KoreaCommon.Migrations
{
    [DbContext(typeof(수협DbContext))]
    [Migration("20230604073810_Init6")]
    partial class Init6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KoreaCommon.Model.수산창고", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Address")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("FaxNumber")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.Property<string>("수협Id")
                        .HasColumnType("varchar(128)");

                    b.HasKey("Code");

                    b.HasIndex("수협Id");

                    b.ToTable("수산창고");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산품", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Code")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("수협Id")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("창고Id")
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("수협Id");

                    b.HasIndex("창고Id");

                    b.ToTable("수산품");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산품별재고현황", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Code")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("date")
                        .HasColumnType("longtext");

                    b.Property<string>("수산품Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("수협Id")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("창고Id")
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("수산품Id");

                    b.HasIndex("수협Id");

                    b.HasIndex("창고Id");

                    b.ToTable("수산품별재고현황");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산협동조합", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Address")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("FaxNumber")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("Code");

                    b.ToTable("수산협동조합");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산창고", b =>
                {
                    b.HasOne("KoreaCommon.Model.수산협동조합", "수협")
                        .WithMany("창고들")
                        .HasForeignKey("수협Id");

                    b.Navigation("수협");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산품", b =>
                {
                    b.HasOne("KoreaCommon.Model.수산협동조합", "수협")
                        .WithMany("수산품들")
                        .HasForeignKey("수협Id");

                    b.HasOne("KoreaCommon.Model.수산창고", "창고")
                        .WithMany("수산품들")
                        .HasForeignKey("창고Id");

                    b.Navigation("수협");

                    b.Navigation("창고");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산품별재고현황", b =>
                {
                    b.HasOne("KoreaCommon.Model.수산품", "수산품")
                        .WithMany("수산품별재고현황들")
                        .HasForeignKey("수산품Id");

                    b.HasOne("KoreaCommon.Model.수산협동조합", "수협")
                        .WithMany("수산품별재고현황들")
                        .HasForeignKey("수협Id");

                    b.HasOne("KoreaCommon.Model.수산창고", "창고")
                        .WithMany("수산품별재고현황들")
                        .HasForeignKey("창고Id");

                    b.Navigation("수산품");

                    b.Navigation("수협");

                    b.Navigation("창고");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산창고", b =>
                {
                    b.Navigation("수산품들");

                    b.Navigation("수산품별재고현황들");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산품", b =>
                {
                    b.Navigation("수산품별재고현황들");
                });

            modelBuilder.Entity("KoreaCommon.Model.수산협동조합", b =>
                {
                    b.Navigation("수산품들");

                    b.Navigation("수산품별재고현황들");

                    b.Navigation("창고들");
                });
#pragma warning restore 612, 618
        }
    }
}
