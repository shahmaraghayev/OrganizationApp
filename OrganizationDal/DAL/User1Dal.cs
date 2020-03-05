﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using OrganizationDal.Domain;
using NLog;

namespace OrganizationDal.DAL
{
    public class User1Dal : BaseDal
    {
        Logger logger;
        public User1Dal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
        public int Insert(User1 user)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@FirstName", 50, user.FirstName, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@LastName", user.LastName, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@Dob", user.Dob, DbType.DateTime));
            parameters.Add(sqlHelper.CreateParameter("@IsActive", 50, user.IsActive, DbType.Boolean));

            int lastId = 0;
            sqlHelper.Insert("DAH_User_Insert", CommandType.StoredProcedure, parameters.ToArray(), out lastId);

            return lastId;
        }

        public void Update(User1 user)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", user.Id, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@FirstName", 50, user.FirstName, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@LastName", user.LastName, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@Dob", user.Dob, DbType.DateTime));

            sqlHelper.Update("DAH_User_Update", CommandType.StoredProcedure, parameters.ToArray());
        }

        public void Delete(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            sqlHelper.Delete("DAH_User_Delete", CommandType.StoredProcedure, parameters.ToArray());
        }

        public User1 GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("DAH_User_GetById", CommandType.StoredProcedure, parameters.ToArray(), out connection);

            try
            {
                var user = new User1();
                while (dataReader.Read())
                {
                    user.FirstName = dataReader["FirstName"].ToString();
                    user.LastName = dataReader["LastName"].ToString();
                }

                return user;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "User1 GetById");
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

        public IEnumerable<User1> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("DAH_User_GetAll", CommandType.StoredProcedure, null, out connection);

            try
            {
                var users = new List<User1>();
                while (dataReader.Read())
                {
                    var user = new User1();
                    user.FirstName = dataReader["FirstName"].ToString();
                    user.LastName = dataReader["LastName"].ToString();

                    users.Add(user);
                }

                return users;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "User1 GetAll");
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

        public IEnumerable<User1> SelectAll()
        {
            var userDataTable = sqlHelper.GetDataTable("DAH_User_GetAll", CommandType.StoredProcedure);
            var users = new List<User1>();

            foreach (DataRow row in userDataTable.Rows)
            {
                var user = new User1();
                user.FirstName = row["FirstName"].ToString();
                user.LastName = row["LastName"].ToString();

                users.Add(user);
            }

            return users;
        }

        public int GetScalarValue()
        {
            object scalarValue = sqlHelper.GetScalarValue("DAH_User_Scalar", CommandType.StoredProcedure);

            return Convert.ToInt32(scalarValue);
        }
    }
}
