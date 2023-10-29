using BlazorServerSample.Data.Repositories.Interfaces;
using BlazorServerSample.Services.Interfaces;
using BlazorServerSample.Services.Services.Extensions;
using BlazorServerSample.Shared.Models;

namespace BlazorServerSample.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository) => _commentRepository = commentRepository;

        public async Task<List<CommentModel>> GetCommentsAsync(int postId)
        {
            var comments = await _commentRepository.GetCommentsAsync(postId);
            return comments.Select(c => c.ToModel()).ToList();
        }

        public async Task<bool> InsertCommentAsync(CommentCreationModel comment)
        {
            await _commentRepository.InsertCommentAsync(comment.ToEntity());
            return await _commentRepository.SaveChangesAsync();
        }

        public async Task<CommentModel?> GetCommentAsync(int id)
        {
            var comment = await _commentRepository.GetCommentAsync(id);
            if (comment != null) return comment.ToModel();
            return null;
        }            

        public async Task<bool> UpdateCommentAsync(CommentModel comment)
        {
            _commentRepository.UpdateComment(comment.ToEntity());
            return await _commentRepository.SaveChangesAsync();
        }

        public async Task<bool> DeleteCommentAsync(CommentModel comment)
        {
            _commentRepository.DeleteComment(comment.ToEntity());
            return await _commentRepository.SaveChangesAsync();
        }

    }
}
