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
  public  class CommonDal:BaseDal
    {
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
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetOrganizationsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Organizations WHERE Status = 1",
                CommandType.Text, null, out connection);

            try
            {
                var organizations = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var organization = new IdNameViewModel();
                    organization.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    organization.Name = dataReader["Name"].ToString();
                    organizations.Add(organization);
                }

                return organizations;
            }
            catch (Exception ex)
            {
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

        public IEnumerable<IdNameViewModel> GetPersonnelsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Personnels WHERE Status = 1",
                CommandType.Text, null, out connection);

            try
            {
                var personnels = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var personnel = new IdNameViewModel();
                    personnel.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    personnel.Name = dataReader["Name"].ToString();
                    personnels.Add(personnel);
                }

                return personnels;
            }
            catch (Exception ex)
            {
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetUsersByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Users WHERE Status = 1",
                CommandType.Text, null, out connection);

            try
            {
                var users = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var user = new IdNameViewModel();
                  user.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    user.Name = dataReader["Name"].ToString();
                    users.Add(user);
                }

                return users;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetRolesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Roles ",
                CommandType.Text, null, out connection);

            try
            {
                var roles = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var role = new IdNameViewModel();
                   role.Id = Convert.ToInt32(dataReader["Id"].ToString());
                   role.Name = dataReader["Name"].ToString();
                   roles.Add(role);
                }

                return roles;
            }
            catch (Exception ex)
            {
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetUsersRolesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,UserId,RoleId From UsersRoles ",
                CommandType.Text, null, out connection);

            try
            {
                var usersRoles = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var userRole = new IdNameViewModel();
                    userRole.Id = Convert.ToInt32(dataReader["Id"].ToString());


                    usersRoles.Add(userRole);
                }

                return usersRoles;
            }
            catch (Exception ex)
            {
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
