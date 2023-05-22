using System.ComponentModel.DataAnnotations;

public class CommentViewModel
{
    [Required(ErrorMessage = "Comment content is required.")]
    public string CommentText { get; set; }

    [Required(ErrorMessage = "CommentPost is required")]
    public string CommentPost { get; set; }

    [Required(ErrorMessage = "CommentId is required")]
    public int CommentId { get; set; }
}
