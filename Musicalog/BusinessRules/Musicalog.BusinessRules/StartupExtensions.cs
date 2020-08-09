using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Musicalog.BusinessRules.Interfaces;
using Musicalog.Data;

namespace Musicalog.BusinessRules
{
    public static class StartupExtensions
    {
        public static void RegisterBusinessRules(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDataRepositories(configuration);
            services.AddScoped<IAlbumBusinessRules, AlbumBusinessRules>();
            services.AddScoped<IAlbumTypeBusinessRules, AlbumTypeBusinessRules>();
            services.AddScoped<IArtistBusinessRules, ArtistBusinessRules>();
        }
    }
}