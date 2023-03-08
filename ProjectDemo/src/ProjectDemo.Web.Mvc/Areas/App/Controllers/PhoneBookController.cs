using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Web.Areas.App.Models;
using ProjectDemo.Web.Controllers;
using System.Threading.Tasks;

namespace ProjectDemo.Web.Areas.App.Controllers
{
    [Area("App")]
    public class PhoneBookController : ProjectDemoControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PhoneBookController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
     

        public ActionResult Index(GetPeopleInput input) {
            var output = _personAppService.GetPeople(input);
            var model = ObjectMapper.Map<IndexViewModel>(output);
            model.Filter = input.Filter;
            return View(model);
        }
        
        public PartialViewResult CreatePersonModal()
        {
            return PartialView("_CreatePersonModal");
        }

        [HttpPost]
        public async Task<PartialViewResult> AddPhone([FromBody] AddPhoneInput input)
        {
            PhoneInPersonListDto phoneInPersonList = await _personAppService.AddPhone(input);
            var model = new PhoneRowInPersonListViewModel(phoneInPersonList);

            return PartialView("_PhoneRowInPersonList", model);
        }

        public async Task<PartialViewResult> EditPersonModal(int id)
        {
            var output=await _personAppService.GetPersonForEdit(new EntityDto { Id = id });
            var viewModel=ObjectMapper.Map<EditPersonModalViewModel>(output);

            return PartialView("_EditPersonModal",viewModel);
        }

    }
}
