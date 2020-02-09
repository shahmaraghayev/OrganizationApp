using OrganizationDal.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.DAL
{
    public class LoginDal : BaseDal
    {
     
        public bool LoginUser(Login f)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@name", f.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@password", f.Password, DbType.String));

            var dataReader = sqlHelper.GetDataReader
                ("SELECT * FROM Users WHERE Name = @name AND Password = @password",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                while (dataReader.Read())
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }
    }
}
