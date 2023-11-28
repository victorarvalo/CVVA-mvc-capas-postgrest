using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;

namespace BusinessLayout.Mapper
{
    public static class ModalityTrainingMapper
    {
        public static List<ModelsBusinessLayout.ModalityTrainingBL> MTDLtoMTBL(List<ModelsDataLayout.ModalityTraining> modalityTrainings)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.ModalityTraining, ModelsBusinessLayout.ModalityTrainingBL>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<ModelsDataLayout.ModalityTraining>, List<ModelsBusinessLayout.ModalityTrainingBL>>(modalityTrainings);
        }
    }
}
