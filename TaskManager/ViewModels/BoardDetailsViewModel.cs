using TaskManager.Models.DTOs;

namespace TaskManager.ViewModels;

public class BoardDetailsViewModel
{
    public BoardDto Board { get; set; } = new();

    public List<BoardListDto> Lists { get; set; } = [];
}
