using System;
using System.Collections.Generic;
using System.Text;
using Store.Domain;
using System.Data;
using System.Data.SqlClient;

namespace Store.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public event Action<int> UserLogin;

        public int Login(string username, string password, out string fullName, out string message)
        {
            //var parameter = CustomSqlParameter("@responseID");
            var loggedUserID = new SqlParameter("@LoggedUserID", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var responseMessage = new SqlParameter("@ResponseMessage", SqlDbType.NVarChar, size: 250) { Direction = ParameterDirection.Output };
            var employeeName = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, size: 100) { Direction = ParameterDirection.Output };
            var result = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };

            _database.ExecuteNonQuery(
                "UserLogin_SP",
                CommandType.StoredProcedure,
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                loggedUserID,
                employeeName,
                responseMessage,
                result
            );

            if ((int)result.Value != 0)
            {
                //throw new Exception(responseMessage.Value.ToString());
                message = responseMessage.Value.ToString();
                fullName = null;
                return -1;
            }

            message = null;
            fullName = employeeName.Value.ToString();
            UserLogin?.Invoke((int)loggedUserID.Value);
            return (int)loggedUserID.Value;
        }

        public IEnumerable<short> GetPermissions(int userID)
        {
            var dataTable = _database.GetTable("select Code from GetUserPermissions(@UserID)", new SqlParameter("@UserID", userID));
            foreach (DataRow row in dataTable.Rows)
            {
                yield return (short)row["Code"];
            }
        }
    }
}
