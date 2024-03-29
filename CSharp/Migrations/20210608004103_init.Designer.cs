﻿// <auto-generated />
using System;
using CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharp.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20210608004103_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSharp.Entities.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("CSharp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmailId")
                        .HasColumnType("int");

                    b.Property<string>("InviteCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvitedById")
                        .HasColumnType("int");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("UserName");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime")
                        .IsUnique()
                        .HasFilter("[CreateTime] IS NOT NULL");

                    b.HasIndex("EmailId")
                        .IsUnique();

                    b.HasIndex("InvitedById");

                    b.ToTable("Register");

                    b.HasCheckConstraint("CK_CreateTime", "CreateTime>='2000/1/1'");
                });

            modelBuilder.Entity("CSharp.Entities.User", b =>
                {
                    b.HasOne("CSharp.Entities.Email", "Email")
                        .WithOne("Owner")
                        .HasForeignKey("CSharp.Entities.User", "EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp.Entities.User", "InvitedBy")
                        .WithMany()
                        .HasForeignKey("InvitedById");

                    b.Navigation("Email");

                    b.Navigation("InvitedBy");
                });

            modelBuilder.Entity("CSharp.Entities.Email", b =>
                {
                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
