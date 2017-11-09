﻿// <auto-generated />
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Data.Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20171109173732_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Domain.Entities.StockModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StockModels");
                });

            modelBuilder.Entity("Data.Domain.Entities.StockRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<double>("EndPrice");

                    b.Property<double>("StartPrice");

                    b.Property<Guid?>("StockModelId");

                    b.HasKey("Id");

                    b.HasIndex("StockModelId");

                    b.ToTable("StockRecords");
                });

            modelBuilder.Entity("Data.Domain.Entities.StockRecord", b =>
                {
                    b.HasOne("Data.Domain.Entities.StockModel")
                        .WithMany("StockRecords")
                        .HasForeignKey("StockModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
