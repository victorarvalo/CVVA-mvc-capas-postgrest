using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.PersonalData
{
    public class PersonalDataDB
    {
        public List<PersonalDatum> GetAllPersonalData()
        {
            try
            {
                using (CvdataBaseContext db = new CvdataBaseContext())
                {
                    List<PersonalDatum> data = new List<PersonalDatum>();
                    data = db.PersonalData.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
