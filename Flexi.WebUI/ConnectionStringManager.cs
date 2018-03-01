using Flexi.Shared.Helper;

namespace Flexi.WebUI
{
    public class ConnectionStringManager
    {
        public static string ProdConnectionString = ConfigHelper.Instance.GetDBContext();

    }
}
