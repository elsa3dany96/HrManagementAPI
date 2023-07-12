﻿// <auto-generated />
using System;
using HrManagement.EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HrManagement.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230706015739_Three")]
    partial class Three
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HrManagement.Core.Models.ComeLate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateComeIn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MasterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Request")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ComeLates");
                });

            modelBuilder.Entity("HrManagement.Core.Models.DisRegister", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DisRegisters");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Disattend", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MasterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Request")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Disattends");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Discount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DiscountCost")
                        .HasColumnType("float");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Firedate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("HiredDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("IDImg")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("IDPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MasterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("fingerprint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HrManagement.Core.Models.ExtraTime", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Hours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Request")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ExtraTimes");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Ponus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("PonusCost")
                        .HasColumnType("float");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Ponus");
                });

            modelBuilder.Entity("HrManagement.Core.Models.WentEarly", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateWent")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MasterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rquest")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WentEarlys");
                });

            modelBuilder.Entity("HrManagement.Core.Models.ComeLate", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("ComeLate")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.DisRegister", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("DisRegister")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Disattend", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("Disattend")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Discount", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("Discount")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.ExtraTime", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("ExtraTime")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Ponus", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("Ponus")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.WentEarly", b =>
                {
                    b.HasOne("HrManagement.Core.Models.Employee", "Employee")
                        .WithMany("WentEarly")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HrManagement.Core.Models.Employee", b =>
                {
                    b.Navigation("ComeLate");

                    b.Navigation("DisRegister");

                    b.Navigation("Disattend");

                    b.Navigation("Discount");

                    b.Navigation("ExtraTime");

                    b.Navigation("Ponus");

                    b.Navigation("WentEarly");
                });
#pragma warning restore 612, 618
        }
    }
}
