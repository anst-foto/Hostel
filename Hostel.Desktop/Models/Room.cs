using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hostel.Desktop.Models;

public class Room : INotifyPropertyChanged
{
    private int _id;
    public int Id
    {
        get => _id;
        set => SetField(ref _id, value);
    }

    private string _name;
    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    private string _description;
    public string Description
    {
        get => _description;
        set => SetField(ref _description, value);
    }

    private decimal _price;
    public decimal Price
    {
        get => _price;
        set => SetField(ref _price, value);
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}
