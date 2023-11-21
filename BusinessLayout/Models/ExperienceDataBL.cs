using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayout.Models
{
    public class ExperienceDataBL
    {
        public int IdExperienceData { get; set; }

        public string enterprise { get; set; }
        public string phone { get; set; }
        public string url { get; set; }
        public string position { get; set; }
        public string summary { get; set; }
        public List<Models.DetailSummaryBL> detailSummary { get; set; }
        public List<Models.SkillBL> skills { get; set; }
        public string startDate { get; set; }
        public string finishDate { get; set; }
    }
}
