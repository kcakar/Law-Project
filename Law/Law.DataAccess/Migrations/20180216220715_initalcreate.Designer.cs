﻿// <auto-generated />
using Law.DataAccess;
using Law.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Law.DataAccess.Migrations
{
    [DbContext(typeof(LawContext))]
    [Migration("20180216220715_initalcreate")]
    partial class initalcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Law.Models.Article", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AffiliateID");

                    b.Property<string>("BodyPreview");

                    b.Property<string>("CityID");

                    b.Property<string>("ContributorID");

                    b.Property<string>("CountryID");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("LanguageID");

                    b.Property<string>("PracticeAreaID");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<int>("ViewCount");

                    b.HasKey("ID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Law.Models.ArticlePiece", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArticleId");

                    b.Property<int>("ImagePosition");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Paragraph");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("ArticlePieces");
                });

            modelBuilder.Entity("Law.Models.NameBase", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("NameBases");

                    b.HasDiscriminator<string>("Discriminator").HasValue("NameBase");
                });

            modelBuilder.Entity("Law.Models.Affiliate", b =>
                {
                    b.HasBaseType("Law.Models.NameBase");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.ToTable("Affiliate");

                    b.HasDiscriminator().HasValue("Affiliate");
                });

            modelBuilder.Entity("Law.Models.City", b =>
                {
                    b.HasBaseType("Law.Models.NameBase");

                    b.Property<string>("CountryID");

                    b.ToTable("City");

                    b.HasDiscriminator().HasValue("City");
                });

            modelBuilder.Entity("Law.Models.Contributor", b =>
                {
                    b.HasBaseType("Law.Models.NameBase");

                    b.Property<string>("AffiliateID");

                    b.Property<string>("Bio");

                    b.Property<string>("CityID");

                    b.Property<string>("CountryID")
                        .HasColumnName("Contributor_CountryID");

                    b.Property<string>("Email");

                    b.Property<string>("ImageURL")
                        .HasColumnName("Contributor_ImageURL");

                    b.Property<DateTime>("LastPostDate");

                    b.Property<int>("TotalContributions");

                    b.ToTable("Contributor");

                    b.HasDiscriminator().HasValue("Contributor");
                });

            modelBuilder.Entity("Law.Models.Country", b =>
                {
                    b.HasBaseType("Law.Models.NameBase");


                    b.ToTable("Country");

                    b.HasDiscriminator().HasValue("Country");
                });

            modelBuilder.Entity("Law.Models.PracticeArea", b =>
                {
                    b.HasBaseType("Law.Models.NameBase");


                    b.ToTable("PracticeArea");

                    b.HasDiscriminator().HasValue("PracticeArea");
                });

            modelBuilder.Entity("Law.Models.User", b =>
                {
                    b.HasBaseType("Law.Models.NameBase");

                    b.Property<int>("CommentCount");

                    b.Property<string>("Email")
                        .HasColumnName("User_Email");

                    b.Property<string>("Password");

                    b.ToTable("User");

                    b.HasDiscriminator().HasValue("User");
                });
#pragma warning restore 612, 618
        }
    }
}
