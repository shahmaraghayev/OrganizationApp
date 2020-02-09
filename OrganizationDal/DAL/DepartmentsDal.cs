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
    public class DepartmentsDal:BaseDal
    {
        public int Insert(Department department)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Name", 50, department.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@TopId", department.TopId, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@Status", department.Status, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@OrganizationId", department.OrganizationId, DbType.Int32));            int lastId = 0;
            sqlHelper.Insert("INSERT INTO Departments(Name,OrganizationId,Status,TopId) VALUES (@Name,@OrganizationId,@Status,@TopId)",
                CommandType.Text, parameters.ToArray(), out lastId);

            return lastId;
        }

        public void Update(Department department)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", department.Id, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@Name", 50, department.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@TopId", department.TopId, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@Status", department.Status, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@OrganizationId", department.OrganizationId, DbType.Int32));

            sqlHelper.Update("UPDATE Departments SET Name =@Name,OrganizationId=@OrganizationId,Status=@Status,TopId=@TopId WHERE Id = @Id", 
                CommandType.Text, parameters.ToArray());
        }

        public void Delete(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            sqlHelper.Delete("DELETE FROM Departments WHERE Id = @Id", 
                CommandType.Text, parameters.ToArray());
        }

        public Department GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name,Status,TopId,OrganizationId FROM Departments WHERE Id=@Id", 
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var department = new Department();
                while (dataReader.Read())
                {
                    department.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    department.Name = dataReader["Name"].ToString();
                    department.Status = dataReader["Status"] == System.DBNull.Value ? default(int) : (int)dataReader["Status"];
                    department.TopId = dataReader["TopId"] == System.DBNull.Value ? default(int) : (int)dataReader["TopId"];
                    department.OrganizationId = dataReader["OrganizationId"] == System.DBNull.Value ? default(int) : (int)dataReader["OrganizationId"];
                }

                return department;
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

        public IEnumerable<DepartmentViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("AllDepartments", CommandType.StoredProcedure, null, out connection);

            try
            {
                var departments = new List<DepartmentViewModel>();
                while (dataReader.Read())
                {
                    var department = new DepartmentViewModel();
                    department.Id =Convert.ToInt32(dataReader["Id"].ToString());
                    department.Name =dataReader["Name"].ToString();
                    department.TopName = dataReader["TopName"].ToString();
                    department.OrganizationName = dataReader["OrganizationName"].ToString();
                    department.TopName = dataReader["TopName"].ToString();
                    department.Status = Convert.ToInt32(dataReader["Status"].ToString());
                    departments.Add(department);
                }

                return departments;
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
        public IEnumerable<IdNameViewModel> GetDepartmentsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Departments WHERE Status = 1",
                CommandType.Text, null, out connection);

            try
            {
                var departments = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var department = new IdNameViewModel();
                    department.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    department.Name = dataReader["Name"].ToString();
                    departments.Add(department);
                }

                return departments;
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
        public IEnumerable<IdNameViewModel> GeOrganizationsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Organizations WHERE Status = 1",
                CommandType.Text, null, out connection);

            try
            {
                var departments = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var department = new IdNameViewModel();
                    department.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    department.Name = dataReader["Name"].ToString();
                    departments.Add(department);
                }

                return departments;
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
