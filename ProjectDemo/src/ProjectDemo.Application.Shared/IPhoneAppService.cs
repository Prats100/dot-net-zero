using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo
{
    public interface IPhoneAppService : IApplicationService
    {
        Task DeletePhone(EntityDto<long> input);
    }
    //public class AddPhoneInput
    //{
    //    [Range(1, int.MaxValue)]
    //    public int PersonId { get; set; }

    //    [Required]
    //    public PhoneType Type { get; set; }

    //    [Required]
    //    [MaxLength(PhoneConsts.MaxNumberLength)]
    //    public string Number { get; set; }

    
}

