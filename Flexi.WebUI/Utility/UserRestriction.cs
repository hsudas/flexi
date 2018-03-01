using Flexi.Shared.Helper;
using Dapper;
using Npgsql;
using System.Linq;

namespace Flexi.WebUI.Utility
{
    public class UserRestriction
    {
        public UserRestriction()
        {

        }
        public static string GetUserRestriction(string userName, string menuName)
        {
            NpgsqlConnection con;
            string[] rest = null;
            string conStr = ConfigHelper.Instance.GetDBContext();
            using (con = new NpgsqlConnection(conStr))
            {
                string query = "Select Restriction From AppUserRestriction Where Application = 'Flexi.WebUI' and MenuName = '" + menuName + "' and Username = '" + userName + "'";
                con.Open();
                rest = con.Query<string>(query).ToArray<string>();

            }
            if (rest != null)
            {
                if (rest.Length > 0)
                {
                    return rest[0];
                }
            }
            return "";
        }

    }
}
