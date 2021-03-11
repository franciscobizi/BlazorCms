using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorCms.ViewModels;

namespace BlazorCms.Client.Pages
{
    public partial class Users
    {
        [Inject] IUserViewModel _users { get; set; }
        protected override async Task OnInitializedAsync() => await _users.GetUsers();
    }
}