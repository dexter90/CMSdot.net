using System;

namespace Definitions.ConnectionStrings
{
    public class ConnStrings
    {
        public static string DevEnvironment()
        {
            return String.Format(@"Server=oem-komputer\CentralPoint;database=Portfolio;User Id=portfolio;Password=portfolio");
        }

        public static string ProdEnvironment()
        {
            return String.Format("");
        }
    }
}
