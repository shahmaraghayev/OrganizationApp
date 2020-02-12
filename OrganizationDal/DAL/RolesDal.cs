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
 public   class RolesDal:BaseDal
    {

        public int Insert(Role roles)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Name", 50,roles.Name, DbType.String));
           

            int lastId = 0;
            sqlHelper.Insert("INSERT INTO Roles(Name) VALUES (@Name)",
               CommandType.Text, parameters.ToArray(), out lastId);
            return lastId;
        }

        public void Update(Role roles)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", roles.Id, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@Name", 50, roles.Name, DbType.String));


            sqlHelper.Update("UPDATE Roles SET Name =@Name WHERE Id = @Id",
                CommandType.Text, parameters.ToArray());
        }

        public void Delete(int id)
        {

            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            sqlHelper.Delete("DELETE FROM Roles WHERE Id = @Id",
                CommandType.Text, parameters.ToArray());
        }

        public Role GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));
            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name FROM Roles", CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var roles = new Role();
                while (dataReader.Read())
                {
                   roles.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    roles.Name = dataReader["Name"].ToString();
                    
                }

                return roles;
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

        public IEnumerable<RolesViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name FROM Roles", CommandType.Text, null, out connection);

            try
            {
                var roles = new List<RolesViewModel>();
                while (dataReader.Read())
                {
                    var role = new RolesViewModel();
                    role.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    role.Name = dataReader["Name"].ToString();
                    roles.Add(role);
                }

                return roles;
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
