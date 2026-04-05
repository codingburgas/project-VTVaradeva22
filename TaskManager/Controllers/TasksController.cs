using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Context;
using TaskManager.Models.Entities;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _context.Tasks.Include(t => t.Board).ToListAsync();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (!ModelState.IsValid)
                return View(task);

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

