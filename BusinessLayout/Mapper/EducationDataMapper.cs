using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using AutoMapper;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace BusinessLayout.Mapper
{
    public static class EducationDataMapper
    {
        public static T ResolveJson<T>(this JObject jobj, string target)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jobj.SelectToken(target).ToString());
        }

        public static ModelsBusinessLayout.EducationDataBL EDDLtoEDBL(ModelsDataLayout.EducationDatum educationDatum)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.EducationDatum, ModelsBusinessLayout.EducationDataBL>()
                .ForMember(x => x.IdEducationData, y => y.MapFrom("IdEducationData"))
                .ForMember(x => x.IdTypeTraining, y => y.MapFrom("IdTypeTraining"))
                .ForMember(x => x.IdModalityTraining, y => y.MapFrom("IdModalityTraining"));
                                
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<ModelsDataLayout.EducationDatum, ModelsBusinessLayout.EducationDataBL>(educationDatum);
        }
    }
       
}
