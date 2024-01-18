using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;

namespace backgourmandys.Datas;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Cake> Cakes { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<CakeFlavor> CakeFlavors { get; set; }
    public DbSet<PicturePath> PicturePaths { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<CakeFlavor> cakeFlavors = new List<CakeFlavor>()
        {
            new CakeFlavor()
            {
                CakeId = 1,
                FlavorId = 1,
            },
            new CakeFlavor()
            {
                CakeId = 1,
                FlavorId = 2,
            },
            new CakeFlavor()
            {
                CakeId = 2,
                FlavorId = 2,
            },
            new CakeFlavor()
            {
                CakeId = 2,
                FlavorId = 3,
            },
        };

        List<PicturePath> pictures = new List<PicturePath>()
        {
            new PicturePath()
            {
                Id = 1,
                CakeId = 1,
                Path = "https://cdn.chefclub.tools/uploads/community/attachments/images/1e005648-4aa9-4a25-9695-31a65c37f37c_eQFrPBa.jpg",
            },
            new PicturePath()
            {
                Id = 2,
                CakeId = 1,
                Path = "https://img-global.cpcdn.com/recipes/6ea0238b091c23d4/1200x630cq70/photo.jpg",
            },
            new PicturePath()
            {
                Id = 3,
                CakeId = 2,
                Path = "https://www.pieceofcake.gi/wp-content/uploads/2020/11/IMG_2918.jpg",
            },
            new PicturePath()
            {
                Id = 4,
                CakeId = 2,
                Path = "https://simshomekitchen.com/wp-content/uploads/2022/08/kinder-cake-2.png",
            },
            new PicturePath()
            {
                Id = 5,
                CakeId = 3,
                Path = "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-18.34.09-1.jpeg",
            },
            new PicturePath()
            {
                Id = 6,
                CakeId = 3,
                Path = "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-23.11.41.jpeg",
            },
            new PicturePath()
            {
                Id = 7,
                CakeId = 4,
                Path = "https://i.etsystatic.com/18089847/r/il/1eddf2/1669714698/il_1080xN.1669714698_khkj.jpg",
            },
            new PicturePath()
            {
                Id = 8,
                CakeId = 4,
                Path = "https://i.ebayimg.com/images/g/K1AAAOSwfn9gcN1L/s-l1600.jpg",
            },
        };

        List<Flavor> flavors = new List<Flavor>()
        {
            new Flavor()
            {
                Id = 1,
                Name = "Chocolat"
            },
            new Flavor()
            {
                Id = 2,
                Name = "Bueno"
            },
            new Flavor()
            {
                Id = 3,
                Name = "Framboise"
            },
            new Flavor()
            {
                Id = 4,
                Name = "Fraise"
            },
            new Flavor()
            {
                Id = 5,
                Name = "Poire"
            },
        };

        List<Cake> cakesList = new List<Cake>()
        {
            new Cake()
            {
                Id = 1,
                Title = "ChocoBon",
                Content = "C'est un gâteau aux chocolats qui n'est bon !",
                Category = Enum.Category.Personnalisé,
                Price = 20.00m,
                Pieces = 1,
                Size = "A4",
                MinimalQuantity = 1,
                Lot = 1,
                IsLetterCake = false,
                IsNumberCake = false,

            },
            new Cake()
            {
                Id = 2,
                Title = "KinderBuenoWhite",
                Content = "C'est un biscuit aux chocolats Blancs qui n'est pas noir !",
                Category = Enum.Category.GenderReveal,
                Price = 10.00m,
                Pieces = 2,
                Size = "A3",
                MinimalQuantity = 4,
                Lot = 6,
                IsLetterCake = false,
                IsNumberCake = false,
            },
            new Cake()
            {
                Id = 3,
                Title = "MarryMe",
                Content = "C'est un gâteau pour des mariages !",
                Category = Enum.Category.Mariage,
                Price = 200.00m,
                Pieces = 1,
                Size = "A4",
                MinimalQuantity = 1,
                Lot = 1,
                IsLetterCake = false,
                IsNumberCake = false,
            },
            new Cake()
            {
                Id = 4,
                Title = "HappyBirthDay",
                Content = "C'est un gâteau d'anniversaire chocolats poire !",
                Category = Enum.Category.Anniversaire,
                Price = 15.99m,
                Pieces = 10,
                Size = "A2",
                MinimalQuantity = 10,
                Lot = 3,
                IsLetterCake = false,
                IsNumberCake = false,

            },
        };
        modelBuilder.Entity<Cake>().HasData(cakesList);
        modelBuilder.Entity<PicturePath>().HasData(pictures);
        modelBuilder.Entity<Flavor>().HasData(flavors);
        modelBuilder.Entity<CakeFlavor>()
            .HasKey(cf => new { cf.CakeId, cf.FlavorId });
        modelBuilder.Entity<CakeFlavor>().HasData(cakeFlavors);
    }
}
