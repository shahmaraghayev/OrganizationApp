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
   
  public  class PersonnelsDal:BaseDal
    {
        Logger logger;
        public PersonnelsDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
        public int Insert(Personnel personnel)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Name", 50, personnel.Name, DbType.String));

                parameters.Add(sqlHelper.CreateParameter("@Surname", 50, personnel.Surname, DbType.String));

                parameters.Add(sqlHelper.CreateParameter("@Status", personnel.Status, DbType.Int32));

                parameters.Add(sqlHelper.CreateParameter("@OrganizationId", personnel.OrganizationId, DbType.Int32)); int lastId = 0;

                parameters.Add(sqlHelper.CreateParameter("@DepartmentId", personnel.DepartmentId, DbType.Int32));

                parameters.Add(sqlHelper.CreateParameter("@Email", 100, personnel.Email, DbType.String));

                sqlHelper.Insert("INSERT INTO Personnels(Name,OrganizationId,Status,DepartmentId,Surname,Email) VALUES (@Name,@OrganizationId,@Status,@DepartmentId,@Surname,@Email)",
                    CommandType.Text, parameters.ToArray(), out lastId);

                return lastId;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Insert Organization");
                throw;
            }
           
        }

        public void Update(Personnel personnel)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Id", personnel.Id, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Name", 50, personnel.Name, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@Surname", 50, personnel.Surname, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@DepartmentId", personnel.DepartmentId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@OrganizationId", personnel.OrganizationId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Status", personnel.Status, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Email", 100, personnel.Email, DbType.String));



                sqlHelper.Update("UPDATE Personnels SET Name =@Name, Surname=@Surname,OrganizationId=@OrganizationId,DepartmentId=@DepartmentId,Status=@Status,Email=@Email WHERE Id = @Id",
                    CommandType.Text, parameters.ToArray());
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Update Organization");
                throw;
            }
           
        }

        public void Delete(int id)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

                sqlHelper.Delete("DELETE FROM Personnels WHERE Id = @Id",
                    CommandType.Text, parameters.ToArray());
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Delete Organization");
                throw;
            }
            
        }

        public Personnel GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name,Status,DepartmentId,OrganizationId,Surname,Email FROM Personnels WHERE Id=@Id",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var personnel = new Personnel();
                while (dataReader.Read())
                {
                    personnel.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    personnel.Name = dataReader["Name"].ToString();
                    personnel.Surname = dataReader["Surname"].ToString();
                    personnel.Email = dataReader["Email"].ToString();
                    personnel.Status = dataReader["Status"] == System.DBNull.Value ? default(int) : (int)dataReader["Status"];
                    personnel.DepartmentId = dataReader["DepartmentId"] == System.DBNull.Value ? default(int) : (int)dataReader["DepartmentId"];
                    personnel.OrganizationId = dataReader["OrganizationId"] == System.DBNull.Value ? default(int) : (int)dataReader["OrganizationId"];
                }

                return personnel;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Personnel GetById");
                throw ;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

        public IEnumerable<PersonnelViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("AllPersonnels", CommandType.StoredProcedure, null, out connection);

            try
            {
                var personnels= new List<PersonnelViewModel>();
                while (dataReader.Read())
                {
                    var personnel = new PersonnelViewModel();
                    personnel.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    personnel.Name = dataReader["Name"].ToString();
                    personnel.Surname = dataReader["Surname"].ToString();
                    personnel.OrganizationName = dataReader["OrganizationName"].ToString();
                    personnel.Departamentname = dataReader["DepartmentName"].ToString();
                    personnel.Email = dataReader["Email"].ToString();
                    personnel.Status = Convert.ToInt32(dataReader["Status"].ToString());
                    personnels.Add(personnel);
                }

                return personnels;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "PersonnelViewModel");
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
