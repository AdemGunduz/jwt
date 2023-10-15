using jwt.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiValuesContorller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ApiValuesContorller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
           Token token = TokenHandler.CreateToken(_configuration);
            return Ok(token);
        }
    }
}
