using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Task_2_EPr.Services;

namespace Task_2_EPr.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string userName = "Пользователь";
    public ObservableCollection<Project> Projects { get; set; } = DatabaseService.GetProjects();
    public ObservableCollection<TeamMember> TeamMembers { get; set; } = DatabaseService.GetTeamMembers();
}

public class Project
{
    public int ProjectNum { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
}

public class TeamMember
{
    public int MemberNum { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Patronymic { get; set; } = string.Empty;
    public string BirthDate { get; set; } = string.Empty;
}
