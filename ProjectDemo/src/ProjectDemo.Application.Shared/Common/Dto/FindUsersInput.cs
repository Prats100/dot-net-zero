using ProjectDemo.Dto;

namespace ProjectDemo.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }

        public bool ExcludeCurrentUser { get; set; }
    }
}