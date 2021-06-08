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
    [Migration("20210607123321_AddtablePbAtSg")]
    partial class AddtablePbAtSg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticleKeyword", b =>
                {
                    b.Property<int>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int>("keywordsId")
                        .HasColumnType("int");

                    b.HasKey("ArticlesId", "keywordsId");

                    b.HasIndex("keywordsId");

                    b.ToTable("ArticleKeyword");
                });

            modelBuilder.Entity("CSharp.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Contents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Content");
                });

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

            modelBuilder.Entity("CSharp.Entities.Keyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Keyword");
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

                    b.Property<int?>("EmailId1")
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

                    b.HasIndex("EmailId1")
                        .IsUnique()
                        .HasFilter("[EmailId1] IS NOT NULL");

                    b.HasIndex("InvitedById");

                    b.ToTable("Register");

                    b.HasCheckConstraint("CK_CreateTime", "CreateTime>='2000/1/1'");
                });

            modelBuilder.Entity("KeywordProblem", b =>
                {
                    b.Property<int>("KeywordsId")
                        .HasColumnType("int");

                    b.Property<int>("ProblemsId")
                        .HasColumnType("int");

                    b.HasKey("KeywordsId", "ProblemsId");

                    b.HasIndex("ProblemsId");

                    b.ToTable("KeywordProblem");
                });

            modelBuilder.Entity("CSharp.Appraise", b =>
                {
                    b.HasBaseType("CSharp.Content");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int")
                        .HasColumnName("Appraise_ArticleId");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CommentId");

                    b.HasDiscriminator().HasValue("Appraise");
                });

            modelBuilder.Entity("CSharp.Comment", b =>
                {
                    b.HasBaseType("CSharp.Content");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("ProblemId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ProblemId");

                    b.HasDiscriminator().HasValue("Comment");
                });

            modelBuilder.Entity("CSharp.Entities.Article", b =>
                {
                    b.HasBaseType("CSharp.Content");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Article_Title");

                    b.HasDiscriminator().HasValue("Article");
                });

            modelBuilder.Entity("CSharp.Problem", b =>
                {
                    b.HasBaseType("CSharp.Content");

                    b.Property<DateTime>("PublishDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Problem_Title");

                    b.HasDiscriminator().HasValue("Problem");
                });

            modelBuilder.Entity("CSharp.Suggest", b =>
                {
                    b.HasBaseType("CSharp.Content");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Suggest_Title");

                    b.HasDiscriminator().HasValue("Suggest");
                });

            modelBuilder.Entity("ArticleKeyword", b =>
                {
                    b.HasOne("CSharp.Entities.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp.Entities.Keyword", null)
                        .WithMany()
                        .HasForeignKey("keywordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CSharp.Content", b =>
                {
                    b.HasOne("CSharp.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("CSharp.Entities.User", b =>
                {
                    b.HasOne("CSharp.Entities.Email", "Email")
                        .WithOne()
                        .HasForeignKey("CSharp.Entities.User", "EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp.Entities.Email", null)
                        .WithOne("Owner")
                        .HasForeignKey("CSharp.Entities.User", "EmailId1");

                    b.HasOne("CSharp.Entities.User", "InvitedBy")
                        .WithMany()
                        .HasForeignKey("InvitedById");

                    b.Navigation("Email");

                    b.Navigation("InvitedBy");
                });

            modelBuilder.Entity("KeywordProblem", b =>
                {
                    b.HasOne("CSharp.Entities.Keyword", null)
                        .WithMany()
                        .HasForeignKey("KeywordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp.Problem", null)
                        .WithMany()
                        .HasForeignKey("ProblemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CSharp.Appraise", b =>
                {
                    b.HasOne("CSharp.Entities.Article", "Article")
                        .WithMany("Appraises")
                        .HasForeignKey("ArticleId");

                    b.HasOne("CSharp.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId");

                    b.Navigation("Article");

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("CSharp.Comment", b =>
                {
                    b.HasOne("CSharp.Entities.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");

                    b.HasOne("CSharp.Problem", null)
                        .WithMany("Comments")
                        .HasForeignKey("ProblemId");

                    b.Navigation("Article");
                });

            modelBuilder.Entity("CSharp.Entities.Email", b =>
                {
                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CSharp.Entities.Article", b =>
                {
                    b.Navigation("Appraises");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CSharp.Problem", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
