using OrganizationDal.Core;
using System.Configuration;
using System.Data.SqlClient;

namespace OrganizationDal.DAL
{
    public class BaseDal
    {
        public SqlHelper sqlHelper = null;
        public SqlConnection connection = null;

        public BaseDal()
        {
            sqlHelper = new SqlHelper(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());
        }

        public void CloseConnection()
        {
            sqlHelper.CloseConnection(connection);
        }
    }
}
