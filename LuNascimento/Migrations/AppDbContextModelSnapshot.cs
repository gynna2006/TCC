﻿// <auto-generated />
using System;
using LuNascimento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LuNascimento.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LuNascimento.Models.Categoria", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Nome = "Aromatizador de Ambiente"
                        },
                        new
                        {
                            Id = (byte)2,
                            Nome = "Aromatizador de Carro"
                        },
                        new
                        {
                            Id = (byte)3,
                            Nome = "Sabonetes"
                        },
                        new
                        {
                            Id = (byte)4,
                            Nome = "Home Spray"
                        },
                        new
                        {
                            Id = (byte)5,
                            Nome = "Água de Lençol"
                        },
                        new
                        {
                            Id = (byte)6,
                            Nome = "Sachê"
                        });
                });

            modelBuilder.Entity("LuNascimento.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("CategoriaId")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/10.png",
                            Nome = "Frasco Quadrado Color",
                            Preco = 85.00m
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/4.png",
                            Nome = "Frasco Quadrado Gelo",
                            Preco = 65.00m
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = (byte)2,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração. Consultar disponibilidade via whatsapp. Este produto contém 10ML.",
                            Foto = "/images/produtos/5.png",
                            Nome = "Aromatizador para Carros",
                            Preco = 15.00m
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/16.png",
                            Nome = "Frasco Estrela Marrom",
                            Preco = 85.00m
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 50ML.",
                            Foto = "/images/produtos/15.png",
                            Nome = "Frasco Champanhe",
                            Preco = 30.00m
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/6.png",
                            Nome = "Frasco Color Redondo",
                            Preco = 85.00m
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = (byte)3,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/3.png",
                            Nome = "Sabonete Color Redondo (INDISPONÍVEL)",
                            Preco = 0m
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = (byte)6,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor. Consultar disponibilidade via whatsapp.",
                            Foto = "/images/produtos/1.png",
                            Nome = "Sachê Perfumado",
                            Preco = 7.00m
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML.",
                            Foto = "/images/produtos/14.png",
                            Nome = "Garrafa Cinturinha",
                            Preco = 30.00m
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/21.png",
                            Nome = "Aromatizador Bola",
                            Preco = 95.00m
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/12.png",
                            Nome = "Aromatizador Meia Lua",
                            Preco = 65.00m
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML.",
                            Foto = "/images/produtos/19.png",
                            Nome = "Aromatizador Quadrado Âmbar",
                            Preco = 85.00m
                        },
                        new
                        {
                            Id = 13,
                            CategoriaId = (byte)4,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML.",
                            Foto = "/images/produtos/2.png",
                            Nome = "Home Spray",
                            Preco = 20.00m
                        },
                        new
                        {
                            Id = 14,
                            CategoriaId = (byte)5,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML.",
                            Foto = "/images/produtos/9.png",
                            Nome = "Água de Lençol",
                            Preco = 30.00m
                        },
                        new
                        {
                            Id = 15,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/7.png",
                            Nome = "Vidro Estampa Cesta",
                            Preco = 85.00m
                        },
                        new
                        {
                            Id = 16,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/8.png",
                            Nome = "Vidro Degradê",
                            Preco = 95.00m
                        },
                        new
                        {
                            Id = 17,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/11.png",
                            Nome = "Vidro Quadrado Gelo",
                            Preco = 65.00m
                        },
                        new
                        {
                            Id = 18,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/13.png",
                            Nome = "Vidro Âmbar Retangular",
                            Preco = 95.00m
                        },
                        new
                        {
                            Id = 19,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/18.png",
                            Nome = "Vidro Tribal",
                            Preco = 85.00m
                        },
                        new
                        {
                            Id = 20,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 300ML.",
                            Foto = "/images/produtos/17.png",
                            Nome = "Vidro Lampião",
                            Preco = 95.00m
                        },
                        new
                        {
                            Id = 21,
                            CategoriaId = (byte)1,
                            Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                            Foto = "/images/produtos/20.png",
                            Nome = "Vidro Bola",
                            Preco = 79.00m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cc2b4dd9-5899-4233-a73a-2f9355a4c7f4",
                            ConcurrencyStamp = "4b06640b-90e4-4bea-b09e-0c271281c18e",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c893bad4-7aa4-46b9-88aa-9f1b71ff455f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b44aba23-8881-486b-b4e0-22af60042bbf",
                            Email = "admin@lunascimento.com.br",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LUNASCIMENTO.COM.BR",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEH3jmwJ0Bzbr8G3Qob7CtZ4bYy+Xrmo+Cvi2tsRQ1NEkwbhpRFnozkqIiGBpY8AqXQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7e86bc8a-f15e-4ade-bfa8-8211b02c4f3f",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "c893bad4-7aa4-46b9-88aa-9f1b71ff455f",
                            RoleId = "cc2b4dd9-5899-4233-a73a-2f9355a4c7f4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LuNascimento.Models.Produto", b =>
                {
                    b.HasOne("LuNascimento.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
