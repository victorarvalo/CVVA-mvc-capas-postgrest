using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.ModalityTraining
{
    public class ModalityTrainingDB
    {
        public List<Models.ModalityTraining> GetAllModalityTrainig()
        {
            try
            {
                using(CvdataBaseContext db =  new CvdataBaseContext())
                {
                    List<Models.ModalityTraining> data = new List<Models.ModalityTraining>();
                    data = db.ModalityTrainings.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
