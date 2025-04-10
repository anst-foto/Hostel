using System.Collections.ObjectModel;
using Hostel.Desktop.Views;

namespace Hostel.Desktop.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    public ObservableCollection<Page> Pages { get; set; } =
    [
        new MainView(), new AboutView(), new AddView()
    ];

    private Page _currentPage;
    public Page CurrentPage
    {
        get => _currentPage;
        set
        {
            if (!SetField(ref _currentPage, value)) return;

            if (value is AboutView aboutView)
            {
                (aboutView.DataContext as AboutViewModel)!.Room = App.Room;
            }

            if (value is MainView mainView)
            {
                (mainView.DataContext as MainViewModel)!.Load();
            }
        }
    }

    public MainWindowViewModel()
    {
        CurrentPage = Pages[0];
    }
}
