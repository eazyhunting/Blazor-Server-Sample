using BlazorServerSample.Shared.Models;

namespace BlazorServerSample.Services.Interfaces
{
    public interface IPostService
    {
        Task<bool> DeletePostAsync(PostModel post);
        Task<PostModel?> GetPostAsync(int id);
        Task<List<PostModel>> GetPostsAsync();
        Task<bool> InsertPostAsync(PostModel post);
        Task<bool> UpdatePostAsync(PostModel post);
    }
}