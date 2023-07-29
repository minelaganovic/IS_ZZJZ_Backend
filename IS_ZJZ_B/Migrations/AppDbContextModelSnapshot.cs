﻿// <auto-generated />
using IS_ZJZ_B.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IS_ZJZ_B.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IS_ZJZ_B.Models.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pwd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("admins", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.AdministrativeWorker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pwd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("administrativeworkers", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.GCard", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("disease_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_hc")
                        .HasColumnType("int");

                    b.Property<int>("id_te")
                        .HasColumnType("int");

                    b.Property<string>("mode_of_transportation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("place_of_departure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("gcard", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.HealthCenterEmployee", b =>
                {
                    b.Property<int>("Id_hce")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_hce"));

                    b.Property<string>("city_hce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flname_doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_hce")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_hce");

                    b.ToTable("healthcenteremployee", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.Request", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type_id")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("requests", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.RequestType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("tipzahteva")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("requesttype", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.TravelExpense", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cost_price")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("texpensess", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jmbg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pwd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("IS_ZJZ_B.Models.healthcards", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("date_expiration_hc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_verification_hc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_user")
                        .HasColumnType("int");

                    b.Property<string>("lbo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("healthcards", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
