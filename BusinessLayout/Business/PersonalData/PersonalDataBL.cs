using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using personal = DataLayout.PersonalData;
using Newtonsoft.Json;

namespace BusinessLayout.Business.PersonalData
{
    public class PersonalDataBL
    {
        public List<ModelsBusinessLayout.PersonalDataBL> GetAllPersonalDataBL()
        {
            personal.PersonalDataDB personal = new personal.PersonalDataDB();
            List<ModelsDataLayout.PersonalDatum> data = personal.GetAllPersonalData();
            try
            {
                List<ModelsBusinessLayout.PersonalDataBL> personals = new List<ModelsBusinessLayout.PersonalDataBL>();
                foreach(ModelsDataLayout.PersonalDatum dat in data)
                {
                    ModelsBusinessLayout.PersonalDataBL personal1 =
                        JsonConvert.DeserializeObject<ModelsBusinessLayout.PersonalDataBL>(dat.DataPersonal);
                    ModelsBusinessLayout.PersonalDataBL personal2 =
                        Mapper.PersonalDataMapper.PDDLtoPDBL(dat);
                    personal1.IdPersonalData = personal2.IdPersonalData;
                    personals.Add(personal1);
                }
                return personals;
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
