using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Restaurant.DAL;
using Restaurant.Helpers;
using Restaurant.Models;
using Restaurant.ViewsModel;
using System.IO;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    public class AccountController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;
        public AccountController(IWebHostEnvironment env, SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,UserManager<AppUser> userManager)
        {
            _env = env;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        #region Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Username or Password is null");
                return View();
            }
            if (user.IsDeactive)
            {
                ModelState.AddModelError("", "This User is deactive");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult sign = await _signInManager.PasswordSignInAsync(user, login.Password, login.IsRemember, true);
            if (!sign.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is wrong");
                return View();
            }
            if (sign.IsLockedOut)
            {
                ModelState.AddModelError("", "Acount has blocked");
                return View();
            }
            return RedirectToAction("Index","Home");
        }
        #endregion

        //#region Register
        //public IActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Register(RegisterVM register)
        //{

        //    #region Image
        //    if (register.Photo == null)
        //    {
        //        ModelState.AddModelError("Photo", "Image can not be null");
        //        return View();
        //    }
        //    if (!register.Photo.IsImage())
        //    {
        //        ModelState.AddModelError("Photo", "Slect image type");
        //        return View();
        //    }
        //    if (register.Photo.IsOlder512Kb())
        //    {
        //        ModelState.AddModelError("Photo", "Max 512");
        //        return View();
        //    }
        //    string folder = Path.Combine(_env.WebRootPath, "img");
        //    register.Image = await register.Photo.SaveFileAsync(folder);
        //    #endregion

        //    AppUser newuser = new AppUser
        //    {
        //        Email = register.Email,
        //        FullName = register.Name,
        //        UserName = register.UserName,
        //        Image = register.Image
        //    };

        //    IdentityResult identity = await _userManager.CreateAsync(newuser,register.Password);

        //    if (!identity.Succeeded)
        //    {
        //        foreach (IdentityError error in identity.Errors)
        //        {
        //            ModelState.AddModelError("",error.Description);
        //        }
        //        return View();
        //    }
        //    await _userManager.AddToRoleAsync(newuser, Helpers.Role.Admin.ToString());
        //    await _signInManager.SignInAsync(newuser, register.IsRemember);
        //    return RedirectToAction("Index","Home");
        //}
        //#endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        #endregion

        #region CreateRole
        //public async Task CreateRoles()
        //{
        //    if (!await _roleManager.RoleExistsAsync(Helpers.Role.Admin.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helpers.Role.Admin.ToString() });
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Helpers.Role.ComManager.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helpers.Role.ComManager.ToString() });
        //    }
        //}
        #endregion
    }
}
