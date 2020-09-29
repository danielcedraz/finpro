﻿// <auto-generated />
using System;
using FinanciamentoProjetos.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinPro.Web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200929090801_AddBudgetValueField")]
    partial class AddBudgetValueField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FinanciamentoProjetos.Domain.Entities.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DesignerAmount")
                        .HasColumnType("int");

                    b.Property<int>("DurationDays")
                        .HasColumnType("int");

                    b.Property<int>("FullStackAmount")
                        .HasColumnType("int");

                    b.Property<int>("IdCustomer")
                        .HasColumnName("Customer")
                        .HasColumnType("int");

                    b.Property<int>("ProjectOwnerAmount")
                        .HasColumnType("int");

                    b.Property<int>("ScrumMasterAmount")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.ToTable("Budget");
                });

            modelBuilder.Entity("FinanciamentoProjetos.Domain.Entities.State", b =>
                {
                    b.Property<string>("UF")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UF");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            UF = "AC",
                            Name = "Acre"
                        },
                        new
                        {
                            UF = "AL",
                            Name = "Alagoas"
                        },
                        new
                        {
                            UF = "AP",
                            Name = "Amapá"
                        },
                        new
                        {
                            UF = "AM",
                            Name = "Amazonas"
                        },
                        new
                        {
                            UF = "BA",
                            Name = "Bahia"
                        },
                        new
                        {
                            UF = "CE",
                            Name = "Ceará"
                        },
                        new
                        {
                            UF = "DF",
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            UF = "ES",
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            UF = "GO",
                            Name = "Coiás"
                        },
                        new
                        {
                            UF = "MA",
                            Name = "Maranhão"
                        },
                        new
                        {
                            UF = "MT",
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            UF = "MS",
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            UF = "MG",
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            UF = "PA",
                            Name = "Pará"
                        },
                        new
                        {
                            UF = "PB",
                            Name = "Paraíba"
                        },
                        new
                        {
                            UF = "PR",
                            Name = "Paraná"
                        },
                        new
                        {
                            UF = "PE",
                            Name = "Pernambuco"
                        },
                        new
                        {
                            UF = "PI",
                            Name = "Piauí"
                        },
                        new
                        {
                            UF = "RJ",
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            UF = "RN",
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            UF = "RS",
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            UF = "RO",
                            Name = "Rondônia"
                        },
                        new
                        {
                            UF = "RR",
                            Name = "Roraima"
                        },
                        new
                        {
                            UF = "SC",
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            UF = "SP",
                            Name = "São Paulo"
                        },
                        new
                        {
                            UF = "SE",
                            Name = "Sergipe"
                        },
                        new
                        {
                            UF = "TO",
                            Name = "Tocantins"
                        });
                });

            modelBuilder.Entity("FinanciamentoProjetos.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("AddressCity")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressComplement")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressNumber")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("CEP")
                        .HasColumnType("int")
                        .HasMaxLength(8);

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint")
                        .HasMaxLength(14);

                    b.Property<long>("CPF")
                        .HasColumnType("bigint")
                        .HasMaxLength(11);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("IdAddressState")
                        .IsRequired()
                        .HasColumnName("AddressState")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdAddressState");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FinanciamentoProjetos.Domain.Entities.Budget", b =>
                {
                    b.HasOne("FinanciamentoProjetos.Domain.Entities.User", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinanciamentoProjetos.Domain.Entities.User", b =>
                {
                    b.HasOne("FinanciamentoProjetos.Domain.Entities.State", "AddressState")
                        .WithMany()
                        .HasForeignKey("IdAddressState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
