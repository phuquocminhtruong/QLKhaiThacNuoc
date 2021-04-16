using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class ToChucController : Controller
    {
        private readonly ILogger<ToChucController> _logger;
        private readonly ApplicationDBContext _context;
        public ToChucController(ILogger<ToChucController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var og = this._context.ToChuc.ToList();
            return View(og);
        }
        public IActionResult Create()
        {
            var canBo = this._context.CanBo.ToList();
            ViewBag.DMCanBo = new SelectList(canBo, "Id", "TenCanBo", null);
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ToChuc requestData)
        {
            if (string.IsNullOrEmpty(requestData.TenToChuc) || requestData.MaNhanVienQuanLy <= 0)
            {
                throw new Exception();
            }

            if (ModelState.IsValid)
            {
                _context.Add(requestData);
                await _context.SaveChangesAsync();
                return Redirect("/ToChuc/Index");
            }
            return View(requestData);
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var og = await _context.ToChuc.FindAsync(id);
            if (og == null)
            {
                return NotFound();
            }
            return View(og);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ToChuc requestData)
        {
            if (id != requestData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToChucExists(requestData.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(requestData);
        }

        // GET: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var og = await _context.ToChuc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (og == null)
            {
                return NotFound();
            }

            return View(og);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var og = await _context.ToChuc.FindAsync(id);
            _context.ToChuc.Remove(og);
            await _context.SaveChangesAsync();
            return Redirect("/ToChuc/Index");
        }

        private bool ToChucExists(int id)
        {
            return _context.ToChuc.Any(e => e.Id == id);
        }
    }
}
