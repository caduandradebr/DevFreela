﻿using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
