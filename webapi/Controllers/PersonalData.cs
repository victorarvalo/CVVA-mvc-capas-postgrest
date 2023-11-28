using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsBusinessLayout = BusinessLayout.Models;
using personal = BusinessLayout.Business;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalData : ControllerBase
    {
        [HttpGet]
        public List<ModelsBusinessLayout.PersonalDataBL> GetAllPersonalData()
        {
            personal.PersonalData.PersonalDataBL personal = new personal.PersonalData.PersonalDataBL();
            return personal.GetAllPersonalDataBL();
        }
    }
}
