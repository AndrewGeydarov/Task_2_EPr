using Avalonia.Controls;
using Task_2_EPr.ViewModels;
using Task_2_EPr.Views;

namespace Task_2_EPr;

public partial class NavigationWindow : Window
{
    private Button? ChosenButton { get; set; }

    public NavigationWindow()
    {
        InitializeComponent();
        DesignSelectedButton(Review);
        MainPageCC.Content = new ReviewPage();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var selectedButton = sender as Button ?? new Button();
        DesignSelectedButton(selectedButton);
        switch (selectedButton.Name)
        {
            case "Review": MainPageCC.Content = new ReviewPage(); break;
            case "Projects": MainPageCC.Content = new ProjectsPage(); break;
            case "Tasks": MainPageCC.Content = new TasksPage(); break;
            case "Calendar": MainPageCC.Content = new CalendarPage(); break;
            case "Team": MainPageCC.Content = new TeamPage(); break;
            case "Settings": MainPageCC.Content = new SettingsPage(); break;
            case "Exit":
                new MainWindow().Show();
                Close();
                break;
        }
    }

    private void DesignSelectedButton(Button button)
    {
        if (ChosenButton?.Name == button.Name) return;
        ChosenButton?.Classes.Remove("selected");
        ChosenButton = button;
        ChosenButton.Classes.Add("selected");
    }
}
