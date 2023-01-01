using CleanMovie.Application;
using CleanMovie.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CleanMovie.DependencyInjection
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddCleanMovieServices(this IServiceCollection services, string constring)
        {
            services.AddScoped<IMovieService, MovieService>(s =>
            {
                var movieinstance = new MovieService(constring);

                return movieinstance;
            });

            return services;
        }
    }
}
