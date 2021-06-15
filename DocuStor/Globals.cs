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
        public static int UserId;

        public static string FileTitle;
        public static string FilePath;
        public static string FileTitleWithoutExtension;

        public static string Document;

        public static string loadQuery = "SELECT d.Id, d.Title, d.Extension, c.Name as 'Document Category', d.ModifiedAt, um.Name as ModifiedBy, d.CreatedAt, u.Name as CreatedBy FROM Documents d LEFT JOIN Users u ON d.CreatedById = u.Id LEFT JOIN DocumentCategories c ON d.CategoryId = c.Id LEFT JOIN Users um ON d.ModifiedById = um.Id ORDER BY d.CreatedAt DESC";
            
        public static string searchQuery = "SELECT d.Id, d.Title, d.Extension, c.Name as 'Document Category', d.ModifiedAt, um.Name as ModifiedBy, d.CreatedAt, u.Name as CreatedBy FROM Documents d LEFT JOIN Users u ON d.CreatedById = u.Id LEFT JOIN DocumentCategories c ON d.CategoryId = c.Id LEFT JOIN Users um ON d.ModifiedById = um.Id WHERE Title LIKE '%' + @searchKey + '%' OR Description LIKE '%' + @searchKey + '%'  ORDER BY d.CreatedAt DESC";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = OF01SD610\SQLEXPRESS; Initial Catalog = DataStor; Integrated Security = True; Pooling = False;");
        }
    }
}
