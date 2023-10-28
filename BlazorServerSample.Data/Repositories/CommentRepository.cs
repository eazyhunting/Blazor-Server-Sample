using BlazorServerSample.Data.Entities;
using BlazorServerSample.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSample.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public async Task<List<Comment>> GetCommentsAsync(int postId) =>
            await _appDbContext.Comments.Where(c => c.PostId == postId)
                .ToListAsync();

        public async Task<bool> InsertCommentAsync(Comment comment)
        {
            await _appDbContext.Comments.AddAsync(comment);
            return true;
        }

        public async Task<Comment?> GetCommentAsync(int id)
        {
            var comment = await _appDbContext.Comments.FirstOrDefaultAsync(comment => comment.Id == id);
            if (comment != null) return comment;
            return null;
        }

        public void UpdateComment(Comment comment)
        {
            _appDbContext.Comments.Update(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _appDbContext.Comments.Remove(comment);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync() > 0;
        }
    }
}
