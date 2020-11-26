using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Repos;
using RepositoryPattern.Repos.IRepos;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    public class TodoController : Controller
    {
        private IGenericRepository _repo;
        public TodoController(IGenericRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            //_repo.GetAll();
            return View(_repo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(todo);
                _repo.Save();
            }

            return View(todo);
        }
    }
}
