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
    public class DonViHanhChinhController : Controller
    {
        private readonly ILogger<DonViHanhChinhController> _logger;
        private readonly ApplicationDBContext _context;
        public DonViHanhChinhController(ILogger<DonViHanhChinhController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var donViHanhChinh = this._context.DonViHanhChinh.ToList();
            return View(donViHanhChinh);
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
        public async Task<IActionResult> Create(DonViHanhChinh requestData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestData);
                await _context.SaveChangesAsync();
                return Redirect("/DonViHanhChinh/Index");
            }
            return View(requestData);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViHanhChinh = await _context.DonViHanhChinh.FindAsync(id);
            if (donViHanhChinh == null)
            {
                return NotFound();
            }
            return View(donViHanhChinh);
        }

        // POST
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DonViHanhChinh requestData)
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
                    if (!DonViHanhChinhExists(requestData.Id))
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

        // GET
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViHanhChinh = await _context.DonViHanhChinh
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donViHanhChinh == null)
            {
                return NotFound();
            }

            return View(donViHanhChinh);
        }

        // POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donViHanhChinh = await _context.DonViHanhChinh.FindAsync(id);
            _context.DonViHanhChinh.Remove(donViHanhChinh);
            await _context.SaveChangesAsync();
            return Redirect("/DonViHanhChinh/Index");
        }

        private bool DonViHanhChinhExists(int id)
        {
            return _context.DonViHanhChinh.Any(e => e.Id == id);
        }
    }
}
