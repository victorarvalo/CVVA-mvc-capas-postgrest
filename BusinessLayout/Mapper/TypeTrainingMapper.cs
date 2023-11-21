using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using AutoMapper;

namespace BusinessLayout.Mapper
{
    public static class TypeTrainingMapper
    {
        public static List<ModelsBusinessLayout.TypeTrainingBL> MTDLtoMTBL(List<ModelsDataLayout.TypeTraining> typeTraining)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.TypeTraining, ModelsBusinessLayout.TypeTrainingBL>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ModelsDataLayout.TypeTraining>, List<ModelsBusinessLayout.TypeTrainingBL>>(typeTraining);
        }
    }
}
