
using Flexi.Business.Business.DB;
using System.Collections.Generic;
using Flexi.Model.DM;

namespace Flexi.WebUI.Utility
{
    public class DataManagement
    {
        public static List<DMDefinition> DMList()
        {
            QueryManager qm = new QueryManager();
            return qm.GetQueryResultDirect<DMDefinition>("SELECT * FROM dmdefinition where status=1");

        }
    }
}