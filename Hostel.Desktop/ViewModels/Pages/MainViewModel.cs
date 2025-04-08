using System.Collections.ObjectModel;
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

        Rooms.Add(new Room()
        {
            Id = 1,
            Name = "101",
            Description = "lux",
            Price = 1000
        });
        Rooms.Add(new Room()
        {
            Id = 2,
            Name = "102",
            Description = "deluxe",
            Price = 100
        });
    }
}
