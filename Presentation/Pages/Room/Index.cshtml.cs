using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository.Interfaces;

namespace Presentation.Pages.Room;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IRoomRepository _roomRepository;
    public IndexModel(
        ILogger<IndexModel> logger,
        IRoomRepository roomRepository)
    {
        _logger = logger;
        _roomRepository = roomRepository;
    }

    public JsonResult OnGet()
    {
        return new JsonResult(_roomRepository.GetAll());
    }
}
