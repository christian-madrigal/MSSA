using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Assignment_13._3.Models;
using System.Threading.Tasks;
using Assignment_13._3.ViewModels;


namespace Assignment_13._3.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<Customer> _signInManager;
        private UserManager<Customer> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public AccountController(SignInManager<Customer> signInManager, UserManager<Customer> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            // CreateRoles(roleManager);

        }
        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginView.UserName, loginView.Password, loginView.RememberMe, false);
                // user is authenticated
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Employee");
                }
            }
            ModelState.AddModelError("", "Failed to login");
            return View();


        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                Customer newuser = new Customer()
                {
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    UserName = registerViewModel.UserName,
                    PhoneNumber = registerViewModel.PhoneNumber.ToString(),
                    Email = registerViewModel.Email

                };
                var result = await _userManager.CreateAsync(newuser, registerViewModel.Password);
                if (result.Succeeded)
                {
                    var addedUser = await _userManager.FindByNameAsync(newuser.UserName);
                    //if (addedUser.UserName == "Admin")
                    //{
                    //    await _userManager.AddToRoleAsync(addedUser, "Admin");
                    //    await _userManager.AddToRoleAsync(addedUser, "Employee");
                    //}
                    //else
                    //{
                    //    await _userManager.AddToRoleAsync(addedUser, "Employee");
                    //}
                    return RedirectToAction("Login", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View();

        }



        // this method can also be synchronous
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
