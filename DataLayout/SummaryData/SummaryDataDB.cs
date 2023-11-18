using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.SummaryData
{
    public class SummaryDataDB
    {
        public List<SummaryDatum> GetAllSummaryData()
        {
            try
            {
                using(CvdataBaseContext db = new CvdataBaseContext())
                {
                    List<SummaryDatum> data = new List<SummaryDatum>();
                    data = db.SummaryData.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
