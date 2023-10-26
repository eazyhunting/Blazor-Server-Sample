using BlazorServerSample.Data;
using BlazorServerSample.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSample.Services
{
    public class CommentService : ICommentService
    {
        private readonly AppDbContext _appDbContext;

        public CommentService(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public async Task<List<Comment>> GetCommentsAsync(int postId) =>
            await _appDbContext.Comments.Where(c => c.PostId == postId)
                .ToListAsync();

        public async Task<bool> InsertCommentAsync(Comment comment)
        {
            await _appDbContext.Comments.AddAsync(comment);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Comment> GetCommentAsync(int id) =>
            await _appDbContext.Comments.FirstOrDefaultAsync(comment => comment.Id == id);

        public async Task<bool> UpdateCommentAsync(Comment comment)
        {
            _appDbContext.Comments.Update(comment);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCommentAsync(Comment comment)
        {
            _appDbContext.Comments.Remove(comment);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
