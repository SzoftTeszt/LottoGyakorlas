﻿// <auto-generated />
using APIHatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIHatos.Migrations
{
    [DbContext(typeof(APIHatosContext))]
    [Migration("20240408070127_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassLibrary.Models.Jatekos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jatekos");
                });

            modelBuilder.Entity("ClassLibrary.Models.Tipp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("JatekosId")
                        .HasColumnType("int");

                    b.Property<int>("Sz1")
                        .HasColumnType("int");

                    b.Property<int>("Sz2")
                        .HasColumnType("int");

                    b.Property<int>("Sz3")
                        .HasColumnType("int");

                    b.Property<int>("Sz4")
                        .HasColumnType("int");

                    b.Property<int>("Sz5")
                        .HasColumnType("int");

                    b.Property<int>("Sz6")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JatekosId");

                    b.ToTable("Tipp");
                });

            modelBuilder.Entity("ClassLibrary.Models.Tipp", b =>
                {
                    b.HasOne("ClassLibrary.Models.Jatekos", null)
                        .WithMany("Tipp")
                        .HasForeignKey("JatekosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrary.Models.Jatekos", b =>
                {
                    b.Navigation("Tipp");
                });
#pragma warning restore 612, 618
        }
    }
}
