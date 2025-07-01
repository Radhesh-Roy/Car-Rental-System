using CarRentalSystem.DatabaseContext;
using CarRentalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data= await _context.Set<Admin>().AsNoTracking().ToListAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new Admin());
            }
            else
            {
                var data = await _context.Set<Admin>().FindAsync(id);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(int id, Admin admin) 
        {
            if (id == 0)
            {
                if (ModelState.IsValid)
                {
                    await _context.Set<Admin>().AddAsync(admin);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                _context.Set<Admin>().Update(admin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        [HttpGet]
        public async Task<IActionResult>Delete(int id)
        {
            if(id != 0) {
                var admin = await _context.Set<Admin>().FindAsync(id);

                if (id != 0)
                {
                    _context.Set<Admin>().Remove(admin);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return RedirectToAction("Index");
        }

    }
}
