using BlazorServerSample.Data.Entities;
using BlazorServerSample.Services.Services.Extensions;
using BlazorServerSample.Shared.Models;

namespace BlazorServerSample.Extensions
{
    public static class PostExtensions
    {
        public static PostModel ToModel(this Post post)
        {
            return new PostModel()
            {
                Id = post.Id,
                Author = post.Author,
                Body = post.Body,
                CreateDate = post.CreateDate,
                Comments = post.Comments.Select(c => c.ToModel()).ToList()
            };
        }

        public static Post ToEntity(this PostModel post)
        {
            return new Post()
            {
                Id = post.Id,
                Author = post.Author,
                Body = post.Body,
                CreateDate = post.CreateDate,
                Comments = post.Comments.Select(c => c.ToEntity()).ToList()
            };
        }
    }
}
