using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        private string mensage;
        public HomeController(IRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            mensage = configuration["HOSTNAME"] ?? "Servidor sem nome";
        }
        public IActionResult Index(){
            ViewBag.Message = mensage;
            return View(_repository.Produtos);
        }
    }
}
