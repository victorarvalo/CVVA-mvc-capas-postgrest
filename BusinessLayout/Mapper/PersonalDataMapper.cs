using AutoMapper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;

namespace BusinessLayout.Mapper
{
    public static class PersonalDataMapper
    {
        public static T ResolveJson<T>(this JObject jobj, string target)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jobj.SelectToken(target).ToString());
        }

        public static ModelsBusinessLayout.PersonalDataBL PDDLtoPDBL(ModelsDataLayout.PersonalDatum personalDatum)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.PersonalDatum, ModelsBusinessLayout.PersonalDataBL>()
                .ForMember(x => x.IdPersonalData, y => y.MapFrom("IdPersonalData"));

            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<ModelsDataLayout.PersonalDatum, ModelsBusinessLayout.PersonalDataBL>(personalDatum);
        }
    }
}
