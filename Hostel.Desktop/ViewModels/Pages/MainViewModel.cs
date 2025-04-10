using System.Collections.ObjectModel;
using System.Linq;
using Hostel.Desktop.Models;

namespace Hostel.Desktop.ViewModels;

public class MainViewModel : BasePageViewModel
{
    public ObservableCollection<Room> Rooms { get; set; } = [];

    private Room? _selectedRoom;
    public Room? SelectedRoom
    {
        get => _selectedRoom;
        set
        {
            if (!SetField(ref _selectedRoom, value)) return;

            App.Room = value;
        }
    }

    public MainViewModel()
    {
        Title = "Список номеров";

        Load();
    }

    public void Load()
    {
        Rooms.Clear();

        var context = new DataContext();
        var rooms = context.Rooms.ToList();
        foreach (var room in rooms)
        {
            Rooms.Add(room);
        }
    }
}
