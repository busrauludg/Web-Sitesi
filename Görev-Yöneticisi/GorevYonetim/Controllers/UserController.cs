using Microsoft.EntityFrameworkCore;
using GorevYonetim.Models;
using Microsoft.AspNetCore.Mvc;

namespace GorevYonetim.Controllers
{
    public class UserController : Controller
    {
        private readonly RepositoryContext _context;

        public UserController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Users.ToList();
            return View(model);
        }
        

    }
}