using AutoMapper;
using DOLPHIN.DTO;
using DOLPHIN.Model;
using DOLPHIN.Repository.UnitOfWorks.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Controllers
{
    public class ToTrinhController : Controller
    {
        private readonly ILogger<ToTrinhController> _logger;
        private readonly ApplicationDBContext _context;
        private readonly IMapper mapper;
        public ToTrinhController(ILogger<ToTrinhController> logger, ApplicationDBContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var data = this._context.ToTrinh
                .Include(x => x.ToChuc)
                .Include(vt => vt.DonViHanhChinh)
                .ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            var toChucs = this._context.ToChuc.ToList();
            ViewBag.DMToChuc = new SelectList(toChucs, "Id", "TenToChuc", null);

            var donViHanhChinhs = this._context.DonViHanhChinh.ToList();
            ViewBag.DMDonViHanhChinh = new SelectList(donViHanhChinhs, "Id", "TenDonViHanhChinh", null);

            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ToTrinhDto requestData)
        {
            if (requestData.MaToChuc <= 0 || requestData.MaDonViHanhChinh <= 0)
            {
                throw new Exception();
            }

            if (ModelState.IsValid)
            {
                // Tạo mẫu quan trắc
                var quanTrac = new QuanTrac()
                {
                    MucNuocDong = requestData.MucNuocDong,
                    MucNuocTinh = requestData.MucNuocTinh,
                    LuuLuong = requestData.LuuLuongNuoc,
                    ChatLuongNuoc = requestData.ChatLuongNuoc
                };
                _context.Add(quanTrac);
                await _context.SaveChangesAsync();

                // Tạo tờ trình
                requestData.NgayTao = DateTime.Now;
                requestData.MaQuanTrac = quanTrac.Id;

                var model = this.mapper.Map<ToTrinh>(requestData);

                _context.Add(model);
                await _context.SaveChangesAsync();
                return Redirect("/ToTrinh/Index");
            }
            return View(requestData);
        }

        // Put: Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id > 0 )
            {
                var toTrinh = this._context.ToTrinh.Where(x => x.Id == id).FirstOrDefault();
                // Status : Da duyet.
                toTrinh.TrangThai = 1;
                _context.Update(toTrinh);
                await _context.SaveChangesAsync();
                return Redirect("/ToTrinh/Index");
            }
            return View();
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ToTrinh requestData)
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
                    if (!ToTrinhExists(requestData.Id))
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

            var og = await _context.ToTrinh
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
            var og = await _context.ToTrinh.FindAsync(id);
            _context.ToTrinh.Remove(og);
            await _context.SaveChangesAsync();
            return Redirect("/ToTrinh/Index");
        }

        private bool ToTrinhExists(int id)
        {
            return _context.ToTrinh.Any(e => e.Id == id);
        }
    }
}
