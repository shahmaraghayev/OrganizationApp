using NLog;
using OrganizationDal.Domain;
using OrganizationDal.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.DAL
{
  public  class UsersRolesDal:BaseDal
    {
        Logger logger;
        public UsersRolesDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public int Insert(UserRole userRole)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@UserId", userRole.UserId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@RoleId", userRole.RoleId, DbType.Int32));
                int lastId = 0;
                sqlHelper.Insert("INSERT INTO UsersRoles(UserId,RoleId) VALUES (@UserId,@RoleId)",
                    CommandType.Text, parameters.ToArray(), out lastId);

                return lastId;
            }
            catch (Exception exp)
            {
                logger.Error(exp,"Insert UserRole");
                throw;
            }
          
        }

        public void Update(UserRole userRole)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Id", userRole.Id, DbType.Int32));

                parameters.Add(sqlHelper.CreateParameter("@UserId", userRole.UserId, DbType.Int32));

                parameters.Add(sqlHelper.CreateParameter("@RoleId", userRole.RoleId, DbType.Int32));

                sqlHelper.Update("UPDATE UsersRoles SET UserId=@UserId,RoleId=@RoleId WHERE Id = @Id",
                    CommandType.Text, parameters.ToArray());
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Update UserRole");
                throw;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

                sqlHelper.Delete("DELETE FROM UsersRoles WHERE Id = @Id",
                    CommandType.Text, parameters.ToArray());
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Delete UserRole");
                throw;
            }
           
        }

        public UserRole GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("SELECT Id,UserId,RoleId FROM UsersRoles WHERE Id=@Id",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var userRole= new UserRole();
                while (dataReader.Read())
                {
                    userRole.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                 
                    userRole.UserId = dataReader["UserId"] == System.DBNull.Value ? default(int) : (int)dataReader["UserId"];
                    userRole.RoleId = dataReader["RoleId"] == System.DBNull.Value ? default(int) : (int)dataReader["RoleId"];
                }

                return userRole;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Update GetById");
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

        public IEnumerable<UserRoleViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("AllUsersRoles", CommandType.StoredProcedure, null, out connection);

            try
            {
                var userRole = new List<UserRoleViewModel>();
                while (dataReader.Read())
                {
                    var user = new UserRoleViewModel();
                    user.Id = Convert.ToInt32(dataReader["Id"].ToString());
                   
                   user.UserName = dataReader["UserName"].ToString();
                    user.RoleName = dataReader["RoleName"].ToString();  
                 
             
                    userRole.Add(user);
                }

                return userRole;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "UserRole GetAll");
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

    }
}
