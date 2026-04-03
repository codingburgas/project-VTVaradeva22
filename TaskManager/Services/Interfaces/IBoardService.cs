using TaskManager.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManager.Services.Interfaces
{
    public interface IBoardService
    {
        Task<IEnumerable<Board>> GetAllBoardsAsync();
        Task<Board> GetBoardByIdAsync(int id);
        Task AddBoardAsync(Board board);
        Task UpdateBoardAsync(Board board);
        Task DeleteBoardAsync(int id);
    }
}
