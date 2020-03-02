using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Webinar.Models;
using Webinar.Repository;
using Swashbuckle.AspNetCore.Annotations;

namespace Webinar.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [SwaggerTag("Фойдаланувчилар билан ишлаш")]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork db;
        private ILogger<UsersController> _logger;

        public UsersController(IUnitOfWork _db, ILogger<UsersController> logger)
        {
            db = _db;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [SwaggerOperation("Авторизация")]
        public IActionResult Authenticate([FromBody]viAuthenticateModel model)
        {
            var rpUser = db.GetRepository<tbUser>(true) as UserRepository;
            var user = rpUser.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        [SwaggerOperation("Хамма user")]
        public IActionResult GetAll()
        {
            var rpUser = db.GetRepository<tbUser>(true) as UserRepository;
            var users = rpUser.GetAllUsers();

            return Ok(users);
        }
    }
}
