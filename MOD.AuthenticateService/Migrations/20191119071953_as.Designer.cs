﻿// <auto-generated />
using MOD.AuthenticateService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.AuthenticateService.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20191119071953_as")]
    partial class @as
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.AuthenticateService.Models.Mentor", b =>
                {
                    b.Property<int>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Mactive")
                        .HasColumnType("bit");

                    b.Property<bool>("Mavailability")
                        .HasColumnType("bit");

                    b.Property<int>("Mexperience")
                        .HasColumnType("int");

                    b.Property<string>("Mmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mnumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Mpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mskills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mtimeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mid");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.User", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Uactive")
                        .HasColumnType("bit");

                    b.Property<string>("Umail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Unumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Upassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}