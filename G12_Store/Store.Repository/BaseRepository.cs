using System;
using DatabaseHelper;

namespace Store.Repository
{
    public abstract class BaseRepository
    {
        protected Database _database;

        public BaseRepository()
        {
            _database = new Database("Server =.; Database = StoreG12; integrated security = true; pooling = true;");
        }

    }
}
