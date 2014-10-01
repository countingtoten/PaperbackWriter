using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Models;

namespace UI.Controllers
{
    public class BooksController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new List<Book>();
            return View(vm);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var vm = new Book()
            {
                Title = "Book!"
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            return View(book);
        }

        [HttpGet]
        public ActionResult Show()
        {
            var vm = new Book();
            return View(vm);
        }
    }
}