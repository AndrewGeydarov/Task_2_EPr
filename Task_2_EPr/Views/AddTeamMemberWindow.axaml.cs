using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using Task_2_EPr.ViewModels;

namespace Task_2_EPr.Views;

public partial class AddTeamMemberWindow : Window
{
    public AddTeamMemberWindow()
    {
        InitializeComponent();
    }

    private void Add_Click(object? sender, RoutedEventArgs e)
    {
        string lastName = LastNameBox.Text?.Trim() ?? string.Empty;
        string firstName = FirstNameBox.Text?.Trim() ?? string.Empty;
        string patronymic = PatronymicBox.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName))
        {
            ErrorText.Text = "Заполните фамилию и имя.";
            ErrorText.IsVisible = true;
            return;
        }

        if (BirthDatePicker.SelectedDate is not { } birthDate)
        {
            ErrorText.Text = "Укажите дату рождения.";
            ErrorText.IsVisible = true;
            return;
        }

        if (birthDate.Date > DateTime.Today)
        {
            ErrorText.Text = "Дата рождения не может быть в будущем.";
            ErrorText.IsVisible = true;
            return;
        }

        Close(new TeamMember
        {
            LastName = lastName,
            Name = firstName,
            Patronymic = patronymic,
            BirthDate = birthDate.ToString("dd.MM.yyyy")
        });
    }

    private void Cancel_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}
