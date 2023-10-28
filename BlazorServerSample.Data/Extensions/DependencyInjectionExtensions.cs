using BlazorServerSample.Data.Repositories;
using BlazorServerSample.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerSample.Data.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterDataServices(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
        }
    }
}
