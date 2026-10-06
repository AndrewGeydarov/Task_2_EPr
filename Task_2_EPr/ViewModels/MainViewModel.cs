using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Task_2_EPr.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string UserName { get; set; } = "Имя Фамилия";
    public ObservableCollection<Project> Projects { get; set; } = new ObservableCollection<Project>()
    {
        new Project()
        {
            ProjectNum = 1,
            ProjectName = "Проект медицинской клиники",
            Date = "12.10.2026"
        },
        new Project()
        {
            ProjectNum = 2,
            ProjectName = "Проект автосервиса",
            Date = "12.10.2026"
        },
        new Project()
        {
            ProjectNum = 3,
            ProjectName = "Просто проект",
            Date = "Когда угодно"
        },
    };
    public ObservableCollection<TeamMember> TeamMembers { get; set; } = new ObservableCollection<TeamMember>()
    {
        new TeamMember()
        {
            MemberNum = 1,
            LastName = "Валиев",
            Name = "Карим",
            Patronymic = "Динарович",
            BirthDate = "11.01.2007"
        },
        new TeamMember()
        {
            MemberNum = 2,
            LastName = "Волков",
            Name = "Данил",
            Patronymic = "Сергеевич",
            BirthDate = "01.02.2006"
        },
        new TeamMember()
        {
            MemberNum = 3,
            LastName = "Чухарев",
            Name = "Леонид",
            Patronymic = "Валерьевич",
            BirthDate = "25.10.2007"
        }
    };
}

public class Project
{
    public int ProjectNum { get; set; }
    public string ProjectName { get; set; }
    public string Date { get; set; }
}

public class TeamMember
{
    public int MemberNum { get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public string BirthDate { get; set; }
}
