using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TAH1.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? CommentText { get; set; }
        public string? CommentPost { get; set; }

    }
}
