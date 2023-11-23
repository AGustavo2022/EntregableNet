﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using entregableNET.DataAccess;

#nullable disable

namespace entregableNET.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("entregableNET.Entities.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tasks_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("description");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit")
                        .HasColumnName("completed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "test de prueba",
                            IsCompleted = true,
                            Title = "test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
