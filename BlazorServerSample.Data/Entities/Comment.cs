using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSample.Data.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Message { get; set; } = string.Empty;
        public string Author { get; set; } = "Anonymous";
        public DateTime Created { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey(nameof(PostId))]
        public int PostId { get; set; }
                
        public virtual Post Post { get; set; }

    }
}
