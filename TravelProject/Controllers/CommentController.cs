using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;
using Travel.Entity.Concrete;

namespace TravelProject.MVC.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]  
        public IActionResult AddComment(int id,Comment comment)
        {

            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            comment.CommentState = true;
            comment.DestinationId = 3;          
            _commentService.TAdd(comment);

            return RedirectToAction("Index","Destination");
        }
    }
}
