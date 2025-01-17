﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyStuff.Data;
using MyStuff.Models;
using System;

namespace MyStuff.Migrations
{
    [DbContext(typeof(MyStuffdbContext))]
    [Migration("20190722195858_Project_FullDetails")]
    partial class Project_FullDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyStuff.Models.Book", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateAdded");

                    b.Property<string>("Title");

                    b.Property<string>("imageLink");

                    b.HasKey("id");

                    b.ToTable("FavoriteBooks");
                });

            modelBuilder.Entity("MyStuff.Models.Project", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullDetails");

                    b.Property<string>("GithubLink");

                    b.Property<string>("ImgURI");

                    b.Property<int>("ProgressStatus");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.Property<int>("WorkorSideProject");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MyStuff.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProjectId");

                    b.Property<string>("ProjectId1");

                    b.Property<string>("TagName");

                    b.HasKey("TagId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MyStuff.Models.Tag", b =>
                {
                    b.HasOne("MyStuff.Models.Project")
                        .WithMany("Tags")
                        .HasForeignKey("ProjectId1");
                });
#pragma warning restore 612, 618
        }
    }
}
