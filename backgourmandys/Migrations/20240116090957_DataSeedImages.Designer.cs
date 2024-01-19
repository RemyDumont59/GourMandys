﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backgourmandys.Datas;

#nullable disable

namespace backgourmandys.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240116090957_DataSeedImages")]
    partial class DataSeedImages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Flavour")
                        .HasColumnType("int");

                    b.Property<bool>("IsNumberOrLetterCake")
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

                    b.ToTable("Cakes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 3,
                            Content = "C'est un gâteau aux chocolats qui n'est bon !",
                            Flavour = 0,
                            IsNumberOrLetterCake = false,
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
                            Category = 2,
                            Content = "C'est un biscuit aux chocolats Blancs qui n'est pas noir !",
                            Flavour = 17,
                            IsNumberOrLetterCake = false,
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
                            Category = 0,
                            Content = "C'est un gâteau pour des mariages !",
                            Flavour = 16,
                            IsNumberOrLetterCake = false,
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
                            Category = 1,
                            Content = "C'est un gâteau d'anniversaire chocolats poire !",
                            Flavour = 9,
                            IsNumberOrLetterCake = true,
                            Lot = 3,
                            MinimalQuantity = 10,
                            Pieces = 10,
                            Price = 15.99m,
                            Size = "A2",
                            Title = "HappyBirthDay"
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
                    b.Navigation("PicturePath");
                });
#pragma warning restore 612, 618
        }
    }
}