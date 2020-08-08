using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Musicalog.Data.Interfaces;
using Musicalog.Data.Repositories;

namespace Musicalog.Data
{
    public static class StartupExtensions
    {
        public static void RegisterDataRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IAlbumTypeRepository, AlbumTypeRepository>();
            services.AddScoped<IArtistRepository, ArtistRepository>();

            services.AddDbContext<MusicalogDbContext>(options => options.UseLazyLoadingProxies().UseSqlServer(configuration["ConnectionStrings:ContactClassifier"]).EnableSensitiveDataLogging());
        }
    }
}
