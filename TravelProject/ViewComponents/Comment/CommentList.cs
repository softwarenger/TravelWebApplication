using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business.Abstract;

namespace TravelProject.MVC.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetDestinationById(id);
            return View(values);
        }
    }
}
