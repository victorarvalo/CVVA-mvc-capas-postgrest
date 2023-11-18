using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.EducationData
{
    public class EducationDataDB
    {
        public List<EducationDatum> GetAllEducationData()
        {
            try
            {
                using (CvdataBaseContext db = new CvdataBaseContext())
                {
                    List<EducationDatum> data = new List<EducationDatum>();
                    data = db.EducationData.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
