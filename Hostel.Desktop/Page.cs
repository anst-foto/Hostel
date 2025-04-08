using System.Windows.Controls;
using Hostel.Desktop.ViewModels;

namespace Hostel.Desktop;

public class Page : UserControl
{
    public string Title => (this.DataContext as BasePageViewModel)?.Title ?? string.Empty;
}
