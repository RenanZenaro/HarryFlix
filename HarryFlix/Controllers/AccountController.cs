using System.Net.Mail;
using HarryFlix.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HarryFlix.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AccountController(
        ILogger<AccountController> logger,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager
    )
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            ReturnUrl = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> login(LoginVM login)
    {
        if (ModelState.IsValid)
        {
            
        }
        return View(login);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            MailAddress mail = new(email);
            return true;
        }
        catch
        {
            return false;
        }
    }
}