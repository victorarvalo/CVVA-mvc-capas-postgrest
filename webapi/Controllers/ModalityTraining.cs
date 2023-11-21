using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBusiness = BusinessLayout.Models;
using Business = BusinessLayout.Business;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModalityTraining : ControllerBase
    {
        [HttpGet]
        public List<ModelBusiness.ModalityTrainingBL> GetAllModalityTraining()
        {
            Business.ModalityTraining.ModalityTrainingBL modalityTraining = new Business.ModalityTraining.ModalityTrainingBL();
            return modalityTraining.GetAllModalityTraining();
        }

    }
}
