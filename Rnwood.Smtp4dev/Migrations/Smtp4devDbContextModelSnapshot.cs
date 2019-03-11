﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rnwood.Smtp4dev.DbModel;

namespace Rnwood.Smtp4dev.Migrations
{
    [DbContext(typeof(Smtp4devDbContext))]
    partial class Smtp4devDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttachmentCount");

                    b.Property<byte[]>("Data");

                    b.Property<string>("From");

                    b.Property<bool>("IsUnread");

                    b.Property<string>("MimeParseError");

                    b.Property<DateTime>("ReceivedDate");

                    b.Property<Guid?>("SessionId");

                    b.Property<string>("Subject");

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientAddress");

                    b.Property<string>("ClientName");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Log");

                    b.Property<int>("NumberOfMessages");

                    b.Property<string>("SessionError");

                    b.Property<int?>("SessionErrorType");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Message", b =>
                {
                    b.HasOne("Rnwood.Smtp4dev.DbModel.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId");
                });
#pragma warning restore 612, 618
        }
    }
}