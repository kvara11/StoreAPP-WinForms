using System;
using System.Collections.Generic;
using System.Text;
using Store.Domain;
using System.Data;
using System.Data.SqlClient;

namespace Store.Repository
{
    public class UserRepository : BaseRepository
    {

        public int Login(string username, string password)
        {
            _database.GetConnction();

            var parameter = CustomSqlParameter("@responseID");

            _database.ExecuteNonQuery(
                "UserLogin_SP",
                CommandType.StoredProcedure,
                new SqlParameter("@Username", $"{username}"),
                new SqlParameter("@Password", $"{password}"),
                parameter
                //new SqlParameter("@responseMessage", SqlDbType.NVarChar) {Direction = ParameterDirection.Output, Size = 100}
                );

            return (int)parameter.Value;
        }
        public void Add(User user)
        {
            
        }

        public void Edit(User user)
        {

        }

        public void Delete(User user)
        {

        }

        public SqlParameter CustomSqlParameter(string responseID)
        {
            var outparameter = new SqlParameter();
            outparameter.ParameterName = responseID;
            outparameter.SqlDbType = SqlDbType.Int;
            outparameter.Direction = ParameterDirection.Output;
            return outparameter;
        }
    }
}
