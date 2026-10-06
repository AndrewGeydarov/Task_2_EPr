using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using Task_2_EPr.ViewModels;

namespace Task_2_EPr.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Enter_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainViewModel viewModel = new MainViewModel();
        viewModel.UserName = $"{NameTB.Text} {LastNameTB.Text}";
        var navWindow = new NavigationWindow() { DataContext = viewModel };
        navWindow.Show();
        this.Close();
    }
}