using System.ComponentModel.DataAnnotations;

namespace BlazorServerSample.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set; } = string.Empty;
        
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Author { get; set; } = "Anonymous";

        public virtual List<Comment> Comments { get; set; }

    }
}
