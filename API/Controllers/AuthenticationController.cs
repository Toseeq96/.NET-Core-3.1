using DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly MyContext _db;
        public AuthenticationController(MyContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return Ok(_db.Users.Select(x=>x.Id));

        }
    }
}
