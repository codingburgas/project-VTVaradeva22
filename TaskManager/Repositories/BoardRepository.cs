using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.Data.Context;

namespace TaskManager.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private readonly ApplicationDbContext _context;

        public BoardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Board>> GetAllAsync()
        {
            return await _context.Boards.Include(b => b.Tasks).ToListAsync();
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            return await _context.Boards.Include(b => b.Tasks)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddAsync(Board board)
        {
            _context.Boards.Add(board);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Board board)
        {
            _context.Boards.Update(board);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var board = await _context.Boards.FindAsync(id);
            if (board != null)
            {
                _context.Boards.Remove(board);
                await _context.SaveChangesAsync();
            }
        }
    }
}