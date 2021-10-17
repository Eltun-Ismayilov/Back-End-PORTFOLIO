﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.WebUI.Model.DataContexts;

namespace Portfolio.WebUI.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    partial class PortfolioDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Bios");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePati")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShopDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnswerByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AnswerdData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkForDiplom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occoption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeInterval")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeInterval")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Icons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("Icons");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.PersonalDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CareerLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonalDetailss");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteData")
                        .HasColumnType("datetime2");

                    b.Property<string>("SkillDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillPercentage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isHardSkill")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Icons", b =>
                {
                    b.HasOne("Portfolio.WebUI.Model.Entity.Services", "Service")
                        .WithMany("Icons")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Portfolio.WebUI.Model.Entity.Services", b =>
                {
                    b.Navigation("Icons");
                });
#pragma warning restore 612, 618
        }
    }
}
