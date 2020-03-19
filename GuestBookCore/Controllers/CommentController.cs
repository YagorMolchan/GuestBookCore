using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuestBookCore.Data;
using GuestBookCore.Models.Entities;
using GuestBookCore.Models.ViewModels;

namespace GuestBookCore.Controllers
{
    public class CommentController : Controller
    {

        private readonly CommentDbContext _dbContext;

        public CommentController(CommentDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]        
        public IActionResult Create(CommentViewModel model)
        {
            if(ModelState.IsValid)
            {
                _dbContext.Add(new Comment { Username = model.Username, Date = DateTime.Now, Text = model.Text });
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Ошибка ввода!");
            }
            return View(model);
        }

        public IActionResult Index()
        {
            return View(_dbContext.Comments.ToList());
        }

        
    }
}