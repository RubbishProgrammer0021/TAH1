using Microsoft.AspNetCore.Mvc;
using TAH1.Models;
using TAH1.Data;
using Microsoft.EntityFrameworkCore;
using Polly;
using Microsoft.AspNetCore.Authorization;

namespace TAH1.Controllers
{
    [Authorize]
    public class HomepageController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomepageController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult Post(PostViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Post post = new Post()
                    {
                        Title = model.Title,
                        Content = model.Content
                    };

                    _dbContext.Post.Add(post);
                    _dbContext.SaveChanges();

                    return RedirectToAction("View_Post");
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                // For example: ViewBag.ErrorMessage = ex.Message;
            }

            return View();
        }
        public IActionResult Profile_Page()
        {
            try
            {
                personaldetail pd = _dbContext.personaldetail.FirstOrDefault();

                var model = new personaldetailViewModel()
                {
                    fullname = pd?.fullname,
                    birthday = pd?.birthday,
                    email = pd?.email,
                    phone = (int)(pd?.phone),
                    mobile = (int)(pd?.mobile)
                };

                return View(model);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                // For example: ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        public IActionResult Edit_Profile()
        {
            return View();
        }

        public IActionResult personaldetail(personaldetailViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    personaldetail pd = _dbContext.personaldetail.FirstOrDefault();
                    if (pd != null)
                    {
                        pd.fullname = model.fullname;
                        pd.birthday = model.birthday;
                        pd.email = model.email;
                        pd.phone = model.phone;
                        pd.mobile = model.mobile;
                        _dbContext.SaveChanges();
                    }

                    return RedirectToAction("Profile_Page");
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                // For example: ViewBag.ErrorMessage = ex.Message;
            }

            return View(model);
        }

        public IActionResult View_Post()
        {
            try
            {
                var posts = _dbContext.Post.ToList();
                return View(posts);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                // For example: ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        public IActionResult Comment(CommentViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Comment comment = new Comment()
                    {
                        CommentId = model.CommentId,
                        CommentText = model.CommentText,
                        CommentPost = model.CommentPost
                    };

                    _dbContext.Comment.Add(comment);
                    _dbContext.SaveChanges();

                    return RedirectToAction("View_Comment");
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                // For example: ViewBag.ErrorMessage = ex.Message;
            }

            return View(model);
        }

        public IActionResult View_Comment()
        {
            try
            {
                var comments = _dbContext.Comment.ToList();
                return View(comments);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                // For example: ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}
