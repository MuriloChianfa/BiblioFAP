using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiblioFAP.Conf;
using BiblioFAP.Models;

namespace BiblioFAP.Controllers
{
    [Route("api/Login")]
    [ApiController]
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
            return Ok(login);
        }
    }
}
