using System.Configuration;

namespace Teszt
{
    static class ConnectionStringHelper
    {
        static public string DefaultConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            }
        }
    }
}
