using System.Windows.Input;
using Hostel.Desktop.Models;

namespace Hostel.Desktop.ViewModels;

public class AddViewModel : BasePageViewModel
{
    private string? _name;
    public string? Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    private string? _description;
    public string? Description
    {
        get => _description;
        set => SetField(ref _description, value);
    }

    private decimal? _price;
    public decimal? Price
    {
        get => _price;
        set => SetField(ref _price, value);
    }

    public ICommand SaveCommand { get; }
    public ICommand ClearCommand { get; }

    public AddViewModel()
    {
        Title = "Добавление нового номера";

        SaveCommand = new LambdaCommand(
            execute: _ => Save(),
            canExecute: _ => !string.IsNullOrEmpty(Name) &&
                             !string.IsNullOrEmpty(Description) &&
                             Price is not null);

        ClearCommand = new LambdaCommand(
            execute: _ => Clear(),
            canExecute: _ => !string.IsNullOrEmpty(Name) ||
                             !string.IsNullOrEmpty(Description) ||
                             Price is not null);
    }

    private void Save()
    {
        var room = new Room()
        {
            Name = Name!,
            Description = Description!,
            Price = Price!.Value
        };
        var context = new DataContext();
        context.Rooms.Add(room);
        context.SaveChanges();

        Clear();
    }

    private void Clear()
    {
        Name = null;
        Description = null;
        Price = null;
    }
}
