using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using ProjectDemo.Dto;

namespace ProjectDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
