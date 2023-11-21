using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayout.Models
{
    public class EducationDataBL
    {
        public int IdEducationData { get; set; }
        public int? IdTypeTraining { get; set; }

        public int? IdModalityTraining { get; set; }
        public string title { get; set; }
        public string institution { get; set; }
        public string starDate { get; set; }
        public string finishDate { get; set; }
        public string summary { get; set; }
    }
}
