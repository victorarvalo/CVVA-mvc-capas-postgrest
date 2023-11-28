using Newtonsoft.Json.Linq;
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
    public static class ExperienceDataMapper
    {
        public static T ResolveJson<T>(this JObject jobj, string target)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jobj.SelectToken(target).ToString());
        }

        public static ModelsBusinessLayout.ExperienceDataBL EDDLtoEDBL(ModelsDataLayout.ExperienceDatum experienceDatum)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.ExperienceDatum, ModelsBusinessLayout.ExperienceDataBL>()
                .ForMember(x => x.IdExperienceData, y => y.MapFrom("IdExperienceData"));
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<ModelsDataLayout.ExperienceDatum, ModelsBusinessLayout.ExperienceDataBL>(experienceDatum);
        }
    }
}
