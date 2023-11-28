using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsBusinessLayout = BusinessLayout.Models;
using personal = BusinessLayout.Business;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalReference : ControllerBase
    {
        [HttpGet]
        public List<ModelsBusinessLayout.PersonalReferenceBL> GetAllPersonalReferences()
        {
            personal.PersonalReference.PersonalReferenceBL personal = new personal.PersonalReference.PersonalReferenceBL();
            return personal.GetAllPersonalReferenceBL();
        }
    }
}
