using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsBusinessLayout = BusinessLayout.Models;
using summarData = BusinessLayout.Business.SummaryData;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryData : ControllerBase
    {
        [HttpGet]
        public List<ModelsBusinessLayout.SummaryDataBL> GetAllSummaryData()
        {
            summarData.SummaryDataBL summaryDataBL = new summarData.SummaryDataBL();
            return summaryDataBL.GetAllSummaryData();
        }
    }
}
