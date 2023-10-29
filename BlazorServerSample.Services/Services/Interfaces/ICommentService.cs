using BlazorServerSample.Shared.Models;

namespace BlazorServerSample.Services.Interfaces
{
    public interface ICommentService
    {
        Task<bool> DeleteCommentAsync(CommentModel comment);
        Task<CommentModel> GetCommentAsync(int id);
        Task<List<CommentModel>> GetCommentsAsync(int postId);
        Task<bool> InsertCommentAsync(CommentCreationModel comment);
        Task<bool> UpdateCommentAsync(CommentModel comment);
    }
}