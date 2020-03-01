﻿// <auto-generated />
using BlogProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogProject.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20200228195443_NewBlogCategories")]
    partial class NewBlogCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogProject.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "/img/dreaming.jpg",
                            Name = "Dream Log"
                        },
                        new
                        {
                            Id = 2,
                            Image = "/img/zipline.jpg",
                            Name = "Meditation"
                        },
                        new
                        {
                            Id = 3,
                            Image = "/img/lizard.jpg",
                            Name = "Yoga"
                        });
                });

            modelBuilder.Entity("BlogProject.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublishDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Josh",
                            BlogId = 1,
                            Body = "There was a duck. It was weird.",
                            PublishDate = "2/20/2020",
                            Title = "That one time with the duck"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Johnny",
                            BlogId = 2,
                            Body = "I recommend amethyst for your salt baths to add positive energy to your relaxation experience.",
                            PublishDate = "12/20/2020",
                            Title = "My Collection of Crystals"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Juniper",
                            BlogId = 3,
                            Body = "Come to my yoga classes on wednesdays at 3 pm!",
                            PublishDate = "2/4/2018",
                            Title = "Want to step into the world of yoga?"
                        });
                });

            modelBuilder.Entity("BlogProject.Models.Post", b =>
                {
                    b.HasOne("BlogProject.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}