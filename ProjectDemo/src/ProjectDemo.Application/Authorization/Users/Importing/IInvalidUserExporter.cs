using System.Collections.Generic;
using ProjectDemo.Authorization.Users.Importing.Dto;
using ProjectDemo.Dto;

namespace ProjectDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
