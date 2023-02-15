﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.Data;

#nullable disable

namespace CMS4.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.DTO.DB1_HeroBannerDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("background_image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("last_mod_user_id");

                    b.ToTable("hero_banners");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB2_ServicesDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("services_list_id")
                        .HasColumnType("integer");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("last_mod_user_id");

                    b.HasIndex("services_list_id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB2_ServicesListDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("services_list");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB3_AboutUsDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("last_mod_user_id");

                    b.ToTable("about_us");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB4_NumbersDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("description1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("description2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("value1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("value2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("last_mod_user_id");

                    b.ToTable("numbers");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB5_WorkWithUsDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("background_image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("last_mod_user_id");

                    b.ToTable("work_with_us");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB6_TestimonialsDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("testimonials_list_id")
                        .HasColumnType("integer");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("last_mod_user_id");

                    b.HasIndex("testimonials_list_id");

                    b.ToTable("testimonials");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB6_TestimonialsListDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("author_description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("opinion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("rating")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("testimonials_list");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB7_AdvantagesDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<int>("advantages_list_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("last_mod_user_id")
                        .HasColumnType("integer");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("advantages_list_id");

                    b.HasIndex("last_mod_user_id");

                    b.ToTable("advantages");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB7_AdvantagesListDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("icon_url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("advantages_list");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.UsersDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("cms_role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB1_HeroBannerDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB2_ServicesDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.DTO.DB2_ServicesListDTO", "services_list")
                        .WithMany()
                        .HasForeignKey("services_list_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("services_list");

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB3_AboutUsDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB4_NumbersDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB5_WorkWithUsDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB6_TestimonialsDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.DTO.DB6_TestimonialsListDTO", "testimonials_list")
                        .WithMany()
                        .HasForeignKey("testimonials_list_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("testimonials_list");

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB7_AdvantagesDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.DB7_AdvantagesListDTO", "advantages_list")
                        .WithMany()
                        .HasForeignKey("advantages_list_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.DTO.UsersDTO", "users")
                        .WithMany()
                        .HasForeignKey("last_mod_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("advantages_list");

                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
