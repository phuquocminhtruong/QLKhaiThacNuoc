using DOLPHIN.DTO;
using DOLPHIN.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LoginController(ApplicationDBContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AccountDto account)
        {
            if (account == null)
            {
                return View();
            }

            if (ModelState.IsValid)
            {
                using (_context)
                {
                    var obj = _context.Account.Where(a => a.UserName.Equals(account.UserName) && a.PassWord.Equals(account.PassWord)).FirstOrDefault();
                    if (obj != null)
                    {
                        var userId = HttpContext.Session.GetString("UserID");
                        userId = obj.UserId.ToString();
                        var userName = HttpContext.Session.GetString("UserName");
                        userName = obj.UserName.ToString();
                        return Redirect("/Home/Index");
                    }
                }
            }
            return View(account);
        }
    }
}
