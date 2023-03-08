using System.Collections.Generic;
using ProjectDemo.Authorization.Users.Dto;
using ProjectDemo.Dto;

namespace ProjectDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}