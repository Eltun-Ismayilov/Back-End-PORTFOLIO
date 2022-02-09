using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity.JWT;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTTokenController : ControllerBase
    {
        readonly PortfolioDbContext db;
        readonly IConfiguration configuration;


        public JWTTokenController(PortfolioDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        [HttpPost]

        public async Task<IActionResult> GenerateToken(User user)
        {
            if (user != null && user.Username != null && user.Password != null)
            {
                var userdata = await GetUserInfo(user.Username, user.Password);
                var jwt = configuration.GetSection("Jwt").Get<Jwt>();

                if (user!=null)
                {
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub,jwt.Subject),
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                        new Claim("Id",user.UserId.ToString()),
                        new Claim("Username",user.Username),
                        new Claim("Password",user.Password),

                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.key));
                    var signin = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken
                        (
                        jwt.Issuer,
                        jwt.Audience,
                        claims,
                        expires: DateTime.Now.AddMinutes(20),
                        signingCredentials: signin
                        );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                       
                }
                else
                {
                    return BadRequest("sefdir");
                }
            }
            else
            {
                return BadRequest("--> Incorrect Creadentioan");
            }
        }

        [HttpGet]
        public async Task<User> GetUserInfo(string username,string password)
        {
            return await db.User.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
        }


    }
}

