using BlazorServerSample.Data.Entities;
using BlazorServerSample.Extensions;
using BlazorServerSample.Shared.Models;

namespace BlazorServerSample.Services.Services.Extensions
{
    public static class CommentExtensions
    {
        public static CommentModel ToModel(this Comment comment)
        {
            return new CommentModel()
            {
                Id = comment.Id,
                Message = comment.Message,
                Author = comment.Author,
                Created = comment.Created,
                PostId = comment.PostId,
                Post = comment.Post.ToModel(),
            };
        }

        public static Comment ToEntity(this CommentModel comment) {
            return new Comment()
            {
                Id = comment.Id,
                Message = comment.Message,
                Author = comment.Author,
                Created = comment.Created,
                PostId = comment.PostId,
                Post = comment.Post.ToEntity(),
            };
        }
    }
}
