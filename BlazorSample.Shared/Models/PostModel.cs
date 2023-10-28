using System.ComponentModel.DataAnnotations;

namespace BlazorSample.Shared.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        [Required]
        public string Body { get; set; } = string.Empty;

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Required]
        public string Author { get; set; } = "Anonymous";

        public List<CommentModel> Comments { get; set; } = new List<CommentModel>();
    }
}
