using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;

namespace backgourmandys.Datas;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Cake> Cakes { get; set; }
    public DbSet<PicturePath> PicturePaths { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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

        List<Cake> cakesList = new List<Cake>()
        {
            new Cake()
            {
                Id = 1,
                Title = "ChocoBon",
                Content = "C'est un gâteau aux chocolats qui n'est bon !",
                Category = Enum.Category.Personnalisé,
                Flavour = Enum.Flavour.Nutella,
                Price = 20.00m,
                Pieces = 1,
                Size = "A4",
                MinimalQuantity = 1,
                Lot = 1,
                IsNumberOrLetterCake = false,
            },
            new Cake()
            {
                Id = 2,
                Title = "KinderBuenoWhite",
                Content = "C'est un biscuit aux chocolats Blancs qui n'est pas noir !",
                Category = Enum.Category.GenderReveal,
                Flavour = Enum.Flavour.ChocolatBlancFramboise,
                Price = 10.00m,
                Pieces = 2,
                Size = "A3",
                MinimalQuantity = 4,
                Lot = 6,
                IsNumberOrLetterCake = false,
            },
            new Cake()
            {
                Id = 3,
                Title = "MarryMe",
                Content = "C'est un gâteau pour des mariages !",
                Category = Enum.Category.Mariage,
                Flavour = Enum.Flavour.Praliné,
                Price = 200.00m,
                Pieces = 1,
                Size = "A4",
                MinimalQuantity = 1,
                Lot = 1,
                IsNumberOrLetterCake = false,
            },
            new Cake()
            {
                Id = 4,
                Title = "HappyBirthDay",
                Content = "C'est un gâteau d'anniversaire chocolats poire !",
                Category = Enum.Category.Anniversaire,
                Flavour = Enum.Flavour.ChocolatPoire,
                Price = 15.99m,
                Pieces = 10,
                Size = "A2",
                MinimalQuantity = 10,
                Lot = 3,
                IsNumberOrLetterCake = true,

            },
        };
        modelBuilder.Entity<Cake>().HasData(cakesList);
        modelBuilder.Entity<PicturePath>().HasData(pictures);
    }
}







