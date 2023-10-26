using BlazorServerSample.Data;
using BlazorServerSample.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BlazorServerSample.Services
{
    public class PostService : IPostService
    {
        private readonly AppDbContext _appDbContext;

        public PostService(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public async Task<List<Post>> GetPostsAsync() =>
            await _appDbContext.Posts.ToListAsync();

        public async Task<bool> InsertPostAsync(Post post)
        {
            await _appDbContext.Posts.AddAsync(post);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Post> GetPostAsync(int id) => 
            await _appDbContext.Posts.FirstOrDefaultAsync(post => post.Id == id);
            
        public async Task<bool> UpdatePostAsync(Post post)
        {
            _appDbContext.Posts.Update(post);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePostAsync(Post post)
        {
            _appDbContext.Posts.Remove(post);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
