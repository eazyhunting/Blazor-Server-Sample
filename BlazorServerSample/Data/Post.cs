using System.ComponentModel.DataAnnotations;

namespace BlazorServerSample.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set; } = string.Empty;
        
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Author { get; set; } = "Anonymous";

    }
}
