using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Flexi.Business.Business
{
    public abstract class BusinessBase
    {
        public int InstitutionId { get; set; }
        public BusinessBase()
        {
            try
            {
                InstitutionId = Convert.ToInt32(ConfigurationManager.AppSettings["institutionId"]);
            }
            catch (Exception)
            {

                InstitutionId = 1;
            }
        }
    }
}
