using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BiblioFAP.Conf;
using BiblioFAP.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace BiblioFAP.Controllers
{
    [Route("api/Login")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly Database _context;

        public LoginController(Database context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            User user;

            try
            {
                user = _context.User.Where(account => account.Email == login.Email).Where(account => account.Password == login.Password).First();
            }
            catch (InvalidOperationException)
            {
                return BadRequest(new { 
                    error = "Invalid Email or password!" 
                });
            }

            if (user == null)
            {
                return Unauthorized();
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            authClaims.Add(new Claim(ClaimTypes.Role, user.AccessLevelId.ToString()));
            authClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Constants.SECRET));

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return Ok(new
            {
                user,
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo
            });
        }
    }
}
