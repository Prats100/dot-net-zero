using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using ProjectDemo.Authorization.Users.Dto;
using ProjectDemo.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo
{
    public interface IPersonAppService: IApplicationService
    {
        PagedResultDto<PersonListDto> GetPeople(GetPeopleInput input);

        Task CreatePerson(CreatePersonInput input);

        Task DeletePerson(EntityDto input);

        Task DeletePhone(EntityDto<long> input);
        Task<PhoneInPersonListDto> AddPhone(AddPhoneInput input);

        Task<GetPersonForEditOutput> GetPersonForEdit(IEntityDto input);

        Task EditPerson(EditPersonInput input);
    }
    public class GetPeopleInput: PagedAndSortedInputDto, IShouldNormalize
    {
        public string Filter { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name,Surname";
            }

            Filter = Filter?.Trim();
        }
    }

    public class PersonListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }

        public Collection<PhoneInPersonListDto> Phones { get; set; }
    }
    public class CreatePersonInput
    {
        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(PersonConsts.MaxSurnameLength)]
        public string Surname { get; set; }

        [EmailAddress]
        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }

    public class PhoneInPersonListDto : CreationAuditedEntityDto<long>
    {
        public PhoneType Type { get; set; }

        public string Number { get; set; }
    }
    public class AddPhoneInput
    {
        [Range(1, int.MaxValue)]
        public int PersonId { get; set; }

        [Required]
        public PhoneType Type { get; set; }

        [Required]
        [MaxLength(PhoneConsts.MaxNumberLength)]
        public string Number { get; set; }
    }

    public class EditPersonInput
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(PersonConsts.MaxSurnameLength)]
        public string Surname { get; set; }

        [EmailAddress]
        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

    }

    public class GetPersonForEditOutput
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(PersonConsts.MaxSurnameLength)]
        public string Surname { get; set; }

        [EmailAddress]
        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }


    }


}
