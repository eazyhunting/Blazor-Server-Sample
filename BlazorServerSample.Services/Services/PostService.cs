using BlazorServerSample.Services.Interfaces;
using BlazorServerSample.Shared.Models;
using BlazorServerSample.Extensions;
using BlazorServerSample.Data.Repositories.Interfaces;

namespace BlazorServerSample.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository) => _postRepository = postRepository;

        public async Task<List<PostModel>> GetPostsAsync()
        {
            var posts = await _postRepository.GetPostsAsync();
            return posts.Select(p => p.ToModel()).ToList();
        }

        public async Task<bool> InsertPostAsync(PostModel post)
        {
            await _postRepository.InsertPostAsync(post.ToEntity());
            return await _postRepository.SaveChangesAsync();
        }

        public async Task<PostModel?> GetPostAsync(int id)
        {
            var post = await _postRepository.GetPostAsync(id);
            if (post != null) return post.ToModel();
            return null;
        }            
            
        public async Task<bool> UpdatePostAsync(PostModel post)
        {
            _postRepository.UpdatePost(post.ToEntity());
            return await _postRepository.SaveChangesAsync();
        }

        public async Task<bool> DeletePostAsync(PostModel post)
        {
            _postRepository.DeletePost(post.ToEntity());
            return await _postRepository.SaveChangesAsync();
        }
    }
}
