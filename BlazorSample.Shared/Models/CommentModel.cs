using System.ComponentModel.DataAnnotations;

namespace BlazorSample.Shared.Models
{
    public class CommentModel
    {
        
        public int Id { get; set; }

        [Required]
        public string Message { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = "Anonymous";

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        public virtual PostModel Post { get; set; }
    }
}
