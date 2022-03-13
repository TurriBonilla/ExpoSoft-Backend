﻿// <auto-generated />
using System;
using ExpoSoft.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpoSoft.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ExpoSoftContext))]
    [Migration("20220313032942_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("ExpoSoft.Domain.Entities.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Landline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nit")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerlastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Town")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeOfBusiness")
                        .HasColumnType("TEXT");

                    b.Property<string>("YearOfConstitution")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ScoreId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("ExpoSoft.Domain.Entities.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("ActivityPerception")
                        .HasColumnType("REAL");

                    b.Property<float>("CompetitiveFactor")
                        .HasColumnType("REAL");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<float>("ExportIntention")
                        .HasColumnType("REAL");

                    b.Property<float>("FutureExperience")
                        .HasColumnType("REAL");

                    b.Property<float>("IncreaseFactor")
                        .HasColumnType("REAL");

                    b.Property<float>("InternationalExperience")
                        .HasColumnType("REAL");

                    b.Property<float>("ManagerProfile")
                        .HasColumnType("REAL");

                    b.Property<float>("NationalSales")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("TEXT");

                    b.Property<float>("TotalScore")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Scores");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Score");
                });

            modelBuilder.Entity("ExpoSoft.Domain.Entities.HistoricalScore", b =>
                {
                    b.HasBaseType("ExpoSoft.Domain.Entities.Score");

                    b.Property<int?>("BusinessId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("BusinessId");

                    b.HasDiscriminator().HasValue("HistoricalScore");
                });

            modelBuilder.Entity("ExpoSoft.Domain.Entities.Business", b =>
                {
                    b.HasOne("ExpoSoft.Domain.Entities.Score", "Score")
                        .WithMany()
                        .HasForeignKey("ScoreId");

                    b.Navigation("Score");
                });

            modelBuilder.Entity("ExpoSoft.Domain.Entities.HistoricalScore", b =>
                {
                    b.HasOne("ExpoSoft.Domain.Entities.Business", null)
                        .WithMany("HistoricalScores")
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("ExpoSoft.Domain.Entities.Business", b =>
                {
                    b.Navigation("HistoricalScores");
                });
#pragma warning restore 612, 618
        }
    }
}
