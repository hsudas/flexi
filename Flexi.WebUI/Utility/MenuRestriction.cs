using Flexi.Business.Business.DB;
using Flexi.Model.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace Flexi.WebUI.Utility
{
    public class MenuRestriction
    {
        public static bool CheckUserMenuAuth(string userid,HttpContextBase rc)
        {
            
           
            var rd = rc.Request.RequestContext.RouteData;
            string currentAction = rd.Values["action"].ToString();
            QueryManager qm = new QueryManager(ConnectionStringManager.ProdConnectionString);
            List<IDataParameter> lstprm = new List<IDataParameter>();
            if (currentAction == "BaseReport")
            {

                currentAction = rc.Request.QueryString["ReportName"];
            }
            lstprm.Add(new CustomParameter("UserId", userid));
            lstprm.Add(new CustomParameter("MenuName", currentAction));
            List<int> lst = qm.GetQueryResult<int>("CheckUserMenu", lstprm);
            if (lst[0] > 0)
            {
                return true;
            }
            return false;
        }
    }
}
