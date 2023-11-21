using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using modality = DataLayout.ModalityTraining;

namespace BusinessLayout.Business.ModalityTraining
{
    public class ModalityTrainingBL
    {
        public List<ModelsBusinessLayout.ModalityTrainingBL> GetAllModalityTraining()
        {
            modality.ModalityTrainingDB modality = new modality.ModalityTrainingDB();
            List<ModelsDataLayout.ModalityTraining> data = modality.GetAllModalityTrainig();
            try
            {
                return Mapper.ModalityTrainingMapper.MTDLtoMTBL(data);
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
