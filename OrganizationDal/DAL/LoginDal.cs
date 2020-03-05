using NLog;
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
        Logger logger;
        public LoginDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
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

        public  User GetUserByUserName(string UserName)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@UserName", UserName, DbType.String));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name,Password,Status,PersonnelId ,Salt FROM Users WHERE Name=@UserName",

                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var users = new User();
                while (dataReader.Read())
                {
                    users.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    users.Name = dataReader["Name"].ToString();
                    users.Password = dataReader["Password"].ToString();
                    users.Salt = dataReader["Salt"].ToString();
                    users.Status = dataReader["Status"] == System.DBNull.Value ? default(int) : (int)dataReader["Status"];
                    users.PersonnelId = dataReader["PersonnelId"] == System.DBNull.Value ? default(int) : (int)dataReader["PersonnelId"];
                }

                return users;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "GetUserByUserName");
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

    }
}
