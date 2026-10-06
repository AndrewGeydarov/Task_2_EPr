using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace Task_2_EPr;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();
        Theme.IsChecked = Application.Current?.RequestedThemeVariant == ThemeVariant.Dark;
    }

    private void Theme_IsCheckedChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (Application.Current == null) return;
        Application.Current.RequestedThemeVariant = Theme.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}
