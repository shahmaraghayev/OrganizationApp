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
   public class UsersDal:BaseDal
    {
        Logger logger;
        public UsersDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
        public int Insert(User users)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Name", 50, users.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@Password", 50, users.Password, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@Status", users.Status, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@PersonnelId", users.PersonnelId, DbType.Int32)); int lastId = 0;
            sqlHelper.Insert("INSERT INTO Users(Name,Password,Status,PersonnelId) VALUES (@Name,@Password,@Status,@PersonnelId)",
                CommandType.Text, parameters.ToArray(), out lastId);

            return lastId;
        }

        public void Update(User users)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Id", users.Id, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Name", 50, users.Name, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@Password", 50, users.Password, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@Status", users.Status, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@PersonnelId", users.PersonnelId, DbType.Int32));

                sqlHelper.Update("UPDATE Users SET Name =@Name,PersonnelId=@PersonnelId,Status=@Status,Password=@Password WHERE Id = @Id",
                    CommandType.Text, parameters.ToArray());
            }
            catch (Exception exp)
            {
                logger.Error(exp,"User update");
                throw;
            }
           
        }

        public void Delete(int id)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

                sqlHelper.Delete("DELETE FROM Users WHERE Id = @Id",
                    CommandType.Text, parameters.ToArray());
            }
            catch (Exception exp)
            {
                logger.Error(exp, "User Delete");
                throw;
            }
            
        }

        public User GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name,Password,Status,PersonnelId FROM Users WHERE Id=@Id",
               
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var users = new User();
                while (dataReader.Read())
                {
                    users.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    users.Name = dataReader["Name"].ToString();
                    users.Password = dataReader["Password"].ToString();
                    users.Status = dataReader["Status"] == System.DBNull.Value ? default(int) : (int)dataReader["Status"];
                    users.PersonnelId = dataReader["PersonnelId"] == System.DBNull.Value ? default(int) : (int)dataReader["PersonnelId"];
                }

                return users;
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

        public List<UsersViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("AllUsers", CommandType.StoredProcedure, null, out connection);

            try
            {
                var users = new List<UsersViewModel>(); //list collection UsersViewModel
                while (dataReader.Read())
               {
                var user = new UsersViewModel();
                    user.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    user.Name = dataReader["Name"].ToString();
                    user.Password = dataReader["Password"].ToString();
                    user.PersonnelName = dataReader["PersonnelName"].ToString();
                    user.Status = Convert.ToInt32(dataReader["Status"].ToString());
                    users.Add(user);
                }

                return users;
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
