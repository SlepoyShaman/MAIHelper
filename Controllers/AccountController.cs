using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using maihelper.Models.Identity;
using maihelper.Models.ExchangeModels;

namespace maihelper.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody]RegistrGetModel model)
        {
            User user = new User() { Email = model.Email, UserName = model.Email, Login = model.Login };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return Ok();
            } else
                return BadRequest(result.Errors);
            
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody]LoginGetModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
                return BadRequest("Неверный логин и (или) пароль");
        }

    }
}
