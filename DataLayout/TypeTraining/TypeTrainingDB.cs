using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.TypeTraining
{
    public class TypeTrainingDB
    {
        public List<Models.TypeTraining> GetAllTypeTraining()
        {
            try
            {
                using(CvdataBaseContext db = new CvdataBaseContext())
                {
                    List<Models.TypeTraining> data = new List<Models.TypeTraining>();
                    data = db.TypeTrainings.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
