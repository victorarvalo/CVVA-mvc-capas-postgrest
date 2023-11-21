using DataLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayout.PersonalReference
{
    public class PersonalReferenceDB
    {
        public List<Models.PersonalReference> GetAllPersonalReference()
        {
            try
            {
                using(CvdataBaseContext db =  new CvdataBaseContext())
                {
                    List<Models.PersonalReference> data = new List<Models.PersonalReference>();
                    data = db.PersonalReferences.ToList();
                    return data;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
