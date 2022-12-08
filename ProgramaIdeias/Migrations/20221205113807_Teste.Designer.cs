﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramaIdeias.Models;

#nullable disable

namespace ProgramaIdeias.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221205113807_Teste")]
    partial class Teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProgramaIdeias.Models.EquipeIdeia", b =>
                {
                    b.Property<int>("IDEquipeIdeia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDEquipeIdeia"));

                    b.Property<int>("IDFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IDIdeia")
                        .HasColumnType("int");

                    b.HasKey("IDEquipeIdeia");

                    b.HasIndex("IDFuncionario");

                    b.HasIndex("IDIdeia");

                    b.ToTable("EquipeIdeia");
                });

            modelBuilder.Entity("ProgramaIdeias.Models.Funcionario", b =>
                {
                    b.Property<int>("IDFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDFuncionario"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("ProgramaIdeias.Models.Ideia", b =>
                {
                    b.Property<int>("IDIdeia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDIdeia"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoGanho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Ganho")
                        .HasColumnType("real");

                    b.Property<float>("Investimento")
                        .HasColumnType("real");

                    b.Property<string>("NomeEquipe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDIdeia");

                    b.ToTable("Ideia");
                });

            modelBuilder.Entity("ProgramaIdeias.Models.EquipeIdeia", b =>
                {
                    b.HasOne("ProgramaIdeias.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("IDFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgramaIdeias.Models.Ideia", "Ideia")
                        .WithMany("EquipeIdeia")
                        .HasForeignKey("IDIdeia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Ideia");
                });

            modelBuilder.Entity("ProgramaIdeias.Models.Ideia", b =>
                {
                    b.Navigation("EquipeIdeia");
                });
#pragma warning restore 612, 618
        }
    }
}
