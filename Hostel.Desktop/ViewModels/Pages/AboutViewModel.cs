using Hostel.Desktop.Models;

namespace Hostel.Desktop.ViewModels;

public class AboutViewModel : BasePageViewModel
{
    private Room? _room;
    public Room? Room
    {
        get => _room;
        set => SetField(ref _room, value);
    }

    public AboutViewModel()
    {
        Title = "Подробнее о номере";
    }
}
