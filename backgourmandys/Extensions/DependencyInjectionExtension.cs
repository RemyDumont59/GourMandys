using backgourmandys.Datas;
using backgourmandys.Models;
using backgourmandys.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using backgourmandys.Helpers;
using backgourmandys.Interfaces;
using backgourmandys.Services;

namespace backgourmandys.Extensions;

public static class DependencyInjectionExtension
{
    public static void InjectDependancies(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers().AddJsonOptions(x =>
                        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));

        builder.Services.AddScoped<IPictureService, PictureService>();

        builder.AddDatabase();

        builder.AddRepositories();

    }

    private static void AddDatabase(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }

    private static void AddRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IRepository<Cake>, CakeRepository>();
        builder.Services.AddScoped<IRepository<PicturePath>, PicturePathRepository>();
        builder.Services.AddScoped<IRepository<Flavor>, FlavorRepository>();
    }
}