using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using summaryData = DataLayout.SummaryData;
using Newtonsoft.Json;

namespace BusinessLayout.Business.SummaryData
{
    public class SummaryDataBL
    {
        public List<ModelsBusinessLayout.SummaryDataBL> GetAllSummaryData()
        {
            try
            {
                summaryData.SummaryDataDB summaryData = new summaryData.SummaryDataDB();
                List<ModelsDataLayout.SummaryDatum> data = summaryData.GetAllSummaryData();
                List<ModelsBusinessLayout.SummaryDataBL> summaries = Mapper.SummaryDataMapper.SDDTtoSDBL(data);
                return summaries;
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
