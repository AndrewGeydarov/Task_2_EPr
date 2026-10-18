using Avalonia.Controls;
using Task_2_EPr.Services;
using Task_2_EPr.ViewModels;

namespace Task_2_EPr.Views;

public partial class MainWindow : Window
{
    public MainWindow() => InitializeComponent();

    private void Enter_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(LoginTB.Text) || string.IsNullOrEmpty(PasswordTB.Text))
        {
            ErrorTB.Text = "Введите логин и пароль.";
            return;
        }
        if (!DatabaseService.Authenticate(LoginTB.Text, PasswordTB.Text, out var fullName))
        {
            ErrorTB.Text = "Неверный логин или пароль.";
            return;
        }
        var viewModel = new MainViewModel { UserName = fullName };
        var navWindow = new NavigationWindow { DataContext = viewModel };
        navWindow.Show();
        Close();
    }
}
