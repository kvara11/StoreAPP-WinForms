using DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Store.Repository
{
    public abstract class BaseRepository<T> where T : class, new()
    {
        protected Database _database;

        protected virtual string RecordName => this.GetType().Name.Replace("Repository", "");
        protected virtual string GetProcedureName => $"Get{RecordName}_SP";
        protected virtual string SelectProcedureName => $"Select{RecordName}_SP";
        protected virtual string AddProcedureName => $"Insert{RecordName}_SP";
        protected virtual string EditProcedureName => $"Update{RecordName}_SP";
        protected virtual string DeleteProcedureName => $"Delete{RecordName}_SP";

        public BaseRepository()
        {
            //todo: Move this to the config file.
            _database = new Database("Server =.; Database = StoreG12; integrated security = true; pooling = true;");
        }

        public T RowToObject(DataRow row)
        {
            var result = new T();

            var propNames = result.GetType().GetProperties();
            foreach (var prop in propNames)
            {
                var value = row[prop.Name];
                prop.SetValue(result, value);
            };
            return result;
        }

        public T Get(int id)
        {
            DataTable result = _database.GetTable(
                GetProcedureName,
                CommandType.StoredProcedure,
                new SqlParameter("@ID", id)
            );
            return RowToObject(result.Rows[0]);
        }

        public int Add(T data)
        {
            object result = _database.ExecuteScalar(
                AddProcedureName,
                CommandType.StoredProcedure,
                ObjectToParameters(data)
            );
            return Convert.ToInt32(result);
        }

        public void Edit(T data)
        {
            ExecuteProcedure(EditProcedureName, ObjectToParameters(data));
        }

        public virtual void Delete(int id)
        {
            ExecuteProcedure(DeleteProcedureName, new SqlParameter() { ParameterName = "@ID", Value = id });
        }

        protected virtual SqlParameter[] ObjectToParameters(T data)
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
