using Back.DAL;
using Back.Models;
//using Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<User> users = _context.Users.AsQueryable().OrderByDescending(u=>u.Id).Take(3).ToList();
            return View(users);
        }

    }
}
