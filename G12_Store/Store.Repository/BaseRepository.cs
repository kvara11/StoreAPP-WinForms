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
        protected virtual string AddProcedureName => $"Add{RecordName}_SP";
        protected virtual string EditProcedureName => $"Edit{RecordName}_SP";
        protected virtual string DeleteProcedureName => $"Delete{RecordName}_SP";

        public BaseRepository()
        {
            //todo: Move this to the config file.
            _database = new Database("Server =.; Database = StoreG12; integrated security = true; pooling = true;");
        }

        public void Add(T data)
        {
            var procedureName = ProcedureName("Insert", data.GetType());
            var parameters = GetParamsFromObject(data);
            ExecuteProcedure(procedureName, parameters);
        }

        public void Edit(T data)
        {
            var procedureName = ProcedureName("Update", data.GetType());
            var parameters = GetParamsFromObject(data);
            ExecuteProcedure(procedureName, parameters);
        }

        public virtual void Delete(T data)
        {
            var procedureName = ProcedureName("Delete", data.GetType());
            var objectID = data.GetType().GetProperty("ID").GetValue(data);
            ExecuteProcedure(procedureName, new SqlParameter() { ParameterName = "@ID", Value = objectID });
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

        protected virtual string ProcedureName(string procPrefix, Type objType)
        {
            return procPrefix + objType.ToString().Substring(objType.ToString().LastIndexOf('.') + 1) + "_SP";
        }
    }
}
