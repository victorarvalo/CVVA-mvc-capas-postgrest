using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayout.Models
{
    public class PersonalDataBL
    {
        public int IdPersonalData { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string bordDate { get; set; }
        public string bornPlace { get; set; }
        public string idDocument { get; set; }
        public string address { get; set; }
        public string celPhone { get; set; }
        public List<string> email { get; set; }
    }
}
