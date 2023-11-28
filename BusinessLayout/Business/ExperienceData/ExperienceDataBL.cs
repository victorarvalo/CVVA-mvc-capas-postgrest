using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using experience = DataLayout.ExperienceData;
using Newtonsoft.Json;

namespace BusinessLayout.Business.ExperienceData
{
    public class ExperienceDataBL
    {
        public List<ModelsBusinessLayout.ExperienceDataBL> GetAllExperienceDataBL()
        {
            experience.ExperienceDataDB experience = new experience.ExperienceDataDB();
            List<ModelsDataLayout.ExperienceDatum> data = experience.GetAllExperienceData();
            try
            {
                List<ModelsBusinessLayout.ExperienceDataBL> experiences = new List<ModelsBusinessLayout.ExperienceDataBL>();
                foreach(ModelsDataLayout.ExperienceDatum dat in data)
                {
                    ModelsBusinessLayout.ExperienceDataBL experience1 =
                        JsonConvert.DeserializeObject<ModelsBusinessLayout.ExperienceDataBL>(dat.DataExperience);
                    ModelsBusinessLayout.ExperienceDataBL experience2 =
                        Mapper.ExperienceDataMapper.EDDLtoEDBL(dat);
                    experience1.IdExperienceData = experience2.IdExperienceData;
                    experiences.Add(experience1);
                }
                return experiences;
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
