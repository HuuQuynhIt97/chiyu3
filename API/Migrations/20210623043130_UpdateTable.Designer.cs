﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Chiyu.Data;

namespace Chiyu.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210623043130_UpdateTable")]
    partial class UpdateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chiyu.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsLock")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ProgressId")
                        .HasColumnType("int");

                    b.Property<string>("RoleOC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatusOC")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AccountGroupId");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("ProgressId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Chiyu.Models.AccountGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AccountGroups");
                });

            modelBuilder.Entity("Chiyu.Models.AccountGroupPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountGroupId")
                        .HasColumnType("int");

                    b.Property<int>("PeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountGroupId");

                    b.HasIndex("PeriodId");

                    b.ToTable("AccountGroupPeriods");
                });

            modelBuilder.Entity("Chiyu.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("Chiyu.Models.Attitude", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Point")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Attitudes");
                });

            modelBuilder.Entity("Chiyu.Models.AttitudeScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("PeriodTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Point")
                        .HasColumnType("float");

                    b.Property<int>("ScoreBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PeriodTypeId");

                    b.HasIndex("ScoreBy");

                    b.ToTable("AttitudeScore");
                });

            modelBuilder.Entity("Chiyu.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("PeriodTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PeriodTypeId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Chiyu.Models.Contribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("PeriodTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PeriodTypeId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("Chiyu.Models.KPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Point")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("KPIs");
                });

            modelBuilder.Entity("Chiyu.Models.KPIScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("PeriodTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Point")
                        .HasColumnType("float");

                    b.Property<int>("ScoreBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PeriodTypeId");

                    b.HasIndex("ScoreBy");

                    b.ToTable("KPIScore");
                });

            modelBuilder.Entity("Chiyu.Models.Mailing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Frequency")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Report")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("TimeSend")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Mailings");
                });

            modelBuilder.Entity("Chiyu.Models.OC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OC");
                });

            modelBuilder.Entity("Chiyu.Models.OCUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OCID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("OCUsers");
                });

            modelBuilder.Entity("Chiyu.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Topic")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("Chiyu.Models.PIC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ObjectiveId");

                    b.ToTable("PIC");
                });

            modelBuilder.Entity("Chiyu.Models.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Months")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReportTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountGroupId");

                    b.HasIndex("PeriodTypeId");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("Chiyu.Models.PeriodReportTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Months")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodId")
                        .HasColumnType("int");

                    b.Property<int>("PeriodOfYear")
                        .HasColumnType("int");

                    b.Property<int?>("PeriodTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReportTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PeriodId");

                    b.HasIndex("PeriodTypeId");

                    b.ToTable("PeriodReportTimes");
                });

            modelBuilder.Entity("Chiyu.Models.PeriodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PeriodType");
                });

            modelBuilder.Entity("Chiyu.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Topic")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Chiyu.Models.Progress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Progresses");
                });

            modelBuilder.Entity("Chiyu.Models.ResultOfMonth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.ToTable("ResultOfMonth");
                });

            modelBuilder.Entity("Chiyu.Models.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int");

                    b.Property<int?>("ProgressId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourObjective")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.HasIndex("ProgressId");

                    b.ToTable("ToDoList");
                });

            modelBuilder.Entity("Chiyu.Models.Account", b =>
                {
                    b.HasOne("Chiyu.Models.AccountGroup", "AccountGroup")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountGroupId");

                    b.HasOne("Chiyu.Models.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeId");

                    b.HasOne("Chiyu.Models.Progress", null)
                        .WithMany("Accounts")
                        .HasForeignKey("ProgressId");

                    b.Navigation("AccountGroup");

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("Chiyu.Models.AccountGroupPeriod", b =>
                {
                    b.HasOne("Chiyu.Models.AccountGroup", "AccountGroup")
                        .WithMany()
                        .HasForeignKey("AccountGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountGroup");

                    b.Navigation("Period");
                });

            modelBuilder.Entity("Chiyu.Models.AttitudeScore", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Period", "PeriodType")
                        .WithMany()
                        .HasForeignKey("PeriodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Account", "AccountScored")
                        .WithMany()
                        .HasForeignKey("ScoreBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("AccountScored");

                    b.Navigation("PeriodType");
                });

            modelBuilder.Entity("Chiyu.Models.Comment", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Period", "PeriodType")
                        .WithMany()
                        .HasForeignKey("PeriodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("PeriodType");
                });

            modelBuilder.Entity("Chiyu.Models.Contribution", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Period", "PeriodType")
                        .WithMany()
                        .HasForeignKey("PeriodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("PeriodType");
                });

            modelBuilder.Entity("Chiyu.Models.KPIScore", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Period", "PeriodType")
                        .WithMany()
                        .HasForeignKey("PeriodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Account", "AccountScore")
                        .WithMany()
                        .HasForeignKey("ScoreBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("AccountScore");

                    b.Navigation("PeriodType");
                });

            modelBuilder.Entity("Chiyu.Models.Mailing", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Chiyu.Models.Objective", b =>
                {
                    b.HasOne("Chiyu.Models.Account", null)
                        .WithMany("Objectives")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("Chiyu.Models.PIC", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Objective", "Objective")
                        .WithMany("PICs")
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Objective");
                });

            modelBuilder.Entity("Chiyu.Models.Period", b =>
                {
                    b.HasOne("Chiyu.Models.AccountGroup", null)
                        .WithMany("Periods")
                        .HasForeignKey("AccountGroupId");

                    b.HasOne("Chiyu.Models.PeriodType", "PeriodType")
                        .WithMany()
                        .HasForeignKey("PeriodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PeriodType");
                });

            modelBuilder.Entity("Chiyu.Models.PeriodReportTime", b =>
                {
                    b.HasOne("Chiyu.Models.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.PeriodType", null)
                        .WithMany("PeriodReportTimes")
                        .HasForeignKey("PeriodTypeId");

                    b.Navigation("Period");
                });

            modelBuilder.Entity("Chiyu.Models.Plan", b =>
                {
                    b.HasOne("Chiyu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Chiyu.Models.ResultOfMonth", b =>
                {
                    b.HasOne("Chiyu.Models.Objective", "Objective")
                        .WithMany("ResultOfMonth")
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");
                });

            modelBuilder.Entity("Chiyu.Models.ToDoList", b =>
                {
                    b.HasOne("Chiyu.Models.Objective", "Objective")
                        .WithMany("ToDoList")
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chiyu.Models.Progress", "Progress")
                        .WithMany()
                        .HasForeignKey("ProgressId");

                    b.Navigation("Objective");

                    b.Navigation("Progress");
                });

            modelBuilder.Entity("Chiyu.Models.Account", b =>
                {
                    b.Navigation("Objectives");
                });

            modelBuilder.Entity("Chiyu.Models.AccountGroup", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Periods");
                });

            modelBuilder.Entity("Chiyu.Models.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Chiyu.Models.Objective", b =>
                {
                    b.Navigation("PICs");

                    b.Navigation("ResultOfMonth");

                    b.Navigation("ToDoList");
                });

            modelBuilder.Entity("Chiyu.Models.PeriodType", b =>
                {
                    b.Navigation("PeriodReportTimes");
                });

            modelBuilder.Entity("Chiyu.Models.Progress", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
