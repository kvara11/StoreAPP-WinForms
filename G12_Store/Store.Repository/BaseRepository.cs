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
            ExecuteObjectProcedure("Insert", data);
        }

        public void Edit(T data)
        {
            ExecuteObjectProcedure("Update", data);
        }

        public void Delete(T data)
        {
            ExecuteObjectProcedure("Delete", data);
        }

        public void ExecuteObjectProcedure(string procPrefix, T data)
        {
            var SpName = procPrefix + data.ToString().Substring(data.ToString().LastIndexOf('.') + 1) + "_SP";
            var propNames = data.GetType().GetProperties();
            var sqlParameters = new List<SqlParameter>();
            foreach (var prop in propNames)
            {
                sqlParameters.Add(new SqlParameter($"@{prop.Name}", prop.GetValue(data)));
            };
            _database.ExecuteNonQuery(
                SpName,
                CommandType.StoredProcedure,
                sqlParameters.ToArray()
                );
        }
    }
}
