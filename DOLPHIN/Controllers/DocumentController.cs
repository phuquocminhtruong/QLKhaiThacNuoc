using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class DocumentController : Controller
    {
        private readonly ILogger<DocumentController> _logger;
        private readonly ApplicationDBContext _context;
        public DocumentController(ILogger<DocumentController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
