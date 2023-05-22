using System.ComponentModel.DataAnnotations;
using TAH1.Data;
using TAH1.Models;
using TAH1.Controllers;

namespace TAH1.Models
{
	public class PostViewModel
	{
		[Required(ErrorMessage = "Title is required")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Content is required")]
		public string Content { get; set; }


	}
}
