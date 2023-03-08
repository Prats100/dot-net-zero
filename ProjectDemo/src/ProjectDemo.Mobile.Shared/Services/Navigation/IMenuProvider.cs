using System.Collections.Generic;
using MvvmHelpers;
using ProjectDemo.Models.NavigationMenu;

namespace ProjectDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}