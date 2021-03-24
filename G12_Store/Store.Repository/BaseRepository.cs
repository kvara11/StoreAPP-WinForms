using System;
using DatabaseHelper;
using Store.Domain;
using System.Data;
using System.Data.SqlClient;

namespace Store.Repository
{
    public abstract class BaseRepository<T>
    {
        protected Database _database;

        public BaseRepository()
        {
            //todo: Move this to the config file.
            _database = new Database("Server =.; Database = StoreG12; integrated security = true; pooling = true;");
        }
        
        public void Add(T user)
        {

        }

        public void Edit(T user)
        {

        }

        public void Delete(T user)
        {

        }

    }
}
