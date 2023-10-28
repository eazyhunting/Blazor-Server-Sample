using BlazorServerSample.Data.Entities;

namespace BlazorServerSample.Data.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        void DeleteComment(Comment comment);
        Task<Comment?> GetCommentAsync(int id);
        Task<List<Comment>> GetCommentsAsync(int postId);
        Task<bool> InsertCommentAsync(Comment comment);
        Task<bool> SaveChangesAsync();
        void UpdateComment(Comment comment);
    }
}