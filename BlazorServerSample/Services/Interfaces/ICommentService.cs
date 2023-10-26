using BlazorServerSample.Data;

namespace BlazorServerSample.Services.Interfaces
{
    public interface ICommentService
    {
        Task<bool> DeleteCommentAsync(Comment comment);
        Task<Comment> GetCommentAsync(int id);
        Task<List<Comment>> GetCommentsAsync(int postId);
        Task<bool> InsertCommentAsync(Comment comment);
        Task<bool> UpdateCommentAsync(Comment comment);
    }
}