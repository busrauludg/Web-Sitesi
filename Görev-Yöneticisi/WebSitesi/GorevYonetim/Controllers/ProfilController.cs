using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Constract;

namespace GorevYonetim.Controllers
{
    public class ProfilController:Controller
    {
        private readonly IUserServices _userServices;

        public ProfilController(IUserServices userServices)
        {
            _userServices=userServices;
        }
    //     public IActionResult Index()
    // {
    //     var user = UserService.GetUserProfile(User.Identity.Name); // Kullanıcı adı üzerinden profil bilgilerini al
    //     return View(user);
    // }

    }

}