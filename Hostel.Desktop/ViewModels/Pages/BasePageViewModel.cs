namespace Hostel.Desktop.ViewModels;

public abstract class BasePageViewModel : BaseViewModel
{
    private readonly string _title;
    public required string Title
    {
        get => _title;
        init => SetField(ref _title, value);
    }
}
