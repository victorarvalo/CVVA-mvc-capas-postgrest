using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using Business = BusinessLayout.Business;
using Personal = DataLayout.EducationData;
using BusinessLayout.Mapper;
using System.Text.Json;

namespace BusinessLayout.Business.EducationData
{
    public class EducationDataBL
    {
        public List<ModelsBusinessLayout.EducationDataBL> GetAllPersonalDataBL()
        {
            try
            {
                Personal.EducationDataDB education = new Personal.EducationDataDB();
                List<ModelsDataLayout.EducationDatum> data = education.GetAllEducationData();
                if(data != null )
                {
                    List<ModelsBusinessLayout.EducationDataBL> educations = new List<ModelsBusinessLayout.EducationDataBL>();
                    foreach(ModelsDataLayout.EducationDatum dat in data)
                    {
                        ModelsBusinessLayout.EducationDataBL educationData =
                        JsonSerializer.Deserialize<ModelsBusinessLayout.EducationDataBL>(dat.DataEducation);
                        ModelsBusinessLayout.EducationDataBL educationData1 =
                        EducationDataMapper.EDDLtoEDBL(dat);
                        educationData.IdEducationData = educationData1.IdEducationData;
                        educationData.IdTypeTraining = educationData1.IdTypeTraining;
                        educationData.IdModalityTraining = educationData1.IdModalityTraining;
                        educations.Add(educationData);
                    }
                    return educations;
                }
                else
                {
                    return null;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
