using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DOLPHIN.Models;
using DOLPHIN.Model;

namespace DOLPHIN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ToTrinhIndex = this._context.ToTrinh.Count();
            ViewBag.CongTrinhKhaiThacIndex = this._context.CongTrinhKhaiThac.Count();
            ViewBag.CanBoQuanLyIndex = this._context.CanBo.Count();
            ViewBag.GiaHanIndex = this._context.SoGiaHan.Count();
            return View();
        }
    }
}
