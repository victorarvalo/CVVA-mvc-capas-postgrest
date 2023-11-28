using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDataLayout = DataLayout.Models;
using ModelsBusinessLayout = BusinessLayout.Models;
using typeTraining = DataLayout.TypeTraining;

namespace BusinessLayout.Business.TypeTraining
{
    public class TypeTrainingBL
    {
        public List<ModelsBusinessLayout.TypeTrainingBL> GetAllModalityTrainingBL()
        {
            typeTraining.TypeTrainingDB typeTraining = new typeTraining.TypeTrainingDB();
            List<ModelsDataLayout.TypeTraining> data = typeTraining.GetAllTypeTraining();
            try
            {
                return Mapper.TypeTrainingMapper.MTDLtoMTBL(data);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
