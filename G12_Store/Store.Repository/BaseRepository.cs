using System;
using DatabaseHelper;
using Store.Domain;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Store.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        protected Database _database;

        protected virtual string RecordName => this.GetType().Name.Replace("Repository", "");
        protected virtual string AddProcedureName => $"Insert{RecordName}_SP";
        protected virtual string EditProcedureName => $"Update{RecordName}_SP";
        protected virtual string DeleteProcedureName => $"Delete{RecordName}_SP";

        public BaseRepository()
        {
            //todo: Move this to the config file.
            _database = new Database("Server =.; Database = StoreG12; integrated security = true; pooling = true;");
        }

        public int Add(T data)
        {
            object result = _database.ExecuteScalar(
                AddProcedureName,
                CommandType.StoredProcedure,
                GetParamsFromObject(data)
            );
            return Convert.ToInt32(result);
        }

        public void Edit(T data)
        {
            ExecuteProcedure(EditProcedureName, GetParamsFromObject(data));
        }

        public virtual void Delete(int id)
        {
            ExecuteProcedure(DeleteProcedureName, new SqlParameter() { ParameterName = "@ID", Value = id });
        }

        protected virtual SqlParameter[] GetParamsFromObject(T data)
        {
            var propNames = data.GetType().GetProperties();
            var sqlParameters = new List<SqlParameter>();
            foreach (var prop in propNames)
            {
                sqlParameters.Add(new SqlParameter($"@{prop.Name}", prop.GetValue(data)));
            };
            return sqlParameters.ToArray();
        }

        protected virtual void ExecuteProcedure(string procName, params SqlParameter[] sqlParams)
        {
            _database.ExecuteNonQuery(
                procName,
                CommandType.StoredProcedure,
                sqlParams
            );
        }
    }
}
