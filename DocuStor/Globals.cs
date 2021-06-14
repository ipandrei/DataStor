using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuStor
{
    public static class Globals
    {

        public static string Username;
        public static string UserFullName;

        public static string FileTitle;
        public static string FilePath;

        public static string Document;

        public static string loadQuery = "SELECT ID, Title, CreatedAt FROM Documents ORDER BY createdAt DESC";
        public static string searchQuery = "SELECT ID, Title, CreatedAt FROM Documents WHERE Title LIKE '%' + @searchKey + '%' ORDER BY createdAt DESC";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = OF01SD610\SQLEXPRESS; Initial Catalog = DataStor; Integrated Security = True; Pooling = False;");
        }
    }
}
