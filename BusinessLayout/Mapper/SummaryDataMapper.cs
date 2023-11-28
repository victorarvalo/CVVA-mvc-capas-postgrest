using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using AutoMapper;
using DataLayout.Models;

namespace BusinessLayout.Mapper
{
    public static class SummaryDataMapper
    {
        public static List<ModelsBusinessLayout.SummaryDataBL> SDDTtoSDBL(List<ModelsDataLayout.SummaryDatum> summaryData)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.SummaryDatum, ModelsBusinessLayout.SummaryDataBL>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ModelsDataLayout.SummaryDatum>, List<ModelsBusinessLayout.SummaryDataBL>>(summaryData);
        }
    }
}
