﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Constantin_Mihai_Proiect.Data;

namespace Constantin_Mihai_Proiect.Migrations
{
    [DbContext(typeof(Constantin_Mihai_ProiectContext))]
    [Migration("20210102155514_LimbaStrainaVorbita")]
    partial class LimbaStrainaVorbita
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Constantin_Mihai_Proiect.Models.Angajat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAngajarii")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartamentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrTelefon")
                        .HasColumnType("int");

                    b.Property<string>("NumePrenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salariu")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("ID");

                    b.HasIndex("DepartamentID");

                    b.ToTable("Angajat");
                });

            modelBuilder.Entity("Constantin_Mihai_Proiect.Models.Departament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("Constantin_Mihai_Proiect.Models.LimbaStraina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumirea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LimbaStraina");
                });

            modelBuilder.Entity("Constantin_Mihai_Proiect.Models.LimbaStrainaVorbita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AngajatID")
                        .HasColumnType("int");

                    b.Property<int>("LimbaStrainaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AngajatID");

                    b.HasIndex("LimbaStrainaID");

                    b.ToTable("LimbaStrainaVorbita");
                });

            modelBuilder.Entity("Constantin_Mihai_Proiect.Models.Angajat", b =>
                {
                    b.HasOne("Constantin_Mihai_Proiect.Models.Departament", "Departament")
                        .WithMany("Angajati")
                        .HasForeignKey("DepartamentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Constantin_Mihai_Proiect.Models.LimbaStrainaVorbita", b =>
                {
                    b.HasOne("Constantin_Mihai_Proiect.Models.Angajat", "Angajat")
                        .WithMany("LimbiStraineVorbite")
                        .HasForeignKey("AngajatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Constantin_Mihai_Proiect.Models.LimbaStraina", "LimbaStraina")
                        .WithMany("LimbiStraineVorbite")
                        .HasForeignKey("LimbaStrainaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
