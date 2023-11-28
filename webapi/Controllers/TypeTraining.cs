using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsBusinessLayout = BusinessLayout.Models;
using typeTraining = BusinessLayout.Business.TypeTraining;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeTraining : ControllerBase
    {
        [HttpGet]
        public List<ModelsBusinessLayout.TypeTrainingBL> GetAllTypeTrainings()
        {
            typeTraining.TypeTrainingBL typeTraining = new typeTraining.TypeTrainingBL();
            return typeTraining.GetAllModalityTrainingBL();
        }
    }
}
