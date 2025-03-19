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
       
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp([FromForm]User model)
        {
            if(model.Password.Length<7||!model.Password.Any(char.IsLetter)||!model.Password.Any(char.IsDigit)||!model.Password.Any(c=>!char.IsLetterOrDigit(c)))
            {
                ModelState.AddModelError("Password", "Password must be at least 7 characters long, contain 4 letters, 2 digits, and 1 special character.");
    
            }
            if(_context.Users.Any(u=>u.Email==model.Email))
            {
                 ModelState.AddModelError("Email", "This email is already registered.");
            }

            if(ModelState.IsValid)
            {
                _context.Users.Add(model);//kullanıcıyı veritabanına ekler
                _context.SaveChanges();//değişiklikleri kaydedin
                return RedirectToAction("Index");//başarıyla eklerinsi indexe döndücek
            }
            return View();
        }

    }
}