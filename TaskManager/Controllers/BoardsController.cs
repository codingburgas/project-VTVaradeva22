using Microsoft.AspNetCore.Mvc;
using TaskManager.Models.Entities;
using TaskManager.Services.Interfaces;

namespace TaskManager.Controllers
{
    public class BoardController : Controller
    {
        private readonly IBoardService _service;

        public BoardController(IBoardService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var boards = await _service.GetAllBoardsAsync();
            return View(boards);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Board board)
        {
            if (!ModelState.IsValid) return View(board);
            await _service.AddBoardAsync(board);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var board = await _service.GetBoardByIdAsync(id);
            if (board == null) return NotFound();
            return View(board);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Board board)
        {
            if (!ModelState.IsValid) return View(board);
            await _service.UpdateBoardAsync(board);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var board = await _service.GetBoardByIdAsync(id);
            if (board == null) return NotFound();
            return View(board);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteBoardAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}