using DAL.Abstract;
using DAL.Concrete.Context;
using DAL.Concrete.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace DAL
{
    public static class EFContextDAL
    {
        public static void AddScopeDal(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>()
                .AddScoped<IActorDAL, ActorRepository>()
                .AddScoped<ICinemaDAL, CinemaRepository>()
                .AddScoped<IMovieDAL, MovieRepository>()
                .AddScoped<IProducerDAL, ProducerRepository>();                
        }
    }
}
