using MVCVueTodoApp.Models;
using MVCVueTodoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace MVCVueTodoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GetHomeViewModel());
        }

        private HomeViewModel GetHomeViewModel()
        {
            var todos = new List<Todo>
            {
                new Todo(1, "Walk the dog"),
                new Todo(2, "Clean the garage"),
                new Todo(3, "Study for certification exam")
            };

            return new HomeViewModel(todos);
        }
    }
}