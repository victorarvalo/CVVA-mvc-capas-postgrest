using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using AutoMapper;
using Newtonsoft.Json.Linq;

namespace BusinessLayout.Mapper
{
    public static class PersonalReferenceMapper
    {
        public static T ResolveJson<T>(this JObject jobj, string target)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jobj.SelectToken(target).ToString());
        }

        public static ModelsBusinessLayout.PersonalReferenceBL PRDLtoPRBL(ModelsDataLayout.PersonalReference personalReference)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModelsDataLayout.PersonalReference, ModelsBusinessLayout.PersonalReferenceBL>()
                .ForMember(x => x.IdPersonalReference, y => y.MapFrom("IdPersonalReference"));

            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<ModelsDataLayout.PersonalReference, ModelsBusinessLayout.PersonalReferenceBL>(personalReference);
        }
    }
}
