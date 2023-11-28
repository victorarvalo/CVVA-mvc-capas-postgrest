using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsBusinessLayout = BusinessLayout.Models;
using Business = BusinessLayout.Business;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceData : ControllerBase
    {
        [HttpGet]
        public List<ModelsBusinessLayout.ExperienceDataBL> GetAllExperienceData()
        {
            Business.ExperienceData.ExperienceDataBL experienceDataBL = new Business.ExperienceData.ExperienceDataBL();
            return experienceDataBL.GetAllExperienceDataBL() ;
        }
    }
}
