using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using Task_2_EPr.ViewModels;
using Task_2_EPr.Views;

namespace Task_2_EPr;

public partial class TeamPage : UserControl
{
    public TeamPage()
    {
        InitializeComponent();
    }

    private async void AddMember_Click(object? sender, RoutedEventArgs e)
    {
        if (DataContext is not MainViewModel viewModel || TopLevel.GetTopLevel(this) is not Window owner)
            return;

        var member = await new AddTeamMemberWindow().ShowDialog<TeamMember?>(owner);
        if (member is null)
            return;

        member.MemberNum = viewModel.TeamMembers.Select(m => m.MemberNum).DefaultIfEmpty(0).Max() + 1;
        viewModel.TeamMembers.Add(member);
    }
}
