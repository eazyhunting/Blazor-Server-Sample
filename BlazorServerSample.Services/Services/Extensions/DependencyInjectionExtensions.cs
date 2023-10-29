using BlazorServerSample.Data.Extensions;
using BlazorServerSample.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerSample.Services.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.RegisterDataServices();

            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentService, CommentService>();
        }
    }
}
