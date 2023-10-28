using BlazorServerSample.Data.Entities;
using BlazorServerSample.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSample.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;
        public PostRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public void DeletePost(Post post)
        {
            _appDbContext.Posts.Remove(post);
        }

        public async Task<Post?> GetPostAsync(int id)
        {
            return await _appDbContext.Posts.FirstOrDefaultAsync(post => post.Id == id);
        }

        public async Task<List<Post>> GetPostsAsync() => await _appDbContext.Posts.ToListAsync();

        public async Task<bool> InsertPostAsync(Post post)
        {
            await _appDbContext.Posts.AddAsync(post);
            return true;
        }

        public void UpdatePost(Post post)
        {
            _appDbContext.Posts.Update(post);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync() > 0;
        }
    }
}
