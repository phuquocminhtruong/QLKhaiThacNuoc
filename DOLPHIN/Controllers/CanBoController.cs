using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class CanBoController : Controller
    {
        private readonly ILogger<CanBoController> _logger;
        private readonly ApplicationDBContext _context;
        public CanBoController(ILogger<CanBoController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var canBo = this._context.CanBo.ToList();
            return View(canBo);
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CanBo requestData)
        {
            if (string.IsNullOrEmpty(requestData.TenCanBo))
            {
                throw new Exception();
            }

            if (ModelState.IsValid)
            {
                _context.Add(requestData);
                await _context.SaveChangesAsync();
                return Redirect("/CanBo/Index");
            }
            return View(requestData);
        }

        // Put: Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id > 0)
            {
                var canBo = this._context.CanBo.Where(x => x.Id == id).FirstOrDefault();
                // Status : Nghỉ việc
                canBo.TrangThai = 1;
                _context.Update(canBo);
                await _context.SaveChangesAsync();
                return Redirect("/CanBo/Index");
            }
            return View();
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canBo = await _context.CanBo.FindAsync(id);
            if (canBo == null)
            {
                return NotFound();
            }
            return View(canBo);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CanBo requestData)
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
                    if (!CanBoExists(requestData.Id))
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

            var canBo = await _context.CanBo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (canBo == null)
            {
                return NotFound();
            }

            return View(canBo);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categories = await _context.CanBo.FindAsync(id);
            _context.CanBo.Remove(categories);
            await _context.SaveChangesAsync();
            return Redirect("/CanBo/Index");
        }

        private bool CanBoExists(int id)
        {
            return _context.CanBo.Any(e => e.Id == id);
        }
    }
}
