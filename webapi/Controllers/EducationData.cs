using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBusiness = BusinessLayout.Models;
using Business = BusinessLayout.Business;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationData : ControllerBase
    {
        [HttpGet]
        public List<ModelBusiness.EducationDataBL> GetAllEducationData()
        {
            Business.EducationData.EducationDataBL educationDataBL = new Business.EducationData.EducationDataBL();
            List<ModelBusiness.EducationDataBL> educations = educationDataBL.GetAllPersonalDataBL();            
            return educations;
        }        
    }
}
