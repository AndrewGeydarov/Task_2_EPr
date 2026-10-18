using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using System.Threading.Tasks;
using Task_2_EPr.ViewModels;
using Task_2_EPr.Views;

namespace Task_2_EPr;

public partial class ProjectsPage : UserControl
{
    public ProjectsPage()
    {
        InitializeComponent();
    }

    private async void AddProject_Click(object? sender, RoutedEventArgs e)
    {
        if (DataContext is not MainViewModel viewModel || TopLevel.GetTopLevel(this) is not Window owner)
            return;

        var project = await new AddProjectWindow().ShowDialog<Project?>(owner);
        if (project is null)
            return;

        project.ProjectNum = viewModel.Projects.Select(p => p.ProjectNum).DefaultIfEmpty(0).Max() + 1;
        viewModel.Projects.Add(project);
    }
}
