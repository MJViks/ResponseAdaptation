using System.Data.SqlClient;

namespace RequestAdaptationFatClient
{
    class DBConnect
    {
        public static string pc = "DESKTOP-TC8892S\\MJVIKS";
        public static string cat = "CarFood";
        public static string ui = "sa";
        public static string Pass = "1234";
        public static SqlConnection sql = new SqlConnection("Data Source = " + pc + "; Initial Catalog = " + cat + ";" +
             "Persist Security Info = true; User ID = " + ui + "; Password = \"" + Pass +"\""); //строка подключения
    }
}