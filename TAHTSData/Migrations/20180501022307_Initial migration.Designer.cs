﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TAHTSData;

namespace TAHTSData.Migrations
{
    [DbContext(typeof(TahtsContext))]
    [Migration("20180501022307_Initial migration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TAHTSData.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EventCreatedDateTime");

                    b.Property<DateTime>("EventEndDate");

                    b.Property<DateTime>("EventModifiedDateTime");

                    b.Property<string>("EventName");

                    b.Property<string>("EventOwner");

                    b.Property<DateTime>("EventStartDate");

                    b.Property<bool>("EventStatud");

                    b.HasKey("EventID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TAHTSData.Models.RegisteredUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcceptTerm");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DBlood");

                    b.Property<DateTime>("DateofBirth");

                    b.Property<string>("Email");

                    b.Property<int>("EventId");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LCpr");

                    b.Property<string>("LastName");

                    b.Property<int>("MType");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PDFLink");

                    b.Property<int>("Phone");

                    b.Property<string>("RegisterId");

                    b.Property<string>("State");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("RegisteredUsers");
                });

            modelBuilder.Entity("TAHTSData.Models.RegisteredUser", b =>
                {
                    b.HasOne("TAHTSData.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
