﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backgourmandys.Datas;

#nullable disable

namespace backgourmandys.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backgourmandys.Models.Cake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLetterCake")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNumberCake")
                        .HasColumnType("bit");

                    b.Property<int>("Lot")
                        .HasColumnType("int");

                    b.Property<int>("MinimalQuantity")
                        .HasColumnType("int");

                    b.Property<int>("Pieces")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cakes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Content = "C'est un gâteau aux chocolats qui n'est bon !",
                            IsLetterCake = false,
                            IsNumberCake = false,
                            Lot = 1,
                            MinimalQuantity = 1,
                            Pieces = 1,
                            Price = 20.00m,
                            Size = "A4",
                            Title = "ChocoBon"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Content = "C'est un biscuit aux chocolats Blancs qui n'est pas noir !",
                            IsLetterCake = false,
                            IsNumberCake = false,
                            Lot = 6,
                            MinimalQuantity = 4,
                            Pieces = 2,
                            Price = 10.00m,
                            Size = "A3",
                            Title = "KinderBuenoWhite"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Content = "C'est un gâteau pour des mariages !",
                            IsLetterCake = false,
                            IsNumberCake = false,
                            Lot = 1,
                            MinimalQuantity = 1,
                            Pieces = 1,
                            Price = 200.00m,
                            Size = "A4",
                            Title = "MarryMe"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Content = "C'est un gâteau d'anniversaire chocolats poire !",
                            IsLetterCake = false,
                            IsNumberCake = false,
                            Lot = 3,
                            MinimalQuantity = 10,
                            Pieces = 10,
                            Price = 15.99m,
                            Size = "A2",
                            Title = "HappyBirthDay"
                        });
                });

            modelBuilder.Entity("backgourmandys.Models.CakeFlavor", b =>
                {
                    b.Property<int>("CakeId")
                        .HasColumnType("int");

                    b.Property<int>("FlavorId")
                        .HasColumnType("int");

                    b.HasKey("CakeId", "FlavorId");

                    b.HasIndex("FlavorId");

                    b.ToTable("CakeFlavors");

                    b.HasData(
                        new
                        {
                            CakeId = 1,
                            FlavorId = 1
                        },
                        new
                        {
                            CakeId = 1,
                            FlavorId = 2
                        },
                        new
                        {
                            CakeId = 2,
                            FlavorId = 2
                        },
                        new
                        {
                            CakeId = 2,
                            FlavorId = 3
                        });
                });

            modelBuilder.Entity("backgourmandys.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mariage"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Anniversaire"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Naissance"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Personnalisé"
                        });
                });

            modelBuilder.Entity("backgourmandys.Models.Flavor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flavors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chocolat"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bueno"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Framboise"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fraise"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Poire"
                        });
                });

            modelBuilder.Entity("backgourmandys.Models.PicturePath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CakeId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CakeId");

                    b.ToTable("PicturePaths");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CakeId = 1,
                            Path = "https://cdn.chefclub.tools/uploads/community/attachments/images/1e005648-4aa9-4a25-9695-31a65c37f37c_eQFrPBa.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CakeId = 1,
                            Path = "https://img-global.cpcdn.com/recipes/6ea0238b091c23d4/1200x630cq70/photo.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CakeId = 2,
                            Path = "https://www.pieceofcake.gi/wp-content/uploads/2020/11/IMG_2918.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CakeId = 2,
                            Path = "https://simshomekitchen.com/wp-content/uploads/2022/08/kinder-cake-2.png"
                        },
                        new
                        {
                            Id = 5,
                            CakeId = 3,
                            Path = "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-18.34.09-1.jpeg"
                        },
                        new
                        {
                            Id = 6,
                            CakeId = 3,
                            Path = "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-23.11.41.jpeg"
                        },
                        new
                        {
                            Id = 7,
                            CakeId = 4,
                            Path = "https://i.etsystatic.com/18089847/r/il/1eddf2/1669714698/il_1080xN.1669714698_khkj.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CakeId = 4,
                            Path = "https://i.ebayimg.com/images/g/K1AAAOSwfn9gcN1L/s-l1600.jpg"
                        });
                });

            modelBuilder.Entity("backgourmandys.Models.Cake", b =>
                {
                    b.HasOne("backgourmandys.Models.Category", "Category")
                        .WithMany("Cakes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("backgourmandys.Models.CakeFlavor", b =>
                {
                    b.HasOne("backgourmandys.Models.Cake", "Cake")
                        .WithMany("CakeFlavors")
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backgourmandys.Models.Flavor", "Flavor")
                        .WithMany("CakeFlavors")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cake");

                    b.Navigation("Flavor");
                });

            modelBuilder.Entity("backgourmandys.Models.PicturePath", b =>
                {
                    b.HasOne("backgourmandys.Models.Cake", "Cake")
                        .WithMany("PicturePath")
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cake");
                });

            modelBuilder.Entity("backgourmandys.Models.Cake", b =>
                {
                    b.Navigation("CakeFlavors");

                    b.Navigation("PicturePath");
                });

            modelBuilder.Entity("backgourmandys.Models.Category", b =>
                {
                    b.Navigation("Cakes");
                });

            modelBuilder.Entity("backgourmandys.Models.Flavor", b =>
                {
                    b.Navigation("CakeFlavors");
                });
#pragma warning restore 612, 618
        }
    }
}
