using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.ExperienceData
{
    public class ExperienceDataDB
    {
        public List<ExperienceDatum> GetAllExperienceData()
        {
            try
            {
                using (CvdataBaseContext db = new CvdataBaseContext())
                {
                    List<ExperienceDatum> data = new List<ExperienceDatum>();
                    data = db.ExperienceData.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
