using Abp.Application.Services.Dto;

namespace ProjectDemo.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}