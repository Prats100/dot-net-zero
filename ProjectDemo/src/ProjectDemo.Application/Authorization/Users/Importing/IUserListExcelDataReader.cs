using System.Collections.Generic;
using ProjectDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace ProjectDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
