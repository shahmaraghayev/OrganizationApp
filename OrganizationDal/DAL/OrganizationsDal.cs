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
  public   class OrganizationsDal:BaseDal
    {
        public int Insert(Organization organization)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Name", 50, organization.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@Status", organization.Status, DbType.Int32));
            int lastId = 0;
            sqlHelper.Insert("INSERT INTO Organizations(Name,Status) VALUES (@Name,@Status)",
                CommandType.Text, parameters.ToArray(), out lastId);

            return lastId;
        }

        public void Update(Organization organization)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", organization.Id, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@Name", 50, organization.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@Status", organization.Status, DbType.Int32));

            sqlHelper.Update("UPDATE Organizations SET Name =@Name,Status=@Status WHERE Id = @Id",
                CommandType.Text, parameters.ToArray());
        }

        public void Delete(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            sqlHelper.Delete("DELETE FROM Organizations WHERE Id = @Id",
                CommandType.Text, parameters.ToArray());
        }

        public Organization GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name,Status FROM Organizations WHERE Id=@Id",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var organization = new Organization();
                while (dataReader.Read())
                {
                    organization.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    organization.Name = dataReader["Name"].ToString();
                    organization.Status = dataReader["Status"] == System.DBNull.Value ? default(int) : (int)dataReader["Status"];
                 
                }

                return organization;
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
        public IEnumerable<OrganizationViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("AllOrganizations", CommandType.StoredProcedure, null, out connection);

            try
            {
                var organizations = new List<OrganizationViewModel>();
                while (dataReader.Read())
                {
                    var organization = new OrganizationViewModel();
                    organization.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    organization.Name = dataReader["Name"].ToString();
                  
                    organization.Status = Convert.ToInt32(dataReader["Status"].ToString());
                    organizations.Add(organization);
                }

                return organizations;
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
