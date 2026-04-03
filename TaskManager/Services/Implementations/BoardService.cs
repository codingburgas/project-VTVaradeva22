using TaskManager.Models.Entities;
using TaskManager.Repositories;
using TaskManager.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManager.Services.Implementations
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _repository;

        public BoardService(IBoardRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Board>> GetAllBoardsAsync() => await _repository.GetAllAsync();

        public async Task<Board> GetBoardByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task AddBoardAsync(Board board) => await _repository.AddAsync(board);

        public async Task UpdateBoardAsync(Board board) => await _repository.UpdateAsync(board);

        public async Task DeleteBoardAsync(int id) => await _repository.DeleteAsync(id);
    }
}

