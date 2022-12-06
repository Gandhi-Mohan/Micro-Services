namespace Micro_Services_Student_App.DBConn
{
   
    public static class ConnectionString
    {

        private static string cName = "Data Source=DESKTOP-FKMCLS3;  Initial Catalog=StudentManagement;Integrated Security=true";

        public static string CName { get => cName; }
    }
}
