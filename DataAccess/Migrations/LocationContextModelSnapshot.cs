﻿// <auto-generated />
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(LocationContext))]
    partial class LocationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Entity.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("BranchId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("BranchId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.Department", b =>
                {
                    b.HasOne("Entity.Branch", "Branch")
                        .WithMany("Departments")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Entity.User", b =>
                {
                    b.HasOne("Entity.Branch", "Branch")
                        .WithOne("Users")
                        .HasForeignKey("Entity.User", "BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Entity.Branch", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
