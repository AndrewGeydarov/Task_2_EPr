using Avalonia.Controls;
using Avalonia.Interactivity;
using Task_2_EPr.ViewModels;

namespace Task_2_EPr.Views;

public partial class AddProjectWindow : Window
{
    public AddProjectWindow()
    {
        InitializeComponent();
    }

    private void Add_Click(object? sender, RoutedEventArgs e)
    {
        string name = ProjectNameBox.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(name))
        {
            ErrorText.Text = "Введите название проекта.";
            ErrorText.IsVisible = true;
            ProjectNameBox.Focus();
            return;
        }

        Close(new Project
        {
            ProjectName = name,
            Date = DeadlinePicker.SelectedDate?.ToString("dd.MM.yyyy") ?? "Не указан"
        });
    }

    private void Cancel_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}
