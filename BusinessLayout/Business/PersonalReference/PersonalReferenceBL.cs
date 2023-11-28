using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using personalReference = DataLayout.PersonalReference;
using Newtonsoft.Json;

namespace BusinessLayout.Business.PersonalReference
{
    public class PersonalReferenceBL
    {
        public List<ModelsBusinessLayout.PersonalReferenceBL> GetAllPersonalReferenceBL()
        {
            personalReference.PersonalReferenceDB personalReference = new personalReference.PersonalReferenceDB();
            List<ModelsDataLayout.PersonalReference> data = personalReference.GetAllPersonalReference();
            try
            {
                List<ModelsBusinessLayout.PersonalReferenceBL> personals = new List<ModelsBusinessLayout.PersonalReferenceBL>();
                foreach(ModelsDataLayout.PersonalReference dat in data)
                {
                    ModelsBusinessLayout.PersonalReferenceBL personalReference1 =
                        JsonConvert.DeserializeObject<ModelsBusinessLayout.PersonalReferenceBL>(dat.DataPersonalReference);
                    ModelsBusinessLayout.PersonalReferenceBL personalReference2 =
                        Mapper.PersonalReferenceMapper.PRDLtoPRBL(dat);
                    personalReference1.IdPersonalReference = personalReference2.IdPersonalReference;
                    personals.Add(personalReference1);
                }
                return personals;
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
