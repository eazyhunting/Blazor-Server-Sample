using BlazorServerSample.Services.Interfaces;

namespace BlazorServerSample.Services.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentService, CommentService>();

            services.AddScoped<INotifierService, NotifierService>();
        }
    }
}
