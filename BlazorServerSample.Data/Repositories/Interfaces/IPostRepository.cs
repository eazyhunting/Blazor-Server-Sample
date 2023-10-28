using BlazorServerSample.Data.Entities;

namespace BlazorServerSample.Data.Repositories.Interfaces
{
    public interface IPostRepository
    {
        void DeletePost(Post post);
        Task<Post?> GetPostAsync(int id);
        Task<List<Post>> GetPostsAsync();
        Task<bool> InsertPostAsync(Post post);
        Task<bool> SaveChangesAsync();
        void UpdatePost(Post post);
    }
}