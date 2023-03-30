using ECommerceProject.Entities.IdentityModels;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
    [AllowAnonymous] 
    //bazı sayfalara authentice olmadan erisi saglanamayacak ama buraya her halukarda saglansın diye bu attribute eklenir.
    //altındaki butun kodları muaf bir sekilde calistiracak
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager= userManager;
			_signInManager= signInManager;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterVM p)
        {
			
			AppUser appUser = new AppUser()
			{
				Name = p.Name,
				Surname = p.Surname,
				Email = p.Mail,
				UserName = p.Username
			};
			if (p.Password == p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser, p.Password);

				if (result.Succeeded)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
				}
				return View(p);
		}

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> SignIn(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				else
				{
					return RedirectToAction("SignIn", "Login");
				}
			}
			return View();
		}
	}
}
