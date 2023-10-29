using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerSample.Shared.Models
{
    public class CommentCreationModel
    {
        [Required]
        public string Message { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = "Anonymous";

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        public int PostId { get; set; }
    }
}
