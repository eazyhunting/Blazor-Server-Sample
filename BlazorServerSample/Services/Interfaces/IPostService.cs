using BlazorServerSample.Data;

namespace BlazorServerSample.Services.Interfaces
{
    public interface IPostService
    {
        Task<bool> DeletePostAsync(Post post);
        Task<Post> GetPostAsync(int id);
        Task<List<Post>> GetPostsAsync();
        Task<bool> InsertPostAsync(Post post);
        Task<bool> UpdatePostAsync(Post post);
    }
}